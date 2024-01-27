using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    [SerializeField] WheelCollider frontRightWheel;
    [SerializeField] WheelCollider frontLeftWheel;
    [SerializeField] WheelCollider backRightWheel;
    [SerializeField] WheelCollider backLeftWheel;

    public float hizlanma = 500f;
    public float fren = 300f;
    public float maxturn = 15f;

    private float currentHiz = 0f;
    private float currentFren = 0f;
    private float currentTurnAngle =0f;

    private void FixedUpdate()
    {
        currentHiz = hizlanma * Input.GetAxis("Vertical");


        if (Input.GetKey(KeyCode.Space))
        {
            currentFren = fren;
        }else
        {
            currentFren = 0f;
        }

        frontLeftWheel.motorTorque = currentHiz;
        frontRightWheel.motorTorque = currentHiz;

        frontLeftWheel.brakeTorque = currentFren;
        frontRightWheel.brakeTorque = currentFren;
        backLeftWheel.brakeTorque = currentFren;
        backRightWheel.brakeTorque = currentFren;

        currentTurnAngle = maxturn * Input.GetAxis("Horizontal");
        frontLeftWheel.steerAngle = currentTurnAngle;
        frontRightWheel.steerAngle = currentTurnAngle;

    }
}
