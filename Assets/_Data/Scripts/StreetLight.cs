using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetLight : MonoBehaviour, IInteractable
{
    [SerializeField] private Transform lightOn;
    [SerializeField] private Transform lightOff;
    [SerializeField] private Transform light2D;

    [SerializeField]private bool isLightOn;

    public InteractUI InteractUI { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    private void Start()
    {
        LightOff();
    }
    public void InteractHandler()
    {
        if(!isLightOn)
        {
            LightOn();
        }
        else
        {
            LightOff();
        }
    }

    private void LightOn()
    {
        lightOn.gameObject.SetActive(true);
        light2D.gameObject.SetActive(true);
        lightOff.gameObject.SetActive(false);
        isLightOn =true;

    }
    private void LightOff()
    {
        lightOff.gameObject.SetActive(true);
        lightOn.gameObject.SetActive(false);
        light2D.gameObject.SetActive(false);
        isLightOn=false;
    }
}
