using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PnlChatting : MonoBehaviour
{
    public GameObject chattingBox_player;
    public GameObject chattingBox_chameleon;
    public TextMeshProUGUI txt_PlayerLine;
    public TextMeshProUGUI txt_ChameleonLine;

    public void Init() 
    {
        Hide();
    }

    public void Hide() 
    {
        this.gameObject.SetActive(false);
    }
    public void Show() 
    {
        this.gameObject.SetActive(true);
    }

    private void ShowPlayerLine() 
    {
        chattingBox_player.SetActive(true);
    }
    private void HidePlayerLine() 
    {
        chattingBox_player.SetActive(false); 
    }
    private void ShowChameleonLine() 
    {
        chattingBox_chameleon.SetActive(true);
    }
    private void HideChameleonLine() 
    {
        chattingBox_chameleon.SetActive(false);
    }

    public void TryShowLine(string line) 
    {
        line.Split('|');
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
