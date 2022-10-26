using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toHotel1 : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("Hotel1Scene");
    }

    public void NewSceneChange()
    {
        SceneManager.LoadScene("Hotel1Scene");
    }
}
