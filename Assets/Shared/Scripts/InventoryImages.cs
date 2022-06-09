using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryImages : MonoBehaviour
{
    public GameObject ImagesHolder = null;
    public GameObject StoneKeyImage = null;

    public void AddImage()
    {
        Instantiate(StoneKeyImage, ImagesHolder.transform);
    }
}
