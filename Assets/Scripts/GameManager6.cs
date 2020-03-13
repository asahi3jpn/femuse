using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager6 : MonoBehaviour
{

    public GameObject Sphere6;
    // Use this for initialization
    void Start()
    {
        Sphere6.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.I))
        {

            Sphere6.SetActive(true);

        }

        if (Input.GetKeyUp(KeyCode.I))
        {

            Sphere6.SetActive(false);

        }

    }
}