using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon_S : MonoBehaviour
{
    static float spd_hexagono = 0.008f;

    float x;
    float y;
    float z;

    public SpriteRenderer SpriteRenderer;

    private void Update()
    {

        float rotacion = Random.Range(750, 2500);

        x += 0.01f * spd_hexagono * Time.deltaTime;
        y += 0.01f * spd_hexagono * Time.deltaTime;
        z += 0.01f * spd_hexagono * Time.deltaTime;

        transform.localScale -= new Vector3(x, y, z);

        transform.Rotate(new Vector3(0f, 0f, rotacion) * spd_hexagono * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.A))
        {
            CambiarColor();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            CambiarColor();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        Destroy(this.gameObject);

        Puntaje_S.puntaje += 1;

        spd_hexagono += 0.002f;
    }

    private void CambiarColor()
    {
        SpriteRenderer.material.color = Random.ColorHSV();

    }
}
