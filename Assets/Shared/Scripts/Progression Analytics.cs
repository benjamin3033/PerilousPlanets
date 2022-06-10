using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameAnalyticsSDK;
using UnityEngine.SceneManagement;

public class ProgressionAnalytics
{
    public static void SendProgression(GAProgressionStatus status)
    {
        string LevelName = SceneManager.GetActiveScene().name;
        GameAnalytics.NewProgressionEvent(status, LevelName);
    }

    public static void SendProgression(GAProgressionStatus status, int score)
    {
        string LevelName = SceneManager.GetActiveScene().name;
        GameAnalytics.NewProgressionEvent(status, LevelName, score);
    }
}
