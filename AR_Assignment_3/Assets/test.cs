using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    public Button btn;


    public void touched()
    {
        btn.gameObject.SetActive(false);
    }
}
