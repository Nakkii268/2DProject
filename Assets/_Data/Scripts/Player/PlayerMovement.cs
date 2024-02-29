using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private BoxCollider2D boxCollider;
    [SerializeField] private Player _player;
    
   private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        HandleMovement();
    }
    private void HandleMovement()
    {
        Vector2 inputVector = GameInput.Instance.GetMovementVectorNormalized();
        Vector2 moveDir = new Vector2(inputVector.x, inputVector.y);

        float moveDistance = _player._playerAttribute.Speed * Time.deltaTime;
        RaycastHit2D hit;
        //check x collider
        hit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.size, 0, new Vector2(moveDir.x, 0), 0f, LayerMask.GetMask("Item", "Block", "Enemy"));

        if (hit.collider)
        {
            moveDir.x = 0;
            BoundBack();
            // Debug.Log("Colide");


        }
        //check Y collider
        hit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.size, 0, new Vector2(0, moveDir.y), 0f, LayerMask.GetMask("Item", "Block", "Enemy"));

        if (hit.collider)
        {
            moveDir.y = 0;
            BoundBack();
            //Debug.Log("Colide");
        }

        transform.Translate(moveDir * moveDistance);

    }
    private void BoundBack()
    {
        transform.Translate(-GameInput.Instance.GetMovementVectorNormalized() * .1f);
    }
}
