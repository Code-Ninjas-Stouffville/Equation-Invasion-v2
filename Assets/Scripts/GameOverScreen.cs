using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Equation Invasion Level 1");
    }

    public void RestartButton2()
    {
        SceneManager.LoadScene("Equation Invasion Level 2");
    }

    public void RestartButton3()
    {
        SceneManager.LoadScene("Equation Invasion Level 3");
    }

    public void RestartButton4()
    {
        SceneManager.LoadScene("Boss Fight");
    }

        public void MenuButton()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void MenuButton2()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void MenuButton3()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void MenuButton4()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
