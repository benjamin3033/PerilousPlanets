using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneKey : MonoBehaviour
{
    public GameObject GameManager = null;

    StoneKeyManager StoneKeyManagerScript = null;
    InventoryImages InventoryImagesScript = null;

    private void Start()
    {
        StoneKeyManagerScript = GameManager.GetComponent<StoneKeyManager>();
        InventoryImagesScript = GameManager.GetComponent<InventoryImages>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StoneKeyManagerScript.StoneKeyHolder.Add(gameObject);
            InventoryImagesScript.AddImage();
            gameObject.GetComponent<SphereCollider>().enabled = false;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
