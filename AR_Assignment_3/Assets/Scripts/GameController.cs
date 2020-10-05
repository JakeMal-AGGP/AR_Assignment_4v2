using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public Button btn_restart;
    public Button btn_winRestart;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void lose()
    {

        Debug.Log("You lose :(");

        btn_restart.gameObject.SetActive(true);

    }

    public void win()
    {

        Debug.Log("You win :D");

        btn_winRestart.gameObject.SetActive(true);

    }

    public void Reset()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
