using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    GameObject GameManager = null;
    PodiumManager PodiumManagerScript = null;

    private void Start()
    {
        GameManager = GameObject.Find("GameManager");
        PodiumManagerScript = GameManager.GetComponent<PodiumManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            PodiumManagerScript.TakeStones();
        }
    }
}
