using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Mirror : MonoBehaviour
{
   public GameObject mirror;

    public GameObject text_mirror;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Show_mirrorText();
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        Hide_mirrorText();
    }

    public void Show_mirrorText()
    {
        text_mirror.gameObject.SetActive(true);
    } 
    
    public void Hide_mirrorText()
    {
        text_mirror.gameObject.SetActive(false);
    }

    
}
