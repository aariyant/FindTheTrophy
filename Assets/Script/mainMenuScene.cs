using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startScene() {
        SceneManager.LoadScene("GameDescription");
    }

    public void QuitGame() {
        Application.Quit();
    }
}
