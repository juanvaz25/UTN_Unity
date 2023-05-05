using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fondo_S : MonoBehaviour
{

    public GameObject fondo;
    public GameObject fondoPoint;

    float TimeSpawnFondo = 4f;

    void Start()
    {
        InvokeRepeating("crearFondo", 0.1f , TimeSpawnFondo);
    }

    void crearFondo()
    {
        Instantiate(fondo, fondoPoint.transform.position, Quaternion.identity);
    }
}
