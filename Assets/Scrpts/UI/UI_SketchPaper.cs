using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_SketchPaper : MonoBehaviour
{
    public GameObject sketch;

    public GameObject text_sketch;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Show_sketchText();
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        Hide_sketchText();
    }

    public void Show_sketchText()
    {
        text_sketch.gameObject.SetActive(true);
    } 
    
    public void Hide_sketchText()
    {
        text_sketch.gameObject.SetActive(false);
    }

}
