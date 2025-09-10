using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nightstand : MonoBehaviour
{
    public void Init() 
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //print($"{this.gameObject.name}| Touch |{collision.gameObject.name}");
        UIMgr.I.ui_room.ui_NightstandDrawer.Show_btn_Nightstand();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //print($"{this.gameObject.name}| Leave |{collision.gameObject.name}");
        UIMgr.I.ui_room.ui_NightstandDrawer.Hide_btn_Nightstand();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
