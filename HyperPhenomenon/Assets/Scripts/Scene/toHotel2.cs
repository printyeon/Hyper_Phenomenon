using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toHotel2 : MonoBehaviour
{
    public GameObject Alv;
    public GameObject InAlv;


    public void SceneChange()
    {
        SceneManager.LoadScene("Hotel2Scene");
        if (Drag.isPicClear1 == false || Drag.isPicClear2 == false)
        {
            Drag.isPicClear1 = false;
            Drag.isPicClear2 = false;
        }
        
    }

    public void toAlv()
    {
        Alv.SetActive(true);
        InAlv.SetActive(false);

    }

    public void toInAlv()
    {
        InAlv.SetActive(true);
        Alv.SetActive(false);

    }
}
