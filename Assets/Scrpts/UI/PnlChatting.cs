using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PnlChatting : MonoBehaviour
{
    public GameObject chattingBox_player;
    public GameObject chattingBox_chameleon;
    public TextMeshProUGUI txt_PlayerLine;
    public TextMeshProUGUI txt_ChameleonLine;
    public Button btn_Back;

    public void Init() 
    {
        Hide();
        btn_Back.onClick.AddListener(()=>
        {
            //Currently, we only show one line for each line showing.
            Hide();
            btn_Back.gameObject.SetActive(false);
        });
    }

    public void TryShowLine(string line)
    {
        Show();
        btn_Back.gameObject.SetActive(true);

        string[] strArray = line.Split('|');
        string strMark = strArray[0];

        //If start with a P, this is the player line.
        //Start with a C, this is a chameleon line.
        if (strMark == "P")
        {
            ShowPlayerLine(strArray[1]);
        }

        if (strMark == "C")
        {
            ShowChameleonLine(strArray[1]);
        }
    }

    public void Hide() 
    {
        HidePlayerLine();
        HideChameleonLine();
        btn_Back.gameObject.SetActive(false);
        this.gameObject.SetActive(false);
    }
    public void Show() 
    {
        this.gameObject.SetActive(true);
    }

    private void ShowPlayerLine(string line) 
    {
        chattingBox_player.SetActive(true);
        txt_PlayerLine.text= line;
    }
    private void HidePlayerLine() 
    {
        chattingBox_player.SetActive(false);
        txt_PlayerLine.text = string.Empty;
    }
    private void ShowChameleonLine(string line) 
    {
        chattingBox_chameleon.SetActive(true);
        txt_ChameleonLine.text = line;
    }
    private void HideChameleonLine() 
    {
        chattingBox_chameleon.SetActive(false);
        txt_ChameleonLine.text=string.Empty;
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
