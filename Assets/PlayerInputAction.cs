//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/PlayerInputAction.inputactions
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

public partial class @PlayerInputAction: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputAction"",
    ""maps"": [
        {
            ""name"": ""PLayerInputAction"",
            ""id"": ""c770ba07-d240-4494-8b18-ac0339f588be"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""bb0875c9-74cf-4c8d-a301-5601ef25d94f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""167e058f-1502-4af8-aed4-f42b6aa51697"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""e8073896-d134-4566-8a73-aabad8e32025"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""53dc360b-05da-4785-9e38-a0ac866b22e1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseAiming"",
                    ""type"": ""Value"",
                    ""id"": ""6b9328f1-d267-4b15-9162-b8a8ad70ca24"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""79bb2aa9-7e7a-4a89-9605-ef67aad30d69"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""8a3be2b4-3ad3-4e9d-8209-d79079e041f9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1a8a0815-0a59-458d-9f32-077ca68d4ee6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""56981e91-ec2b-4ea0-8750-54faa1d7a241"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""56759b55-a1b3-4877-8c5f-4440b4770324"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4862b488-989e-4160-8dad-bebaa02c9f1a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrow"",
                    ""id"": ""c664ebff-156f-4743-95ef-9cee31bd28ff"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6ced626a-1b0e-49ae-b099-87e3d0eebc39"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""bf5f8c7f-c4f7-437a-8f61-2d2a21e69b12"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""22ca8d9f-118a-45a8-a798-15c89a5d2614"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""34672948-61ef-47c6-9968-bc61db064588"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""97b11d88-8ba7-450a-bc43-d503502640ee"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""73c99cb5-7c71-46a5-b2dc-0159f003fc92"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0aaa757b-e273-463f-b82b-5a47b9e2a360"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c3c0489-b2a5-4656-954e-bfedef5f49cd"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseAiming"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e5810d32-8aa5-4844-8938-ebf026fa87f6"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PLayerInputAction
        m_PLayerInputAction = asset.FindActionMap("PLayerInputAction", throwIfNotFound: true);
        m_PLayerInputAction_Move = m_PLayerInputAction.FindAction("Move", throwIfNotFound: true);
        m_PLayerInputAction_Interact = m_PLayerInputAction.FindAction("Interact", throwIfNotFound: true);
        m_PLayerInputAction_Attack = m_PLayerInputAction.FindAction("Attack", throwIfNotFound: true);
        m_PLayerInputAction_Inventory = m_PLayerInputAction.FindAction("Inventory", throwIfNotFound: true);
        m_PLayerInputAction_MouseAiming = m_PLayerInputAction.FindAction("MouseAiming", throwIfNotFound: true);
        m_PLayerInputAction_Pause = m_PLayerInputAction.FindAction("Pause", throwIfNotFound: true);
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

    // PLayerInputAction
    private readonly InputActionMap m_PLayerInputAction;
    private List<IPLayerInputActionActions> m_PLayerInputActionActionsCallbackInterfaces = new List<IPLayerInputActionActions>();
    private readonly InputAction m_PLayerInputAction_Move;
    private readonly InputAction m_PLayerInputAction_Interact;
    private readonly InputAction m_PLayerInputAction_Attack;
    private readonly InputAction m_PLayerInputAction_Inventory;
    private readonly InputAction m_PLayerInputAction_MouseAiming;
    private readonly InputAction m_PLayerInputAction_Pause;
    public struct PLayerInputActionActions
    {
        private @PlayerInputAction m_Wrapper;
        public PLayerInputActionActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PLayerInputAction_Move;
        public InputAction @Interact => m_Wrapper.m_PLayerInputAction_Interact;
        public InputAction @Attack => m_Wrapper.m_PLayerInputAction_Attack;
        public InputAction @Inventory => m_Wrapper.m_PLayerInputAction_Inventory;
        public InputAction @MouseAiming => m_Wrapper.m_PLayerInputAction_MouseAiming;
        public InputAction @Pause => m_Wrapper.m_PLayerInputAction_Pause;
        public InputActionMap Get() { return m_Wrapper.m_PLayerInputAction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PLayerInputActionActions set) { return set.Get(); }
        public void AddCallbacks(IPLayerInputActionActions instance)
        {
            if (instance == null || m_Wrapper.m_PLayerInputActionActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PLayerInputActionActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
            @Attack.started += instance.OnAttack;
            @Attack.performed += instance.OnAttack;
            @Attack.canceled += instance.OnAttack;
            @Inventory.started += instance.OnInventory;
            @Inventory.performed += instance.OnInventory;
            @Inventory.canceled += instance.OnInventory;
            @MouseAiming.started += instance.OnMouseAiming;
            @MouseAiming.performed += instance.OnMouseAiming;
            @MouseAiming.canceled += instance.OnMouseAiming;
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
        }

        private void UnregisterCallbacks(IPLayerInputActionActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
            @Attack.started -= instance.OnAttack;
            @Attack.performed -= instance.OnAttack;
            @Attack.canceled -= instance.OnAttack;
            @Inventory.started -= instance.OnInventory;
            @Inventory.performed -= instance.OnInventory;
            @Inventory.canceled -= instance.OnInventory;
            @MouseAiming.started -= instance.OnMouseAiming;
            @MouseAiming.performed -= instance.OnMouseAiming;
            @MouseAiming.canceled -= instance.OnMouseAiming;
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
        }

        public void RemoveCallbacks(IPLayerInputActionActions instance)
        {
            if (m_Wrapper.m_PLayerInputActionActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPLayerInputActionActions instance)
        {
            foreach (var item in m_Wrapper.m_PLayerInputActionActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PLayerInputActionActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PLayerInputActionActions @PLayerInputAction => new PLayerInputActionActions(this);
    public interface IPLayerInputActionActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnInventory(InputAction.CallbackContext context);
        void OnMouseAiming(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
