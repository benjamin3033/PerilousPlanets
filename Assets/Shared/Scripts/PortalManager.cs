using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalManager : MonoBehaviour
{
    public GameObject PortalTrigger = null;
    public int LevelIndex = 0;


    public void ActivatePortal()
    {
        PortalTrigger.SetActive(true);
    }

    public void SendPlayer()
    {
        SceneManager.LoadScene(LevelIndex);
    }
}
