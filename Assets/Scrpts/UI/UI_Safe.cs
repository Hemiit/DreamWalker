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
    
    public string correctPassword = "0628";

    public GameObject openSafe;
    
    


    public void Init()
    {
        safeBtnGroup.Init();

        txt_slot_1.text = "0";
        txt_slot_2.text = "0";
        txt_slot_3.text = "0";
        txt_slot_4.text = "0";

    }
    
    
    
    private void CheckPassword()
    {
        string pwattempt = txt_slot_1.text + txt_slot_2.text + txt_slot_3.text + txt_slot_4.text;

        if (pwattempt == correctPassword)
        {
            
            openSafe.SetActive(true);
            txt_slot_1.gameObject.SetActive(false);
            txt_slot_2.gameObject.SetActive(false);
            txt_slot_3.gameObject.SetActive(false);
            txt_slot_4.gameObject.SetActive(false);
            safeBtnGroup.gameObject.SetActive(false);
            
            
            Debug.Log("Safe Opened!");
            if (openSafe != null)
            {
                openSafe.SetActive(true);
            }
        }
    }


    
    public void SetValue(int slotPos, int change)
    {
        if (slotPos == 1)
        {
            if (change == +1)
            {
                txt_slot_1.text = (Convert.ToInt32(txt_slot_1.text) + 1).ToString();
            }

            if (change == -1)
            {
                txt_slot_1.text = (Convert.ToInt32(txt_slot_1.text) - 1).ToString();
            }

            int val = Convert.ToInt32(txt_slot_1.text);
            if (val > 9) val = 0;
            if (val < 0) val = 9;
            txt_slot_1.text = val.ToString();
            
            CheckPassword();
        }

        if (slotPos == 2)
        {
            if (change == +1)
            {
                txt_slot_2.text = (Convert.ToInt32(txt_slot_2.text) + 1).ToString();
            }

            if (change == -1)
            {
                txt_slot_2.text = (Convert.ToInt32(txt_slot_2.text) - 1).ToString();
            }
            
            int val = Convert.ToInt32(txt_slot_2.text);
            if (val > 9) val = 0;
            if (val < 0) val = 9;
            txt_slot_2.text = val.ToString();
            
            CheckPassword();
        }


        if (slotPos == 3)
        {
            if (change == +1)
            {
                txt_slot_3.text = (Convert.ToInt32(txt_slot_3.text) + 1).ToString();
            }

            if (change == -1)
            {
                txt_slot_3.text = (Convert.ToInt32(txt_slot_3.text) - 1).ToString();
            }
            
            int val = Convert.ToInt32(txt_slot_3.text);
            if (val > 9) val = 0;
            if (val < 0) val = 9;
            txt_slot_3.text = val.ToString();
            
            CheckPassword();
        }


        if (slotPos == 4)
        {
            if (change == +1)
            {
                txt_slot_4.text = (Convert.ToInt32(txt_slot_4.text) + 1).ToString();
            }

            if (change == -1)
            {
                txt_slot_4.text = (Convert.ToInt32(txt_slot_4.text) - 1).ToString();
            }
            
            int val = Convert.ToInt32(txt_slot_4.text);
            if (val > 9) val = 0;
            if (val < 0) val = 9;
            txt_slot_4.text = val.ToString();

            CheckPassword();
        }
    }
}
