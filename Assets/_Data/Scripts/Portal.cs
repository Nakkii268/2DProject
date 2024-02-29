using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Portal : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.CompareTag("Player");
      
        Loader.Load(Loader.Scene.GameScene);
        Debug.Log("aaaaaa");
        //PlayerSpawnManager spawnManager = new PlayerSpawnManager();
        
    }
  
}
