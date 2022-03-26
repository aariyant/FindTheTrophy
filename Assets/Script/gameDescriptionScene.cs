using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameDescriptionScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void startGame() {
        SceneManager.LoadScene("GamePreparation");
    }

    public void mainMenuScene() {
        SceneManager.LoadScene("MainMenu");
    }
}