using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_NightstandDrawer : MonoBehaviour
{
    public Button btn_Nightstand;
    public Image img_NightstandDrawer;
    public Button goBack;

    public List<string> Line_Cigarette=new List<string>();

    public void Init()
    {


        btn_Nightstand.onClick.AddListener(() =>
        {
            Show_NightstandDrawer();
        });

        goBack.onClick.AddListener(() =>
        {
            Hide_NightstandDrawer();
        });

        this.gameObject.SetActive(false);
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Show_NightstandDrawer()
    {
        this.gameObject.SetActive(true);
        img_NightstandDrawer.gameObject.SetActive(true);
        Player.I.PlayerCanMove(false);
        Hide_btn_Nightstand();
    }
    public void Hide_NightstandDrawer()
    {
        this.gameObject.SetActive(false);
        img_NightstandDrawer.gameObject.SetActive(false);
        Player.I.PlayerCanMove(true);
        Show_btn_Nightstand();
    }

    public void Show_btn_Nightstand() { btn_Nightstand.gameObject.SetActive(true); }
    public void Hide_btn_Nightstand() { btn_Nightstand.gameObject.SetActive(false); }
}
