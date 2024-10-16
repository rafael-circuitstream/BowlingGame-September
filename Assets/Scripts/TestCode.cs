using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCode : MonoBehaviour
{
    public Vector3 movingDirection;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateNewPlatform", 5, 5);
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(movingDirection * Time.deltaTime);
    }


    void CreateNewPlatform()
    {
        //CREATE A NEW PLATFORM ON A SPECIFIC POSITION
            //LOOK INTO INSTANTIATE()

        Destroy(gameObject);
        
    }
}
