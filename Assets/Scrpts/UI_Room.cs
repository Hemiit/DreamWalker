using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Room : MonoBehaviour
{
    public GameObject nightstand_Drawer;


    public void Init() 
    {
        Hide_NightstandDrawer();



    }

    public void Show_NightstandDrawer() 
    {
        nightstand_Drawer.SetActive(true);
    }
    public void Hide_NightstandDrawer()
    {
        nightstand_Drawer.SetActive(false);
    }


}
