using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toOtherRoom : MonoBehaviour
{
    public GameObject room1;
    public GameObject room2;
    public GameObject room3;

    public void otherRoom()
    {
        room1.SetActive(true);
        room2.SetActive(false);
        room3.SetActive(false);

    }

}
