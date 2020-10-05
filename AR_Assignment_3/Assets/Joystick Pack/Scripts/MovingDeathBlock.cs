using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingDeathBlock : MonoBehaviour
{


    public Transform trans;
    public Vector3 startPos;
    public Vector3 endPos;
    public int stage;
    public float movespeed;

    void Start()
    {
        trans = gameObject.transform;
        startPos = trans.position;
        endPos = trans.GetChild(0).transform.position;
        stage = 0;
        movespeed = 1f;

        Debug.Log(startPos);
        Debug.Log(endPos);
    }

    
    void Update()
    {
        if (stage == 0)
        {

            

        }

        trans.position += Vector3.right * movespeed * Time.deltaTime;
    }
}
