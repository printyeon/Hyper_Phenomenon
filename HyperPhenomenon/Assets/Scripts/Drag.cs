using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    public static bool isPicClear1 = false;
    public static bool isPicClear2 = false;

    public GameObject pic1;
    public GameObject pic1b;

    public GameObject pic2;
    public GameObject pic2b;

    Vector2 pic1Pos;
    Vector2 pic2Pos;

  

    private void Start()
    {
        pic1Pos = pic1.transform.position;
        pic2Pos = pic2.transform.position;
    }

    public void Dragpic1()
    {
        pic1.transform.position = Input.mousePosition;
    }

    public void Dragpic2()
    {
        pic2.transform.position = Input.mousePosition;

    }

    public void Droppic1()
    {
        float Distance1 = Vector2.Distance(pic1.transform.position, pic1b.transform.position);
        if (Distance1 < 50)
        {
            pic1.transform.position = pic1b.transform.position;
            isPicClear1=true;

        }
        else
        {
            pic1.transform.position = pic1Pos;
        }
    }

    public void Droppic2()
    {
        float Distance2 = Vector2.Distance(pic2.transform.position, pic2b.transform.position);
        if (Distance2 < 50)
        {
            pic2.transform.position = pic2b.transform.position;
            isPicClear2= true;
        }
        else
        {
            pic2.transform.position = pic2Pos;
        }
    }

}
