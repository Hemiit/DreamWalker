using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_Safe : MonoBehaviour
{
    public SafeBtnGroup safeBtnGroup;
    public TextMeshProUGUI txt_slot_1;
    public TextMeshProUGUI txt_slot_2;
    public TextMeshProUGUI txt_slot_3;
    public TextMeshProUGUI txt_slot_4;


    public void Init() 
    {
        safeBtnGroup.Init();
        txt_slot_1.text = "0";



    }

    public void SetValue(int slotPos,int change) 
    {
        if (slotPos==1) 
        {
            if (change == +1) 
            {
                txt_slot_1.text=(Convert.ToInt32(txt_slot_1.text) + 1).ToString();
            }
            if (change == -1) 
            {
                txt_slot_1.text = (Convert.ToInt32(txt_slot_1.text) - 1).ToString();
            }
        }

        if (slotPos==2) 
        {

        }
    }



}