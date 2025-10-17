using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Room : MonoBehaviour
{
    public GameObject nightstand_Drawer;

    public UI_NightstandDrawer ui_NightstandDrawer;


    public void Init() 
    {
        ui_NightstandDrawer.Init();
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
