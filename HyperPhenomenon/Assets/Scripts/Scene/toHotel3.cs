using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toHotel3 : MonoBehaviour
{
    public void SceneChange()
    {
        Invoke("Wait", 3.0f);
    }

    void Wait()
    {
        SceneManager.LoadScene("Hotel3Scene");
    }
}
