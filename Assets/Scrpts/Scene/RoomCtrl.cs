using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RoomCndt { day,night}
public class RoomCtrl : MonoBehaviour
{
    public Nightstand nightstand;
    public GameObject dayRoomProps;
    public GameObject nightRoomProps;
    public RoomCndt roomCndt = RoomCndt.day;

    public void Init() 
    {
        nightstand.Init();
        ShowDayRoomProps();
        HideNightRoomProps();
    }

    public void ShowDayRoomProps() 
    {
        dayRoomProps.SetActive(true); 
    }
    public void HideDayRoomProps() 
    {
        dayRoomProps.SetActive(false); 
    }
    public void ShowNightRoomProps() 
    {
        nightRoomProps.SetActive(true);
    }
    public void HideNightRoomProps() 
    {
        nightRoomProps.SetActive(false);
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
