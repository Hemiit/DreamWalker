using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SafeBtnGroup : MonoBehaviour
{
    public Button btn_1_up;
    public Button btn_1_down;
    public Button btn_2_up;
    public Button btn_2_down;
    public Button btn_3_up;
    public Button btn_3_down;
    public Button btn_4_up;
    public Button btn_4_down;
    public UI_Safe ui_safe;

    public void Init()
    {
        ui_safe = UIMgr.I.ui_safe;

        btn_1_up.onClick.AddListener(() => { ui_safe.SetValue(1, +1); });

        btn_1_down.onClick.AddListener(() => { ui_safe.SetValue(1, -1); });
            

        btn_2_up.onClick.AddListener(() => { ui_safe.SetValue(2, +1); });

        btn_2_down.onClick.AddListener(() => { ui_safe.SetValue(2, -1); });
        
        
        btn_3_up.onClick.AddListener(() => { ui_safe.SetValue(3, +1); });

        btn_3_down.onClick.AddListener(() => { ui_safe.SetValue(3, -1); });
        
        
        btn_4_up.onClick.AddListener(() => { ui_safe.SetValue(4, +1); });

        btn_4_down.onClick.AddListener(() => { ui_safe.SetValue(4, -1); });
        
    }


    

}
