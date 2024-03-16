using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointParticles : MonoBehaviour
{
    public ParticleSystem explosion;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            explosion.Play();
        }
        
    }
}
