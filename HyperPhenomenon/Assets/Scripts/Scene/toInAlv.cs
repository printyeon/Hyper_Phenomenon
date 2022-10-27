using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toInAlv : MonoBehaviour
{
    public GameObject InAlv;
    public GameObject Alv;

    // Start is called before the first frame update
    public void ToInAlv()
    {
        InAlv.SetActive(true);
        Alv.SetActive(false);
    }

}
