using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SafeBtnGroup : MonoBehaviour
{
    public Button btn_1_up;
    public Button btn_1_down;
    public UI_Safe ui_safe;

    public void Init() 
    {
        ui_safe=UIMgr.I.ui_safe;

        btn_1_up.onClick.AddListener(()=>
        {
            ui_safe.SetValue(1,+1);
        });

        btn_1_down.onClick.AddListener(() =>
        {
            ui_safe.SetValue(1, -1);
        });


    }

}
