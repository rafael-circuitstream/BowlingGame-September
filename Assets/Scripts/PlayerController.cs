using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool wasThrown;
    [SerializeField] private float throwStrength;
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private GameObject aimingArrow;


    // Update is called once per frame
    private void Update()
    {
        MoveBall();
        ThrowingBall();
        
    }

    private void MoveBall()
    {
        if(!wasThrown)
        {
            transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, 0, 0);
        }
        
    }

    void ThrowingBall()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !wasThrown)
        {

            aimingArrow.SetActive(false);

            wasThrown = true;
            myRigidbody.AddForce(aimingArrow.transform.forward * throwStrength, ForceMode.Impulse); //This means 0 on X, 0 on Y, 1 on Z
            Invoke("StopThrow", 10f);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        StopThrow();
    }

    void StopThrow()
    {
        FindObjectOfType<GameManager>().BallOnPit();
        Destroy(gameObject, 3f);
    }
}
