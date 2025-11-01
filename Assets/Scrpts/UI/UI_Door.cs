using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Door : MonoBehaviour
{
    public GameObject door;

    public GameObject text_Door;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Show_DoorText();
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        Hide_DoorText();
    }

    public void Show_DoorText()
    {
        text_Door.gameObject.SetActive(true);
    } 
    
    public void Hide_DoorText()
    {
        text_Door.gameObject.SetActive(false);
    }

    
}
