using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoA_S : MonoBehaviour
{
    float spd = 5f;
    void Update()
    {
        transform.Translate(Vector3.down * spd * Time.deltaTime);
    }
    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
