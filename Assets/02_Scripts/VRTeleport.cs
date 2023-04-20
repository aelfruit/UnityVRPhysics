using UnityEngine;

// from class demo: VR Teleport  notes
public class VRTeleport : MonoBehaviour
{
    public Transform head;
    public Transform hand;
    public bool Teleport;
    public Vector3 TeleportTarget;
    //private VRInputController input;
    private VRInputActions vrInputActions;
    private void Awake()
    {
        //input = GetComponent<VRInputController>();
        vrInputActions = new VRInputActions();
        vrInputActions.Enable();
    }
    private void Update()
    {
        if (Physics.Raycast(hand.position, hand.forward, out RaycastHit hit))
        {
            TeleportTarget = hit.point;
        }
        Vector3 directionToHead = transform.position - head.position;
        directionToHead.y = 0;
        // If the user presses the trigger? If they do *something*.
        // They point the controller somewhere, getting a
        // location they want to move to.
        if (vrInputActions.Default.RightGrip.WasPerformedThisFrame())
        //if (input.RightTriggerPressed)
        {
            // Teleport the...rig? To the target position.
            transform.position = TeleportTarget + directionToHead;
            Teleport = false;
        }
        Debug.DrawLine(transform.position, head.position, Color.cyan, 0);
        Debug.DrawLine(transform.position, TeleportTarget, Color.yellow, 0);
        Debug.DrawRay(TeleportTarget, directionToHead, Color.red, 0);
    }
}