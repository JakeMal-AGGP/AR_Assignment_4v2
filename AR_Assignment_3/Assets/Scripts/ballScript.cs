using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour
{

    private Transform trans;
    private GameController cntrl;
    public GameObject cam;

    void Start()
    {

        trans = gameObject.transform;
        cntrl = cam.GetComponent<GameController>();

    }

    
    void Update()
    {
        
        if(trans.position.y < 0)
        {

            cntrl.lose();

            Destroy(gameObject);

        }

    }
}
