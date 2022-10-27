using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toHotel4 : MonoBehaviour
{
    public void SceneChange()
    {
        //Invoke("Wait", 3.0f);
        SceneManager.LoadScene("Hotel4Scene");
    }
}
