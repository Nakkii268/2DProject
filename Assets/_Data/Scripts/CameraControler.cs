using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using Unity.VisualScripting;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField]private  Transform player;
    private float xBound = .1f;
    private float yBound = .2f;

    private void Start()
    {
        player = Player.Instance.transform;
    }
    private void LateUpdate()
    {
        Vector2 moveDir = Vector2.zero;
        float deltaX = player.position.x - _camera.transform.position.x;
        float deltaY = player.position.y - _camera.transform.position.y;
        if (deltaX > xBound || deltaX < -xBound)
        {
            if (player.position.x > _camera.transform.position.x)
            {
                moveDir.x = deltaX - xBound;
            }
            else
            {
                moveDir.x = deltaX + xBound;
            }
        }
        if (deltaY > yBound || deltaY < -yBound)
        {
            if (player.position.y > _camera.transform.position.y)
            {
                moveDir.y = deltaY - yBound;
            }
            else
            {
                moveDir.y = deltaY + yBound;
            }
        }
        _camera.transform.position += new Vector3(moveDir.x, moveDir.y, 0);
    }
}
