using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_ItemSlots : MonoBehaviour
{
    public Image lighter;

    public void Init() 
    {
        lighter.gameObject.SetActive(false);
        Hide();
    }

    public void Show() { this.gameObject.SetActive(true); }
    public void Hide() { this.gameObject.SetActive(false); }


    public void ShowLighter() 
    {
        lighter.gameObject.SetActive(true);
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
