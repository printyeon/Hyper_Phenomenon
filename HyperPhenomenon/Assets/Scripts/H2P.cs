using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H2P : MonoBehaviour
{
    public GameObject basement;
    public GameObject basementMonster;

    public GameObject UiOb;
    public GameObject DieOb;

    void Start()
    {
        //30퍼의 확률로 지하실 보이게 하기
       bool appear = Dods_ChanceMaker.GetThisChanceResult_Percentage(30);

        if (appear)
        {
            basement.SetActive(true);
        }
    }

    //지하실 누르면 게임 오버
    public void inBasement()
    {
        basementMonster.SetActive(true);
        UiOb.SetActive(false);
        StartCoroutine(Die());
    }

    IEnumerator Die()
    {
        yield return new WaitForSeconds(3.0f);
        DieOb.SetActive(true);
    }
    














}
