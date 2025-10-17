using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_StartGame : MonoBehaviour
{
    public Transform title;
    public Button btn_NewGame;
    public Button btn_Continue;
    public Button btn_Option;
    public Button btn_Quit;


    public void Init() 
    {
        
        btn_NewGame.onClick.AddListener(()=>
        {
            this.gameObject.SetActive(false);
            UIMgr.I.ui_itemSlots.Show();
            UIMgr.I.ui_room.Show();
        });

        title.localPosition = new Vector3(23, 728, 0);
        this.gameObject.SetActive(true);

        AnimShow();
    }
    
    private void AnimShow() 
    {
        DOTween.Sequence()
            .AppendInterval(1f)
            .Append(title.DOLocalMoveY(280f,1.5f));
    }

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        
    }
}
