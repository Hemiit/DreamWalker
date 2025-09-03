using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMgr : MonoBehaviour
{
    public static UIMgr I;

    public UI_StartGame ui_startGame;
    public UI_Room ui_room;

    void Awake()
    {
        I = this;
        ui_startGame.Init();
        ui_room.Init();
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
