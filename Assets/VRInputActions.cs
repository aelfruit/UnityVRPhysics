//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/VRInputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @VRInputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @VRInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""VRInputActions"",
    ""maps"": [
        {
            ""name"": ""Default"",
            ""id"": ""21f4f372-1dbb-4ae7-a83d-d808c9e0e97b"",
            ""actions"": [
                {
                    ""name"": ""Primary"",
                    ""type"": ""Button"",
                    ""id"": ""d8668b8a-de52-4a22-bc51-b206a4e59492"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Joystick"",
                    ""type"": ""Value"",
                    ""id"": ""2732e1ac-2e67-4e61-84ba-c61e8963e633"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""RightTrigger"",
                    ""type"": ""Value"",
                    ""id"": ""86e67cea-c7de-4716-a95e-b73dd0fddbcd"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""LeftTrigger"",
                    ""type"": ""Value"",
                    ""id"": ""8e39317f-231e-48c3-b2eb-17a85dc18c48"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""RightGrip"",
                    ""type"": ""Value"",
                    ""id"": ""b8a39c3e-9d6a-4986-97b4-c68d6cbf4839"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""LeftGrip"",
                    ""type"": ""Value"",
                    ""id"": ""8a3c5e0e-c927-463d-84f6-be0045379985"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""xr_controller_button_b"",
                    ""type"": ""Button"",
                    ""id"": ""f3823bd0-72d2-483b-a816-4419862c81e2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PrimaryButton"",
                    ""type"": ""Value"",
                    ""id"": ""f7fd37ba-9d97-46a4-a713-b51dc5d86e4c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SecondaryButton"",
                    ""type"": ""Value"",
                    ""id"": ""968600d6-2406-49aa-b840-30b2002b897a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""26ff9fe1-5cce-4852-b590-519d1647bf32"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""40d2633b-90b1-4956-9576-49779507518d"",
                    ""path"": ""<OculusTouchController>/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Primary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c1088669-4e7d-4ac5-8119-882a8e68e671"",
                    ""path"": ""<OculusTouchController>/thumbstick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Joystick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d621cadb-e664-4468-b56e-f32d95649ef3"",
                    ""path"": ""<XRController>{RightHand}/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightTrigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c4b44ac-24b4-4ea7-b3f4-1bf52cfc4241"",
                    ""path"": ""<XRController>{LeftHand}/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftTrigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""249a4678-d7a5-4270-8160-11e9671bbe35"",
                    ""path"": ""<XRController>{RightHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightGrip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d491d862-2649-4826-92df-79a0345dc1e0"",
                    ""path"": ""<OculusTouchController>/secondaryButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""xr_controller_button_b"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""95f7d7b2-1cda-47e1-87d4-2864be013e8f"",
                    ""path"": ""<OculusTouchController>{RightHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2c85b674-16e4-475a-a1ce-7234b2b3df4c"",
                    ""path"": ""<OculusTouchController>{LeftHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b03935b-2e52-4b8e-ab74-747a197f1756"",
                    ""path"": ""<OculusTouchController>{RightHand}/secondaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""41c73f8f-e144-477a-8dd9-b29053501922"",
                    ""path"": ""<OculusTouchController>{LeftHand}/secondaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9dd415cd-d167-4b6c-8193-71c5b67ace2c"",
                    ""path"": ""<OculusTouchController>{LeftHand}/menu"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""43a98def-3eec-4442-aa88-785c7f41ab54"",
                    ""path"": ""<OculusTouchController>{LeftHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftGrip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Default
        m_Default = asset.FindActionMap("Default", throwIfNotFound: true);
        m_Default_Primary = m_Default.FindAction("Primary", throwIfNotFound: true);
        m_Default_Joystick = m_Default.FindAction("Joystick", throwIfNotFound: true);
        m_Default_RightTrigger = m_Default.FindAction("RightTrigger", throwIfNotFound: true);
        m_Default_LeftTrigger = m_Default.FindAction("LeftTrigger", throwIfNotFound: true);
        m_Default_RightGrip = m_Default.FindAction("RightGrip", throwIfNotFound: true);
        m_Default_LeftGrip = m_Default.FindAction("LeftGrip", throwIfNotFound: true);
        m_Default_xr_controller_button_b = m_Default.FindAction("xr_controller_button_b", throwIfNotFound: true);
        m_Default_PrimaryButton = m_Default.FindAction("PrimaryButton", throwIfNotFound: true);
        m_Default_SecondaryButton = m_Default.FindAction("SecondaryButton", throwIfNotFound: true);
        m_Default_Menu = m_Default.FindAction("Menu", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Default
    private readonly InputActionMap m_Default;
    private IDefaultActions m_DefaultActionsCallbackInterface;
    private readonly InputAction m_Default_Primary;
    private readonly InputAction m_Default_Joystick;
    private readonly InputAction m_Default_RightTrigger;
    private readonly InputAction m_Default_LeftTrigger;
    private readonly InputAction m_Default_RightGrip;
    private readonly InputAction m_Default_LeftGrip;
    private readonly InputAction m_Default_xr_controller_button_b;
    private readonly InputAction m_Default_PrimaryButton;
    private readonly InputAction m_Default_SecondaryButton;
    private readonly InputAction m_Default_Menu;
    public struct DefaultActions
    {
        private @VRInputActions m_Wrapper;
        public DefaultActions(@VRInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Primary => m_Wrapper.m_Default_Primary;
        public InputAction @Joystick => m_Wrapper.m_Default_Joystick;
        public InputAction @RightTrigger => m_Wrapper.m_Default_RightTrigger;
        public InputAction @LeftTrigger => m_Wrapper.m_Default_LeftTrigger;
        public InputAction @RightGrip => m_Wrapper.m_Default_RightGrip;
        public InputAction @LeftGrip => m_Wrapper.m_Default_LeftGrip;
        public InputAction @xr_controller_button_b => m_Wrapper.m_Default_xr_controller_button_b;
        public InputAction @PrimaryButton => m_Wrapper.m_Default_PrimaryButton;
        public InputAction @SecondaryButton => m_Wrapper.m_Default_SecondaryButton;
        public InputAction @Menu => m_Wrapper.m_Default_Menu;
        public InputActionMap Get() { return m_Wrapper.m_Default; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DefaultActions set) { return set.Get(); }
        public void SetCallbacks(IDefaultActions instance)
        {
            if (m_Wrapper.m_DefaultActionsCallbackInterface != null)
            {
                @Primary.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnPrimary;
                @Primary.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnPrimary;
                @Primary.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnPrimary;
                @Joystick.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnJoystick;
                @Joystick.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnJoystick;
                @Joystick.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnJoystick;
                @RightTrigger.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnRightTrigger;
                @RightTrigger.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnRightTrigger;
                @RightTrigger.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnRightTrigger;
                @LeftTrigger.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnLeftTrigger;
                @LeftTrigger.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnLeftTrigger;
                @LeftTrigger.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnLeftTrigger;
                @RightGrip.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnRightGrip;
                @RightGrip.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnRightGrip;
                @RightGrip.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnRightGrip;
                @LeftGrip.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnLeftGrip;
                @LeftGrip.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnLeftGrip;
                @LeftGrip.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnLeftGrip;
                @xr_controller_button_b.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnXr_controller_button_b;
                @xr_controller_button_b.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnXr_controller_button_b;
                @xr_controller_button_b.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnXr_controller_button_b;
                @PrimaryButton.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnPrimaryButton;
                @PrimaryButton.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnPrimaryButton;
                @PrimaryButton.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnPrimaryButton;
                @SecondaryButton.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnSecondaryButton;
                @SecondaryButton.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnSecondaryButton;
                @SecondaryButton.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnSecondaryButton;
                @Menu.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMenu;
            }
            m_Wrapper.m_DefaultActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Primary.started += instance.OnPrimary;
                @Primary.performed += instance.OnPrimary;
                @Primary.canceled += instance.OnPrimary;
                @Joystick.started += instance.OnJoystick;
                @Joystick.performed += instance.OnJoystick;
                @Joystick.canceled += instance.OnJoystick;
                @RightTrigger.started += instance.OnRightTrigger;
                @RightTrigger.performed += instance.OnRightTrigger;
                @RightTrigger.canceled += instance.OnRightTrigger;
                @LeftTrigger.started += instance.OnLeftTrigger;
                @LeftTrigger.performed += instance.OnLeftTrigger;
                @LeftTrigger.canceled += instance.OnLeftTrigger;
                @RightGrip.started += instance.OnRightGrip;
                @RightGrip.performed += instance.OnRightGrip;
                @RightGrip.canceled += instance.OnRightGrip;
                @LeftGrip.started += instance.OnLeftGrip;
                @LeftGrip.performed += instance.OnLeftGrip;
                @LeftGrip.canceled += instance.OnLeftGrip;
                @xr_controller_button_b.started += instance.OnXr_controller_button_b;
                @xr_controller_button_b.performed += instance.OnXr_controller_button_b;
                @xr_controller_button_b.canceled += instance.OnXr_controller_button_b;
                @PrimaryButton.started += instance.OnPrimaryButton;
                @PrimaryButton.performed += instance.OnPrimaryButton;
                @PrimaryButton.canceled += instance.OnPrimaryButton;
                @SecondaryButton.started += instance.OnSecondaryButton;
                @SecondaryButton.performed += instance.OnSecondaryButton;
                @SecondaryButton.canceled += instance.OnSecondaryButton;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
            }
        }
    }
    public DefaultActions @Default => new DefaultActions(this);
    public interface IDefaultActions
    {
        void OnPrimary(InputAction.CallbackContext context);
        void OnJoystick(InputAction.CallbackContext context);
        void OnRightTrigger(InputAction.CallbackContext context);
        void OnLeftTrigger(InputAction.CallbackContext context);
        void OnRightGrip(InputAction.CallbackContext context);
        void OnLeftGrip(InputAction.CallbackContext context);
        void OnXr_controller_button_b(InputAction.CallbackContext context);
        void OnPrimaryButton(InputAction.CallbackContext context);
        void OnSecondaryButton(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
    }
}
