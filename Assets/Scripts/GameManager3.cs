using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager3 : MonoBehaviour
{

    public GameObject Sphere3;
    // Use this for initialization
    void Start()
    {
        Sphere3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {

            Sphere3.SetActive(true);

        }

        if (Input.GetKeyUp(KeyCode.D))
        {

            Sphere3.SetActive(false);

        }

    }
}