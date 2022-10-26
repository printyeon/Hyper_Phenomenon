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
        //30���� Ȯ���� ���Ͻ� ���̰� �ϱ�
       bool appear = Dods_ChanceMaker.GetThisChanceResult_Percentage(30);

        if (appear)
        {
            basement.SetActive(true);
        }
    }

    //���Ͻ� ������ ���� ����
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
