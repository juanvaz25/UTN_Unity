using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Centro_S : MonoBehaviour
{
    public AudioSource sfx_point;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        sfx_point.Play();

    }
}
