using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H1P : MonoBehaviour
{
    public GameObject pic1;
    Transform pic1T;
    public GameObject pic2;
    Transform pic2T;

    public GameObject fire;

    public GameObject ribbon;
    public GameObject tie;

    public GameObject human;

    bool picOther;
    bool fireOff;

    void Start()
    {
        if (!picOther && Drag.isPicClear1 != true || Drag.isPicClear2 != true)
        {
            PictureOther();
        }

        //�̰� �����ؾ���
        if (!fireOff)
        {
            DarkFire();
        }
        
        HumanNo();
        PeopleOther();




    }

    private void Update()
    {

        //Debug.Log(Drag.isPicClear);
        
    }

    void PictureOther()
    {
        //�׸� �ٸ����� �ֱ�
        //���̸� �ٸ����� �̵�
        picOther = Dods_ChanceMaker.GetThisChanceResult_Percentage(80);
        if (picOther)
        {

            if (Drag.isPicClear1 != true || Drag.isPicClear2 != true)
            {

                pic1T = pic1.GetComponent<Transform>();
                pic2T = pic2.GetComponent<Transform>();

                pic1T.position = new Vector2(35.63f, 90.50f);
                pic2T.position = new Vector2(621.38f, 88.25f);
                
            }
        }
    }

    void PeopleOther()
    {
        //��� �ٸ�����̱�
        bool other = Dods_ChanceMaker.GetThisChanceResult_Percentage(10);
        if (other)
        {
            tie.SetActive(true);
            ribbon.SetActive(false);
        }
    }

    void DarkFire()
    {
        //���鸮�� �Ҳ���
        fireOff = Dods_ChanceMaker.GetThisChanceResult_Percentage(80);
        if (fireOff)
        {

            fire.SetActive(false);
        }
    }

    void HumanNo()
    {
        //��� ����
        bool nohuman = Dods_ChanceMaker.GetThisChanceResult_Percentage(20);
        if (nohuman)
        {
            human.SetActive(false);
        }
    }

}
