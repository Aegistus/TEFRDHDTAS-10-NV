using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuclearBomb : MonoBehaviour
{
    [SerializeField] float delay = 0f;

    [SerializeField] ParticleSystem particles;
    [SerializeField] AudioSource audioSource;
    [SerializeField] GameObject[] deactivateAfterExplosion;

    public void Explode()
    {
        StartCoroutine(ExplodeCoroutine());
    }

    IEnumerator ExplodeCoroutine()
    {
        yield return new WaitForSeconds(delay);
        particles.Play();
        audioSource.Play();
        for (int i = 0; i < deactivateAfterExplosion.Length; i++)
        {
            deactivateAfterExplosion[i].SetActive(false);
        }
    }
}
