using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerHexagon_S : MonoBehaviour
{
    static public float timeSpawn = 2.5f;

    public GameObject Hexagono1;

    public GameObject Hexagono2;

    public GameObject Hexagono3;

    public GameObject Hexagono4;

    public GameObject Hexagono5;

    public GameObject Hexagono6;

    public GameObject Hexagono7;

    void Start()
    {
        InvokeRepeating("CrearHexagono", 0, timeSpawn);
    }
    void CrearHexagono()
    {

        int lado = Random.Range(0, 8);
        if (lado == 0)
        {
            Instantiate(Hexagono1);
        }
        if (lado == 1)
        {
            Instantiate(Hexagono2);
        }
        if(lado == 2)
        {
            Instantiate(Hexagono3);
        }
        if (lado == 3)
        {
            Instantiate(Hexagono4);
        }
        if (lado == 4)
        {
            Instantiate(Hexagono5);
        }
        if (lado == 5)
        {
            Instantiate(Hexagono6);
        }
        if (lado == 6)
        {
            Instantiate(Hexagono7);
        }

    }
}
