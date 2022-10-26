using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showOb2 : MonoBehaviour
{
    public GameObject InvScroll;
    public GameObject InvBtn;
    public GameObject BackBtn;

    public GameObject Mau;

    public GameObject PauseMenu;

    public void PushInvBtn(){
        InvScroll.SetActive(true);
        InvBtn.SetActive(false);
        BackBtn.SetActive(false);
    }

    public void touchScreen()
    {
        InvScroll.SetActive(false);
        InvBtn.SetActive(true);
        BackBtn.SetActive(true);
    }

    public void PushMauBtn()
    {
        Mau.SetActive(true);
    }

    public void ClosePushMauBtn()
    {
        Mau.SetActive(false);
    }

    public void Resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    
}
