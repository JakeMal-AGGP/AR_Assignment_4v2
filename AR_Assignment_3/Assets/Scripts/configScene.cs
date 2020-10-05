using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class configScene : MonoBehaviour
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
