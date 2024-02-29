using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHpBarUI : MonoBehaviour
{
    [SerializeField] private Transform hasHpBarObject;
    [SerializeField] private IHasHpBar hasHpBar;
    [SerializeField] private Image HpBarImage;

    private void Start()
    {
        hasHpBar = hasHpBarObject.GetComponent<IHasHpBar>();
        if (hasHpBar == null)
        {
            Debug.Log("game object " + hasHpBarObject + "does not have component implement IHasHpBar");
        }

        hasHpBar.OnHpChange += HasHpBar_OnHpChange;

        HpBarImage.fillAmount = 1;
    }

    private void HasHpBar_OnHpChange(object sender, IHasHpBar.OnHpChangeEventArgs e)
    {
        HpBarImage.fillAmount = e.HpNormalized;

    }

}