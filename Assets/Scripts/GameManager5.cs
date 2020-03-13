using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager5 : MonoBehaviour
{

    public GameObject Sphere5;
    // Use this for initialization
    void Start()
    {
        Sphere5.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.J))
        {

            Sphere5.SetActive(true);

        }

        if (Input.GetKeyUp(KeyCode.J))
        {

            Sphere5.SetActive(false);

        }

    }
}