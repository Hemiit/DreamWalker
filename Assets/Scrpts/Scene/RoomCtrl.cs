using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RoomCndt { day,night}
public class RoomCtrl : MonoBehaviour
{
    public RoomCndt roomCndt = RoomCndt.day;

    public Nightstand nightstand;
    public DayRoomProps dayRoomProps;
    public NightRoomProps nightRoomProps;
    public Safe safe;

  
    
    public void Init() 
    {
        nightstand.Init();
        dayRoomProps.Init();
        nightRoomProps.Init();
        safe.Init();
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
