using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    [SerializeField]
    Timer timer;
    public void OnRetry()
    {
        timer.Reset();
        SceneManager.LoadScene("GameScene");
    }
    public void OnQuit()
    {
        Application.Quit();
    }
}
