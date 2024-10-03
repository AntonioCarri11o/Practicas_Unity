using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void play_game()
    {
        SceneManager.LoadScene("RedBallScene");
    }
    public void quit_game()
    {
        Application.Quit();
    }
}
