using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Test : MonoBehaviour
{
    public static Test Instance { get; private set; }
    [SerializeField] internal PlayerMovement _playerMovement;
    [SerializeField] internal PlayerAttribute _playerAttribute;
    [SerializeField] internal PlayerInteract _playerInteract;
    [SerializeField] internal PlayerCollider _playerCollider;
    [SerializeField] internal Attack _playerAttack;
    [SerializeField] internal PlayerInventory _playerInventory;
}
