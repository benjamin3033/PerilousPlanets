using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTrigger : MonoBehaviour
{
    GameObject GameManager = null;
    PortalManager PortalManagerScript = null;

    private void Start()
    {
        GameManager = GameObject.Find("GameManager");
        PortalManagerScript = GameManager.GetComponent<PortalManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            PortalManagerScript.SendPlayer();
        }
    }
}
