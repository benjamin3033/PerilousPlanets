using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
    public string LevelNumber;


    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(LevelNumber);
    }
}
