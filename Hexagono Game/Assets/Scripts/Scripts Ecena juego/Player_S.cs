using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_S : MonoBehaviour
{
    public Transform centro;

    public float spd_player;

    public AudioSource sfx;
    public AudioClip sfx_lose;

    public AudioSource MusicInGame;

    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(centro.position, Vector3.forward, spd_player * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.RotateAround(centro.position, -Vector3.forward,spd_player * Time.deltaTime);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        MusicInGame.Stop();

        sfx.clip = sfx_lose;
        sfx.loop = false;
        sfx.Play();

        gameObject.SetActive(false);

        Puntaje_S.puntaje -= 1;

        Invoke("EndGame", 2);
    }

    private void EndGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
