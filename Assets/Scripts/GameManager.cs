using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject KeyA;
    public GameObject KeyW;
    public GameObject KeyD;
    public GameObject KeySpace;
    public GameObject KeyJ;
    public GameObject KeyI;
    public GameObject KeyL;
    // Use this for initialization
    void Start()
    {
        KeyA.SetActive(false);
        KeyW.SetActive(false);
        KeyD.SetActive(false);
        KeySpace.SetActive(false);
        KeyJ.SetActive(false);
        KeyI.SetActive(false);
        KeyL.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {

            KeyA.SetActive(true);

        }

        if (Input.GetKeyUp(KeyCode.A))
        {

            KeyA.SetActive(false);

        }

        if (Input.GetKey(KeyCode.W))
        {

            KeyW.SetActive(true);

        }

        if (Input.GetKeyUp(KeyCode.W))
        {

            KeyW.SetActive(false);

        }

        if (Input.GetKey(KeyCode.D))
        {

            KeyD.SetActive(true);

        }

        if (Input.GetKeyUp(KeyCode.D))
        {

            KeyD.SetActive(false);

        }

        if (Input.GetKey(KeyCode.Space))
        {

            KeySpace.SetActive(true);

        }

        if (Input.GetKeyUp(KeyCode.Space))
        {

            KeySpace.SetActive(false);

        }

        if (Input.GetKey(KeyCode.J))
        {

            KeyJ.SetActive(true);

        }

        if (Input.GetKeyUp(KeyCode.J))
        {

            KeyJ.SetActive(false);

        }

        if (Input.GetKey(KeyCode.I))
        {

            KeyI.SetActive(true);

        }

        if (Input.GetKeyUp(KeyCode.I))
        {

            KeyI.SetActive(false);

        }

        if (Input.GetKey(KeyCode.L))
        {

            KeyL.SetActive(true);

        }

        if (Input.GetKeyUp(KeyCode.L))
        {

            KeyL.SetActive(false);

        }
    }
}