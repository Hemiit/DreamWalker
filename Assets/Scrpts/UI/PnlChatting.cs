using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PnlChatting : MonoBehaviour
{

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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
