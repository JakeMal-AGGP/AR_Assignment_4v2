using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winBlock : MonoBehaviour
{

    //public CameraScript cam;
    public Button winBtn;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.transform.name == "Player")
        {

            Debug.Log("You win!");

            if(!winBtn.IsActive())
            {
                winBtn.gameObject.SetActive(true);
            }

            //cam.isMoving = false;
            //cam.win();

        }

    }
}
