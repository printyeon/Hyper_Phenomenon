using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class istouchScreen : MonoBehaviour
{
    public GameObject Inv;
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Debug.Log("a");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.gameObject.tag);
                if (hit.transform.gameObject.tag != "Inv")
                {
                    Inv.SetActive(false);
                }
                    
            }
        }
    }
}
