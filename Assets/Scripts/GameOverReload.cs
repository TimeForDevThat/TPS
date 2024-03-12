using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverReload : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        WhenButtonPressed();  
    }
    void WhenButtonPressed()
    {
        if(Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
