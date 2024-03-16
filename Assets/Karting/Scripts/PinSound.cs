using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinSound : MonoBehaviour
{
    [SerializeField] private AudioSource crashSound;

    private void Awake()
    {
        //crashSound.enabled = false;
        //crashSound.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("audio play??");
            //crashSound.enabled = true;
            //crashSound.volume = 1;
            //crashSound.mute = false;
            crashSound.Play();
        }
       
    }
}
