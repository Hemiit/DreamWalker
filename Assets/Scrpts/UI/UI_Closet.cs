using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI_Closet : MonoBehaviour
{

    public Button btn_Closet;
    public GameObject openCloset;
    


    public void Init()
    {
        
        btn_Closet.onClick.AddListener(() =>
        {
            Show_OpenCloset();
        });
        
    }

    public void Show_btn_Closet()
    {
        btn_Closet.gameObject.SetActive(true);
    }

    public void Hide_btn_Closet()
    {
        btn_Closet.gameObject.SetActive(false);
    }

    private void Show_OpenCloset()
    {
        openCloset.SetActive(true);
        btn_Closet.gameObject.SetActive(false);
        
        
    }
    
    
    public void Hide_OpenCloset()
    {
        openCloset.SetActive(false);
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
