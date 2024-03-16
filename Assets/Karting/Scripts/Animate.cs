using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour
{
    private Animation anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
        //anim.Play("bowling animation");
    }

    // Update is called once per frame
    void Update()
    {
       // anim.Play("bowling animation");
    }
}
