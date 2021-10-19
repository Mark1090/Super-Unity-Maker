using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass_Check : MonoBehaviour
{
    public bool Up;
    public bool Down;
    public bool Left;
    public bool Right;

    public bool Touching_Up;
    public bool Touching_Down;
    public bool Touching_Left;
    public bool Touching_Right;

    void Start()
    {

    }

    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        /*if (Up)
        {*/
             if (coll.gameObject.tag == "Grass")
        {

        
             
            Touching_Up = true;
            Debug.Log("1");
    }/*
            else
            {
                Touching_Up = false;
            }*/

    /*if (Down)
    {
        if (coll.gameObject.tag == "Grass")
        {
            Touching_Down = true;
        }
        else
        {
            Touching_Down = false;
        }

    }

    if (Left)
    {
        if (coll.gameObject.tag == "Grass")
        {
            Touching_Left = true;
        }
        else
        {
            Touching_Left = false;
        }
    }

    if (Right)
    {
        if (coll.gameObject.tag == "Grass")
        {
            Touching_Right = true;
        }
        else
        {
            Touching_Right = false;
        }
    }*/

    }
}

