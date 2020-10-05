using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touchy : MonoBehaviour
{

    private Vector3 initialTouch;
    private Vector3 finalTouch;

    public GameObject point;

    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log("using android");

        if (Input.touchCount == 1) // Single finger touch
        {

            Touch touch = Input.GetTouch(0); // get touch

            if(touch.phase == TouchPhase.Began) // first touch
            {

                initialTouch = touch.position;
                finalTouch = touch.position;

            }
            else if(touch.phase == TouchPhase.Moved) // moved touch
            {

                finalTouch = touch.position;
                placePoint(finalTouch);

            }
            else if(touch.phase == TouchPhase.Ended) // end touch
            {

                finalTouch = touch.position;

            }

        }

        if(Input.GetMouseButtonDown(0))
        {

            placePoint(Input.mousePosition);

        }

    }

    private void placePoint(Vector3 pos)
    {

        RaycastHit hit;

        Ray ray = Camera.main.ScreenPointToRay(pos);

        if(Physics.Raycast(ray, out hit))
        {

            Instantiate(point, new Vector3(hit.point.x, hit.point.y, 10.5f), Quaternion.identity);

        }

    }

}
