using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class IntroScene : MonoBehaviour
{

    public GameObject CutSceneCamera;
    public PlayableDirector Cutscene;
    // Start is called before the first frame update
    void Start()
    {
        CutSceneCamera.SetActive(true);
        Cutscene = GetComponent<PlayableDirector>();
        Cutscene.Play();
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(6);
        CutSceneCamera.SetActive(false);

    }
}
