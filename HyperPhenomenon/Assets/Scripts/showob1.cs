using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showob1 : MonoBehaviour
{
    public GameObject HowToImg;
    public GameObject LibraryToast;

    public void PushHowToBtn()
    {
        HowToImg.SetActive(true);
        Time.timeScale = 0f;
    }

    public void PushCloseHowToBtn()
    {
        HowToImg.SetActive(false);
        Time.timeScale = 1f;
    }



    public void CloseLibraryToast()
    {
        LibraryToast.SetActive(false);
    }

    public void PushLibraryBtn()
    {
        LibraryToast.SetActive(true);
        Invoke("CloseLibraryToast", 2.0f);
    }
}


