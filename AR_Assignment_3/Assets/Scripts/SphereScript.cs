using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{

   private int step;

    private void Start()
    {

        step = 0;

    }

    void Update()
    {
        step += 1;

        if(step >= 30)
        {

            Destroy(gameObject);

        }

        
    }

    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log(collision.transform.name);

        if (collision.transform.parent.tag == "wall")
        {

            Debug.Log("wall hit!");

        }

    }

}
