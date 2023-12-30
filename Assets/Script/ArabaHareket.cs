using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArabaHareket : MonoBehaviour
{
    public float speed = 4.0f;
    void Update()
    {
        Vector3 playerInput = new Vector3(Input.GetAxis("Vertical"), 0.0f, Input.GetAxis("Horizontal"));
        Vector3 hizEklentisi = playerInput * Time.deltaTime * speed;
        transform.position += hizEklentisi;
    }
}
