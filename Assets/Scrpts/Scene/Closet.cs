using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closet : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        UIMgr.I.ui_room.ui_Closet.Show_btn_Closet();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        UIMgr.I.ui_room.ui_Closet.Hide_btn_Closet();
        UIMgr.I.ui_room.ui_Closet.Hide_OpenCloset();
    }
}
