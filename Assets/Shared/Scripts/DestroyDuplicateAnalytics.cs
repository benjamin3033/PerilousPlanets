using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameAnalyticsSDK;

public class DestroyDuplicateAnalytics : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        if(GameObject.FindObjectsOfType<GameAnalytics>().Length > 1)
        {
            Destroy(gameObject);
        }
    }
}