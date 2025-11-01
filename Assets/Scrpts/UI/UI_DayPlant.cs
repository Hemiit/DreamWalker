using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_DayPlant : MonoBehaviour
{
    public GameObject dayplant;

    public GameObject text_dayplant;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Show_dayplanttext();
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        Hide_dayplanttext();
    }

    public void Show_dayplanttext()
    {
        text_dayplant.gameObject.SetActive(true);
    } 
    
    public void Hide_dayplanttext()
    {
        text_dayplant.gameObject.SetActive(false);
    }

}
