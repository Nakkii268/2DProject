using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestComponent : MonoBehaviour
{
   
    

    private void Update()
    {
        TestBase.Instance.MyFunction();
        Debug.Log(Player.Instance.HpMax);
        Debug.Log(Player.Instance.currentHp);

    }
    
}
