using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Puntaje_S : MonoBehaviour
{
    public static int puntaje;

    public TMP_Text referenciaPuntaje;

    void Update()
    {
        referenciaPuntaje.text = puntaje.ToString();

        if(puntaje < 0)
        {
            puntaje = 0;
        }
    }

}
