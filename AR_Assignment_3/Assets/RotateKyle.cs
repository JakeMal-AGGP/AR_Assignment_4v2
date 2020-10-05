using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is used to both scale and rotate kyle, idk why i just called it "RotateKyle" lmao

public class RotateKyle : MonoBehaviour
{

    private float prevVal;


    private void Awake()
    {
        prevVal = 0f;
    }

    public void rotate(float value)
    {

        float delta = value - prevVal;

        gameObject.transform.Rotate(Vector3.up * delta * 360);

        prevVal = value;

    }

    public void scale(float value)
    {
        gameObject.transform.localScale = new Vector3(value, value, value);
    }
}
