using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toMain : MonoBehaviour
{

    public void SceneChange()
    {
        SceneManager.LoadScene("MainScene");
        Drag.isPicClear1 = false;
        Drag.isPicClear2 = false;
    }
}
