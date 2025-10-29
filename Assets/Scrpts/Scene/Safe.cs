using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Safe : MonoBehaviour
    
{ 
    public GameObject openSafe;


    public void Init()
    {
        
    }

    public void GoOpenSafe()
    {
        openSafe.gameObject.SetActive(true);
        
    }

    
}
    
    
