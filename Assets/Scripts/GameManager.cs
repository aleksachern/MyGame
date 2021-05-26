﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class GameManager : MonoBehaviour
{
    public CarController RR;
         
    public GameObject needle;
    private float startPosition = 220f, endPosition = -49f;
    private float desiredPosition;

    public float vehicleSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        vehicleSpeed = RR.CurrentSpeed;
        updateNeedle();
    }

    public void updateNeedle()
    {
        desiredPosition = startPosition - endPosition;
        float temp = vehicleSpeed / 180;
        needle.transform.eulerAngles = new Vector3(0, 0, (startPosition - temp * desiredPosition));

    } 

}
