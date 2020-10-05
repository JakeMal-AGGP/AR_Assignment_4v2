using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deathBlock : MonoBehaviour
{

    public CameraScript cam;
    public GameObject player;
    public GameObject finishBlock;
    public Vector3 spawnPos;
    public Vector3 cheatPos;
    public Button winBtn;

    // Start is called before the first frame update
    void Start()
    {
        spawnPos = player.transform.position;
        cheatPos = finishBlock.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cheat()
    {

        player.transform.position = cheatPos;

    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.transform.name == "Player")
        {

            //Destroy(other.gameObject);
            Reset();
            //cam.isMoving = false;
            //cam.lose();
            Debug.Log("Game over");

        }

    }

    public void Reset()
    {
        player.transform.position = spawnPos;
        player.GetComponent<Rigidbody>().velocity = Vector3.zero;
        player.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        if(winBtn.IsActive())
        {
            winBtn.gameObject.SetActive(false);
        }
    }

}
