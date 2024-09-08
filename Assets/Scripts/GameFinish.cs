using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFinish : MonoBehaviour
{
    public GameObject GameFinishUI;
    public GameObject PlayerObj;
    public GameObject PlayerModel;
    private Component _controller;
    public GameObject GameplayCanvas;
    void Start()
    {
    }

    void Update()
    {
        
    }
    public void GameFinishedUI()
    {
        PlayerObj.GetComponent<PlayerController>().enabled = false;
        PlayerObj.GetComponent<CamRotation>().enabled = false;
        PlayerModel.GetComponent<Animator>().SetBool("RunForward", false);
        PlayerModel.GetComponent<Animator>().SetBool("RunRight", false);
        PlayerModel.GetComponent<Animator>().SetBool("RunBackward", false);
        PlayerModel.GetComponent<Animator>().SetBool("RunLeft", false);
        GameplayCanvas.SetActive(false);
        GameFinishUI.SetActive(true);
        PlayerObj.GetComponent<GameOverReload>().WhenButtonPressed();
    }
}
