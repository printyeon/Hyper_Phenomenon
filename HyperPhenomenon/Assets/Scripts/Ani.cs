using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ani : MonoBehaviour
{
    public Animation a;
    public Animation b;
    public Animation c;

     public AnimationClip ac;
    public AnimationClip bc;
    public AnimationClip cc;

    /*
    void Start()
    {
        a = GetComponent<Animation>();
        b = GetComponent<Animation>();
        c = GetComponent<Animation>();
    }
    */
    public void btnPush()
    {
        a.clip = ac;
        b.clip = bc;
        c.clip = cc;
    }
}
