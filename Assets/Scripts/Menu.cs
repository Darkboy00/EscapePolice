using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void GameStart()
    {
        SceneManager.LoadScene(1);
    }
    public void GameExit()
    {
        Application.Quit();
    }
}