using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{
   public static GameInput Instance { get; private set; }
    private PlayerInputAction playerInputAction;
    public event EventHandler OnInteractAction;
    public event EventHandler OnAttackAction;
    public event EventHandler OnOpenInventoryAction;
    public event EventHandler OnGamePauseAction;   

    private void Awake()
    {

        if(Instance == null|| Instance == this)
        {
        Instance = this;
        }
        
        //DontDestroyOnLoad(Instance.gameObject);
        
        if(playerInputAction == null)
        {
        playerInputAction = new PlayerInputAction();

        }
        playerInputAction.PLayerInputAction.Enable();
        playerInputAction.PLayerInputAction.Interact.performed += Interact_performed;
        playerInputAction.PLayerInputAction.Attack.performed += Attack_performed;
        playerInputAction.PLayerInputAction.Inventory.performed += Inventory_performed;
        playerInputAction.PLayerInputAction.Pause.performed += Pause_performed;

    
    }

    private void Pause_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnGamePauseAction?.Invoke(this,EventArgs.Empty);
    }

    private void Inventory_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnOpenInventoryAction?.Invoke(this, EventArgs.Empty);
       
    }

    private void Interact_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnInteractAction?.Invoke(this, EventArgs.Empty);
    }

    private void Attack_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnAttackAction?.Invoke(this, EventArgs.Empty);
       
    }

    public Vector2 GetMovementVectorNormalized()
    {
        Vector2 inputVector = playerInputAction.PLayerInputAction.Move.ReadValue<Vector2>();
        inputVector.Normalize();
        return inputVector;
    }

    public Vector2 GetMousePosition()
    {
        Vector2 mousePos = playerInputAction.PLayerInputAction.MouseAiming.ReadValue<Vector2>();
      
        return mousePos;
    }
}
