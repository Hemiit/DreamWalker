using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI_Closet : MonoBehaviour
{

    public Button btn_Closet;
    public GameObject openCloset;

    public Button btn_Safe;
    
    public GameObject safe;

    public GameObject UI_Safe;

    public Button goBack;
    
    


    public void Init()
    {
        
        btn_Closet.onClick.AddListener(() =>
        {
            Show_OpenCloset();
        });
        
        btn_Safe.onClick.AddListener(() =>
        {
            Show_Safe();
        });
        
        goBack.onClick.AddListener(() =>
        {
            Hide_Safe();
            goBack.gameObject.SetActive(false);
        });

    }



    public void Show_Safe()
    {
        safe.gameObject.SetActive(true);
        UI_Safe.gameObject.SetActive(true);
        goBack.gameObject.SetActive(true);
        
    }

    public void Hide_Safe()
    {
        safe.gameObject.SetActive(false);
        UI_Safe.gameObject.SetActive(false);
        btn_Safe.gameObject.SetActive(false);
    }

    public void Show_btn_Closet()
    {
        btn_Closet.gameObject.SetActive(true);
        btn_Safe.gameObject.SetActive(false);

    }

    public void Hide_btn_Closet()
    {
        btn_Closet.gameObject.SetActive(false);
    }

    private void Show_OpenCloset()
    {
        openCloset.SetActive(true);
        btn_Closet.gameObject.SetActive(false);
        btn_Safe.gameObject.SetActive(true);

    }
    
    
    public void Hide_OpenCloset()
    {
        openCloset.SetActive(false);
        btn_Safe.gameObject.SetActive(false);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
        openCloset.SetActive(false);
        btn_Closet.gameObject.SetActive(false);
        Init();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
