using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject Sphere;
    // Use this for initialization
    void Start()
    {
        Sphere.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {

            Sphere.SetActive(true);

        }

        if (Input.GetKeyUp(KeyCode.A))
        {

            Sphere.SetActive(false);

        }

    }
}