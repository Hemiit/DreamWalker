using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Bed : MonoBehaviour
{
    public Button btn_Bed;
    public List<string> line_bed = new List<string>();
	

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
        RoomCndt roomCndt = GameMgr.I.roomCtrl.roomCndt;
        if (roomCndt == RoomCndt.day)
        {
            if (Player.I.hasTalked == true)
            {
                Player.I.hasTalked = false;
                //Can go to bed and change the scene of the nightmare;
                print("Has talked with the Chameleon.");
                //UIMgr.I.pnl_Chatting.TryShowLine(line_bed[1]);

                GameMgr.I.roomCtrl.dayRoomProps.HideAllDayProps();
                GameMgr.I.roomCtrl.nightRoomProps.ShowAllNightProps();

                //Change the face to get off the bed.
                Player.I.animator.Play("PlayerIdel_Right");

                UIMgr.I.pnl_chatting.Hide();

                GameMgr.I.roomCtrl.roomCndt = RoomCndt.night;
            }
            else
            {
                //Show tips to talk with the Chameleon;
                print("U need to talk with the Chameleon.");
                UIMgr.I.pnl_chatting.TryShowLine(line_bed[0]);
            }
        }

        if (roomCndt == RoomCndt.night)
        {
            //=======TODO
            if (Player.I.hasKnockOffFlowerPot) //Can go to bed.
            {

            }
            else //Can not go to bed.
            {
                UIMgr.I.pnl_chatting.TryShowLine(line_bed[2]);
            }
        }



    }


}

