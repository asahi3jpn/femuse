using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager7 : MonoBehaviour
{

    public GameObject Sphere7;
    // Use this for initialization
    void Start()
    {
        Sphere7.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.L))
        {

            Sphere7.SetActive(true);

        }

        if (Input.GetKeyUp(KeyCode.L))
        {

            Sphere7.SetActive(false);

        }

    }
}