using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RefinedGrab : MonoBehaviour
{
    //class demo notes, make sure to setup VRInputController and the GrabbableObject Script
    public Transform grabOrigin;
    public float grabRadius = 0.1f;

    public bool triggerPressed;

    private GrabbableObject highlightedObject;
    private GrabbableObject heldObject;

    private VRInputController input;
    private VRInputActions vrInputActions;

    private void Awake()
    {
        vrInputActions = new VRInputActions();
        vrInputActions.Enable();
    }

    private void Update()
    {
        // Are we holding an object?
        if (heldObject != null)
        {
            if (vrInputActions.Default.PrimaryButton.WasPerformedThisFrame())
            {
                triggerPressed = false;
            }

            if (!triggerPressed)
            {
                heldObject.transform.parent = null;
                heldObject.GetComponent<Rigidbody>().isKinematic = false;
                heldObject.GetComponent<Collider>().isTrigger = false;
                heldObject.GetComponent<Rigidbody>().velocity = velocity;
                heldObject.GetComponent<Rigidbody>().angularVelocity = angularVelocity;

                heldObject = null;
            }
        }
        // If not, highlight and allow grabbing.
        else
        {
            if (highlightedObject != null)
            {
                highlightedObject.SetHighlight(false);
                highlightedObject = null;
            }

            // Are we hovering over any objects?
            // If so, which one?
            Collider[] cols = Physics.OverlapSphere(grabOrigin.position, grabRadius);

            // Did we hit anything at all?
            foreach (Collider col in cols)
            {
                GrabbableObject grabbable = col.GetComponent<GrabbableObject>();

                if (grabbable != null)
                {
                    // Grab the object if the user wants to (i.e., presses the trigger).
                    if (vrInputActions.Default.PrimaryButton.WasPerformedThisFrame())
                    {
                        triggerPressed = true;
                    }

                    if (triggerPressed)
                    {
                        heldObject = grabbable;

                        //heldObject.transform.SetParent(transform);
                        //heldObject.transform.position = Vector3.zero;
                        heldObject.transform.parent = transform;
                        heldObject.GetComponent<Rigidbody>().isKinematic = true;
                        heldObject.GetComponent<Collider>().isTrigger = true;
                    }
                    else
                    {
                        highlightedObject = grabbable;
                        highlightedObject.SetHighlight(true);
                    }

                    // Exit the loop, we've found something to grab!
                    break;
                }
            }
        }
    }

    private Vector3 previousPosition;
    private Vector3 velocity;

    private Quaternion previousRotation;
    private Vector3 angularVelocity;

    // This runs for EVERY physics step.
    private void FixedUpdate()
    {
        if (heldObject != null)
        {
            // Calculate the velocity in units per *frame*
            Vector3 displacement = heldObject.transform.position - previousPosition;

            // Get velocity in units per SECOND.
            velocity = displacement / Time.fixedDeltaTime;

            previousPosition = heldObject.transform.position;

            // "Subtract" the current rotation from the previous rotation.
            Quaternion delta = heldObject.transform.rotation * Quaternion.Inverse(previousRotation);

            // Convert it to an "angle axis", basically a direction and how rotated it is around that direction.
            delta.ToAngleAxis(out float angle, out Vector3 axis);

            // Lastly, convert it into radians per second.
            angularVelocity = (Mathf.Deg2Rad * angle / Time.fixedDeltaTime) * axis.normalized;

            previousRotation = heldObject.transform.rotation;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(grabOrigin.position, grabRadius);
    }
}
