using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] private Player _player;
    public event EventHandler OnInteractSomething;
   
    public event EventHandler OnOpenInventory;
    private void Start()
    {
        _player = Player.Instance;
        GameInput.Instance.OnOpenInventoryAction += GameInput_OnOpenInventoryAction;
        GameInput.Instance.OnInteractAction += GameInput_OnInteractAction;
    }
    private void GameInput_OnOpenInventoryAction(object sender, EventArgs e)
    {

        OnOpenInventory?.Invoke(this, EventArgs.Empty);
        Debug.Log("open bag");

    }
    private void GameInput_OnInteractAction(object sender, EventArgs e)
    {
        _player._playerCollider.ColliderAnother();
        _player._playerCollider.ColliderInteractable();
        Debug.Log("Interact");

    }
}
