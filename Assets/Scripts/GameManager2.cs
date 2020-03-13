using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{

    public GameObject Sphere2;
    // Use this for initialization
    void Start()
    {
        Sphere2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {

            Sphere2.SetActive(true);

        }

        if (Input.GetKeyUp(KeyCode.W))
        {

            Sphere2.SetActive(false);

        }

    }
}