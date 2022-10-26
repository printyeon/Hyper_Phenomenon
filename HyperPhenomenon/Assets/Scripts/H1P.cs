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

        //이거 수정해야함
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
        //그림 다른데에 있기
        //참이면 다른데로 이동
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
        //사람 다른사람이기
        bool other = Dods_ChanceMaker.GetThisChanceResult_Percentage(10);
        if (other)
        {
            tie.SetActive(true);
            ribbon.SetActive(false);
        }
    }

    void DarkFire()
    {
        //샹들리에 불끄기
        fireOff = Dods_ChanceMaker.GetThisChanceResult_Percentage(80);
        if (fireOff)
        {

            fire.SetActive(false);
        }
    }

    void HumanNo()
    {
        //사람 없기
        bool nohuman = Dods_ChanceMaker.GetThisChanceResult_Percentage(20);
        if (nohuman)
        {
            human.SetActive(false);
        }
    }

}
