using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class BoomerangEffect : MonoBehaviour
{
    public float throwSpeed = 20f; // speed of the boomerang
    public float rotateSpeed = 200f; // speed at which the boomerang rotates
    public float returnSpeed = 5f; // speed at which the boomerang returns to the player's hand
    public float travelDistance = 10f; // distance of the boomerang should travel before returning
    private bool isThrown = false; // flag to track whether the boomerang has been thrown
    private bool isReturning = false; // flag to track whether the boomerang is returning
    private Vector3 throwDirection; // direction in which the boomerang was thrown
    private Quaternion throwRotation; // rotation of the player's arm when the boomerang was thrown
    private Vector3 targetPosition; // position to which the boomerang should travel before returning

    private VRInputActions vrInputActions;
    private InputAction bButtonAction;
    private InputAction yButtonAction; // Reference to the Y button input action

    private void Awake()
    {
        vrInputActions = new VRInputActions();
        vrInputActions.Enable();
        
        // Get a reference to the B button input action
        bButtonAction = new InputAction("B Button", InputActionType.Button, "<XRController>{RightHand}/buttonNorth");
        // Bind the B button input action to the OnBButtonPressed method when pressed
        bButtonAction.performed += OnButtonPressed;

        // Get a reference to the Y button input action
        yButtonAction = new InputAction("Y Button", InputActionType.Button, "<XRController>{LeftHand}/buttonWest");
        // Bind the Y button input action to the OnYButtonPressed method when pressed
        yButtonAction.performed += OnButtonPressed;
    }

    // Update is called once per frame
    void Update()
    {
        if (vrInputActions.Default.SecondaryButton.WasPerformedThisFrame())
        {
            Debug.Log("SeconderyButton Pressed");
            isThrown = true;
            throwDirection = transform.parent.forward;
            throwRotation = transform.parent.rotation;
            targetPosition = transform.parent.position + throwDirection * travelDistance;
            Debug.Log(targetPosition);
        }
        // check if the player has pressed the "Space" key and the boomerang hasn't been thrown yet.
        // -----Player can throw the weapon-----
        // get weapon's rotation and target position.
        //if (Input.GetKeyDown(KeyCode.Space) && !isThrown)
        if (!isThrown)
        {
            OnEnable();
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isThrown = true;
                throwDirection = transform.parent.forward;
                throwRotation = transform.parent.rotation;
                targetPosition = transform.parent.position + throwDirection * travelDistance;
                Debug.Log(targetPosition);
            }
        }
        
        // check if isThrown is true.
        // -----* Weapon starts moving and rotating through the air towards its target position
        if (isThrown)
        {
            OnDisable();
            transform.Rotate(Vector3.right, rotateSpeed * Time.deltaTime);// rotate the boomerang
            
            if (!isReturning)
            {

                transform.position = Vector3.MoveTowards(transform.position, targetPosition, throwSpeed * Time.deltaTime); // move the boomerang towards its target
                //transform.position = Vector3.Lerp(transform.position, targetPosition, throwSpeed * Time.deltaTime); // move the boomerang towards its target
                // check if the weapon has reached its target
                // -----* Weapon starts returning it to the player's hand
                if (transform.position == targetPosition)
                {
                    isReturning = true;
                    targetPosition = transform.parent.position; // set weapon target position to player's hand
                    Debug.Log(targetPosition);
                }
            }
            // if the boomerang has returned to the player's hand, reset its state
            else if (isReturning)
            {
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, returnSpeed * Time.deltaTime); // move the boomerang towards player's hand
                if (transform.position == targetPosition)
                {
                    transform.position = transform.parent.position;
                    transform.rotation = transform.parent.rotation;
                    isThrown = false;
                    isReturning = false;
                }
            }
        }
    }
    // checks if the object that the boomerang has collided with has a "tag" that is set to "MonsterBody"
    // -----Destroy the monster when hit by the boomerang-----
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter Collid");
        if (isThrown && other.CompareTag("MonsterBody"))
        {
            Destroy(other.gameObject);
        }
    }

    private void OnEnable()
    {
        // Enable the B button input action
        bButtonAction.Enable();
        // Enable the Y button input action
        yButtonAction.Enable();
    }

    private void OnDisable()
    {
        // Disable the B button input action
        bButtonAction.Disable();
        // Disable the Y button input action
        yButtonAction.Disable();
    }

    private void OnButtonPressed(InputAction.CallbackContext context)
    {
        isThrown = true;
        throwDirection = transform.parent.forward;
        throwRotation = transform.parent.rotation;
        targetPosition = transform.parent.position + throwDirection * travelDistance;
        Debug.Log(targetPosition);
    }
}