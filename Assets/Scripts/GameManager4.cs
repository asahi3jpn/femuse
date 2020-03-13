using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager4 : MonoBehaviour
{

    public GameObject Sphere4;
    // Use this for initialization
    void Start()
    {
        Sphere4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {

            Sphere4.SetActive(true);

        }

        if (Input.GetKeyUp(KeyCode.Space))
        {

            Sphere4.SetActive(false);

        }

    }
}