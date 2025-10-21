using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Bed : MonoBehaviour
{
    public Button btn_Bed;
    public List<string> line_bed= new List<string>();

    public void Init()
    {
        Hide_btn_Bed();

        btn_Bed.onClick.AddListener(() =>
        {
            TryGoToBed();
        });
    }

    public void Show_btn_Bed() { btn_Bed.gameObject.SetActive(true); }
    public void Hide_btn_Bed() { btn_Bed.gameObject.SetActive(false); }

    private void TryGoToBed()
    {
        //TODO=====
        if (Player.I.hasTalked == true)
        {
            //Can go to bed and change the scene of the nightmare;
            print("Has talked with the Chameleon.");
        }
        else 
        {
            //Show tips to talk with the Chameleon;
            print("U need to talk with the Chameleon.");
            UIMgr.I.pnl_Chatting.TryShowLine(line_bed[0]);
        }
        

    }


}
