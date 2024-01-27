using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CarMove : MonoBehaviour
{
    public float speed = 1.0f;
    void Update()
    {
        Vector3 playerInput = new Vector3(0.0f , 0.0f, Input.GetAxis("Vertical"));
        Vector3 hizEklentisi = playerInput*Time.deltaTime*speed;
        transform.position += hizEklentisi;
        

    }
}
