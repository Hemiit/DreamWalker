using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : MonoBehaviour
{
    public void Init()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //print($"{this.gameObject.name}| Touch |{collision.gameObject.name}");
        UIMgr.I.ui_room.ui_Bed.Show_btn_Bed();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //print($"{this.gameObject.name}| Leave |{collision.gameObject.name}");
        UIMgr.I.ui_room.ui_Bed.Hide_btn_Bed();
        UIMgr.I.pnl_Chatting.Hide();
    }



}
