using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CameraScript : MonoBehaviour
{

    public Transform trans;
    public float moveSpeed;
    public int step;
    public bool isMoving;

    public Button btn_restart;
    public Button btn_winRestart;

    // Start is called before the first frame update
    void Start()
    {
        trans = gameObject.transform;
        moveSpeed = 1.0f;
        isMoving = true;
    }

    // Update is called once per frame
    void Update()
    {
        step += 1;

        if(step == 360)
        {

            step = 0;
            moveSpeed += .1f;

        }


        if(isMoving)
        {

            trans.position += Vector3.forward * moveSpeed * Time.deltaTime;

        }

        
    }

    public void win()
    {

        btn_winRestart.gameObject.SetActive(true);

    }

    public void lose()
    {

        btn_restart.gameObject.SetActive(true);

    }

    public void Reset()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}
