using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClick : MonoBehaviour
{
    public void ApplicationQuit()
    {
        Application.Quit();

    }

    public void LoadScene(string scene)
    {
        SceneManager.LoadSceneAsync(scene);
    }

    public void LoadSceneWithAds(string scene)
    {
        if (AdsManager.Instance)
        {
            AdsManager.Instance.ShowAds(scene);
        }
        else
        {
            LoadScene(scene);
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }


}
