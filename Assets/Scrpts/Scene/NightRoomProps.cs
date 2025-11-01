using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NightRoomProps : MonoBehaviour
{
    public SpriteRenderer flowerpot_Night;
    public GameObject light_Night;
    public GameObject nightMirror;
    public GameObject papers;
    public GameObject drawingOnWall;
    public SpriteRenderer flowerpot_Night_OnGround;

    public GameObject sketchpapercollider;

    public void Init()
    {
        HideAllNightProps();
    }

    public void Show_Flowerpot_Night()
    {
        flowerpot_Night.gameObject.SetActive(true);
    }
    public void Hide_Flowerpot_Night()
    {
        flowerpot_Night.gameObject.SetActive(false);
    }

    public void ShowAllNightProps()
    {
        light_Night.SetActive(true);
        flowerpot_Night.gameObject.SetActive(true);
        nightMirror.SetActive(true);
        papers.SetActive(true);
        drawingOnWall.SetActive(true);
        sketchpapercollider.SetActive(true);
    }

    public void HideAllNightProps()
    {
        light_Night.SetActive(false);
        flowerpot_Night.gameObject.SetActive(false);
        nightMirror.SetActive(false);
        papers.SetActive(false);
        drawingOnWall.SetActive(false);
        sketchpapercollider.SetActive(false);
    }

}
