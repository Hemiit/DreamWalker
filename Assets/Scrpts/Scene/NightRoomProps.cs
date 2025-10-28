using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightRoomProps : MonoBehaviour
{
    public GameObject flowerpot_Night;
    public GameObject light_Night;
    public GameObject nightMirror;
    public GameObject papers;
    public GameObject drawingOnWall;


    public void Init()
    {
        HideAllNightProps();
    }

    public void Show_Flowerpot_Night()
    {
        flowerpot_Night.SetActive(true);
    }
    public void Hide_Flowerpot_Night()
    {
        flowerpot_Night.SetActive(false);
    }

    public void ShowAllNightProps()
    {
        light_Night.SetActive(true);
        flowerpot_Night.SetActive(true);
        nightMirror.SetActive(true);
        papers.SetActive(true);
        drawingOnWall.SetActive(true);
    }

    public void HideAllNightProps()
    {
        light_Night.SetActive(false);
        flowerpot_Night.SetActive(false);
        nightMirror.SetActive(false);
        papers.SetActive(false);
        drawingOnWall.SetActive(false);
    }

}
