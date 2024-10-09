using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Pin : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidbody;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (IsPinFallen())
        {
            Debug.Log("Fell");
        }
    }

    bool IsPinFallen()
    {
        return false;
        
    }

    void ResetPinToOrigin()
    {

    }
}
