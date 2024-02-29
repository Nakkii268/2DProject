using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundMouse : MonoBehaviour
{
    public Transform center;

    [SerializeField] private float radius;

    private Vector3 orbVector;

    private void Start()
    {
        center = Player.Instance.transform;
    }

    private void Update()
    {
        orbVector = Camera.main.WorldToScreenPoint(center.position);
        orbVector = Input.mousePosition - orbVector;
        float angle = Mathf.Atan2(orbVector.y, orbVector.x) * Mathf.Rad2Deg;

        
        gameObject.transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
        transform.position = center.position + (Quaternion.Euler(0, 0, angle) * Vector3.right * radius);
     
       
    }
}
