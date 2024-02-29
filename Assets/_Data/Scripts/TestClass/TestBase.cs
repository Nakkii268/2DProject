using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TestBase : MonoBehaviour
{
    public abstract void MyFunction();
    private static TestBase instance;

    public static TestBase Instance
    {
        get
        {
            return instance;
        }
    }

    protected virtual void Awake()
    {
        instance = this;
    }

}


