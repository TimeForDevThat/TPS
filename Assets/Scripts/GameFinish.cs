using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFinish : MonoBehaviour
{
    public GameObject GameFinishUI;
    public GameObject PlayerObj;
    private Component _controller;
    void Start()
    {
    }

    void Update()
    {
        
    }
    public void GameFinishedUI()
    {
        GameFinishUI.SetActive(true);
        PlayerObj.GetComponent<GameOverReload>().WhenButtonPressed();
        PlayerObj.GetComponent<PlayerController>().enabled = false;
    }
}
