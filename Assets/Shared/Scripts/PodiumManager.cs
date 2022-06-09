using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PodiumManager : MonoBehaviour
{
    public List<GameObject> PodiumStones = new List<GameObject>();
    int StonesCollected = 0;

    StoneKeyManager StoneKeyManagerScript = null;
    PortalManager PortalManagerScript = null;
    InventoryImages InventoryImagesScript = null;
    GameObject GameManager = null;

    private void Start()
    {
        GameManager = GameObject.Find("GameManager");
        StoneKeyManagerScript = GameManager.GetComponent<StoneKeyManager>();
        PortalManagerScript = GameManager.GetComponent<PortalManager>();
        InventoryImagesScript = GameManager.GetComponent<InventoryImages>();
    }

    public void TakeStones()
    {
        if(StoneKeyManagerScript.StoneKeyHolder.Count >= 1)
        {
            StonesCollected += StoneKeyManagerScript.StoneKeyHolder.Count;
            CheckStonesInPodium();
            PlaceStonesInPodium();
            InventoryImagesScript.RemoveImages();
            StoneKeyManagerScript.StoneKeyHolder.RemoveRange(0, StoneKeyManagerScript.StoneKeyHolder.Count);
        }
    }

    void PlaceStonesInPodium()
    {
        for(int i = 0; i < StonesCollected; i++)
        {
            PodiumStones[i].SetActive(true);
        }    
    }

    void CheckStonesInPodium()
    {
        if(StonesCollected == PodiumStones.Count)
        {
            PortalManagerScript.ActivatePortal();
        }
    }

}
