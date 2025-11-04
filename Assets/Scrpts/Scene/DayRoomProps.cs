using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayRoomProps : MonoBehaviour
{
    public GameObject flowerpot_Day;

	public GameObject plantfromfriend;

    public void Init ()
    {
        ShowAllDayProps();
    }

    public void Show_Flowerpot_Day() 
    {
        flowerpot_Day.SetActive(true);
    }
    public void Hide_Flowerpot_Day() 
    {
        flowerpot_Day.SetActive(false);
    }

    public void ShowAllDayProps() 
    {
        flowerpot_Day.SetActive(true);
	
        //Continue the props list here...


    }
    public void HideAllDayProps()
    {
        flowerpot_Day.SetActive(false);
		plantfromfriend.SetActive(false);

        //Continue the props list here...


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
