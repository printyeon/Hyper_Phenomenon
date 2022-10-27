using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H4P : MonoBehaviour
{
    public GameObject RoomDoorC;
    public GameObject easterg;
    public GameObject Mon;
    public GameObject noMon;

    bool eg = Dods_ChanceMaker.GetThisChanceResult_Percentage(5);
    bool isMonster = Dods_ChanceMaker.GetThisChanceResult_Percentage(20);

    private void Start()
    {
        if(isMonster)
        {
            Invoke("OutMon", 10.0f);
            Invoke("OffMon", 10.01f);

        }
    }

    public void pushRoomDoorBtnR()
    {
        RoomDoorC.SetActive(true);
        //5퍼의 확률로 이스터에그
        if (!isMonster && eg)
        {
            easterg.SetActive(true);
        }
        else if (isMonster)
        {
            Mon.SetActive(true);
        }
        else
        {
            noMon.SetActive(true);
        }

    }

    void OutMon()
    {

        //소리그거
        while(true)
            Debug.Log("asdfasdf");

        
    }

    void OffMon()
    {

        isMonster = false;
        //소리그거꺼

    }

    public void pushRoomDoorBtnL()
    {
        RoomDoorC.SetActive(false);
        easterg.SetActive(false);
        Mon.SetActive(false);
        noMon.SetActive(true);
    }


}
