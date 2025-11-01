using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Desk : MonoBehaviour
{
    public GameObject desk;

    public GameObject text_Desk;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Show_DeskText();
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        Hide_DeskText();
    }

    public void Show_DeskText()
    {
        text_Desk.gameObject.SetActive(true);
    } 
    
    public void Hide_DeskText()
    {
        text_Desk.gameObject.SetActive(false);
    }

}
