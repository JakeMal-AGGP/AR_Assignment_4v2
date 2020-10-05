using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinBlock : MonoBehaviour
{

    private GameController cntrl;
    public GameObject cam;

    void Start()
    {

        cntrl = cam.GetComponent<GameController>();

    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.name == "ball")
        {

            Destroy(other.gameObject);

            cntrl.win();

        }
    }
}
