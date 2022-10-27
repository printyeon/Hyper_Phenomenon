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
        //5���� Ȯ���� �̽��Ϳ���
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

        //�Ҹ��װ�
        while(true)
            Debug.Log("asdfasdf");

        
    }

    void OffMon()
    {

        isMonster = false;
        //�Ҹ��װŲ�

    }

    public void pushRoomDoorBtnL()
    {
        RoomDoorC.SetActive(false);
        easterg.SetActive(false);
        Mon.SetActive(false);
        noMon.SetActive(true);
    }


}
