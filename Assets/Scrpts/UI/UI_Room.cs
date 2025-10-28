using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Room : MonoBehaviour
{
    public GameObject nightstand_Drawer;

    public UI_NightstandDrawer ui_NightstandDrawer;
    public UI_Bed ui_Bed;
    public UI_ChameleonBox ui_chameleonBox;

    public UI_Closet ui_Closet;
    
    public void Init() 
    {
        ui_NightstandDrawer.Init();
        ui_Bed.Init();
        ui_chameleonBox.Init();
       
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
