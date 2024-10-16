using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustParticleControl : MonoBehaviour
{
    [SerializeField] private bool createDustOnWalk = true;
    [SerializeField] private ParticleSystem dustParticleSystem;

    public void CreateDustParticles()
    {
        if(createDustOnWalk)
        {
            Debug.Log("함수작동?");
            dustParticleSystem.Stop();
            dustParticleSystem.Play();
        }
    }
}
