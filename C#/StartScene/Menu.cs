using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Playeasy");
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("游戏已退出");
    }
}
