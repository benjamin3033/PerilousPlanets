using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    GameObject SettingsPrefab = null;

    
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Settings()
    {
        Instantiate(SettingsPrefab);
    }
    
    public void Quit()
    {
        Application.Quit();
    }
}
