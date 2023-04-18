using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.InputSystem;

// from class demo VR 
public class VRRig : MonoBehaviour
{
    public Transform head, left, right;

    private void Update()
    {
        if (XRController.leftHand != null)
        {
            // Update the transforms of the components of our VR rig,
            // i.e., the head and hands
            // "i.e." just means "in other words"
            Vector3 leftPosition = XRController.leftHand.devicePosition.ReadValue();
            Quaternion leftRotation = XRController.leftHand.deviceRotation.ReadValue();

            // Rotate leftRotation by 90 degrees around its x-axis
            leftRotation *= Quaternion.Euler(90f,0f,0f);

            left.localPosition = leftPosition;
            left.localRotation = leftRotation;
        }

        if (XRController.rightHand != null)
        {
            Vector3 rightPosition = XRController.rightHand.devicePosition.ReadValue();
            Quaternion rightRotation = XRController.rightHand.deviceRotation.ReadValue();

            // Rotate rightRotation by 90 degrees around its x-axis
            rightRotation *= Quaternion.Euler(90f, 0f, 0f);

            right.localPosition = rightPosition;
            right.localRotation = rightRotation;
        }

        XRHMD hmd = InputSystem.GetDevice<XRHMD>();

        if (hmd != null)
        {
            Vector3 headPosition = hmd.devicePosition.ReadValue();
            Quaternion headRotation = hmd.deviceRotation.ReadValue();

            head.localPosition = headPosition;
            head.localRotation = headRotation;
        }
    }
}