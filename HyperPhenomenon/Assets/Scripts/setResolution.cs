using System;
using UnityEngine;

public class setResolution : MonoBehaviour
{
    private void Start()
    {
        Resolution();
    }

    private void Resolution()
    {
        int setWidth = 1920;
        int setHeight = 1080;

        Screen.SetResolution(setWidth, setHeight, true);
    }
}
