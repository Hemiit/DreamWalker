using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_ChameleonBox : MonoBehaviour
{

    public Button btn_ChameleonBox;

    public List<string> line_Chameleon = new List<string>();
    public void Init()
    {
        Hide_btn_ChameleonBox();

        btn_ChameleonBox.onClick.AddListener(() =>
        {
            Player.I.hasTalked = true;

            //Show Chatting box;
            //=line_Chameleon[0];
        });
    }

    public void Show_btn_ChameleonBox() { btn_ChameleonBox.gameObject.SetActive(true); }
    public void Hide_btn_ChameleonBox() { btn_ChameleonBox.gameObject.SetActive(false); }
}
