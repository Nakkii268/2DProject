using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractUI : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        
        Hide();
    }

    
   

    public void Show()
    {
        this.gameObject.SetActive(true);
        
    }
    public void Hide()
    {
        this.gameObject.SetActive(false);
    }
}
