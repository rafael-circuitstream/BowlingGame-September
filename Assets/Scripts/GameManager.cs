using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartThrow();
    }

    public void StartThrow()
    {
        Instantiate(ballPrefab, transform.position, transform.rotation);
    }
}
