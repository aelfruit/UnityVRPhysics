using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;

//from class demo notes
public class VRInputController : MonoBehaviour
{
    [SerializeField]
    private float TriggerPressThreshold = 0.8f;

    // Publics are usually prefaced with a capital letter.
    public Vector2 Joystick;
    public float RightTrigger;
    public float RightGrip;
    public float PrimaryButton;
    public float SecondaryButton;
    //public float LeftTrigger;

    private float previousRightTrigger;
    //private float previousLeftTrigger;

    public bool RightTriggerPressed => previousRightTrigger < TriggerPressThreshold && RightTrigger > TriggerPressThreshold;
    //public bool LeftTriggerPressed => previousLeftTrigger < TriggerPressThreshold && LeftTrigger > TriggerPressThreshold;

    private VRInputActions actions;    

    // This is called ONLY in the editor when you modify any public
    // fields.
    private void OnValidate()
    {
        // Set the *length* of the joystick vector to never exceed 1.
        Joystick = Vector3.ClampMagnitude(Joystick, 1);
        RightTrigger = Mathf.Clamp01(RightTrigger);
        RightGrip = Mathf.Clamp01(RightGrip);
        PrimaryButton = Mathf.Clamp01(PrimaryButton);
        SecondaryButton = Mathf.Clamp01(SecondaryButton);
        //LeftTrigger = Mathf.Clamp01(LeftTrigger);
    }

    private void Awake()
    {
        actions = new VRInputActions();

        // If you don't call this, you won't be able to read input.
        // (Why is this not enabled by default? Beats me, ask Unity.)
        actions.Enable();
    }

    private void Update()
    {
        XRHMD hmd = InputSystem.GetDevice<XRHMD>();

        if (hmd != null)
        {
            Joystick = actions.Default.Joystick.ReadValue<Vector2>();
            RightTrigger = actions.Default.RightTrigger.ReadValue<float>();
            RightGrip = actions.Default.RightGrip.ReadValue<float>();
            PrimaryButton = actions.Default.PrimaryButton.ReadValue<float>();
            SecondaryButton = actions.Default.SecondaryButton.ReadValue<float>();
        }
    }

    private void LateUpdate()
    {
        previousRightTrigger = RightTrigger;
        //previousLeftTrigger = LeftTrigger;
    }
}
