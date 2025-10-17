using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChamelenBox : MonoBehaviour
{


    public void Init()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        UIMgr.I.ui_room.ui_chameleonBox.Show_btn_ChameleonBox();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        UIMgr.I.ui_room.ui_chameleonBox.Hide_btn_ChameleonBox();
    }
}
