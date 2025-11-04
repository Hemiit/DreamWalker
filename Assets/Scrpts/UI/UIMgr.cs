using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMgr : MonoBehaviour
{
    public static UIMgr I;

    public UI_StartGame ui_startGame;
    public UI_Room ui_room;
    public UI_ItemSlots ui_itemSlots;
    public PnlChatting pnl_chatting;
    public UI_Safe ui_safe;
    public BlackCurtain blackCurtain;

    void Awake()
    {
        I = this;
        ui_startGame.Init();
        ui_room.Init();
        ui_itemSlots.Init();
        pnl_chatting.Init();
        ui_safe.Init();
        blackCurtain.Init();



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
