using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitchTime : MonoBehaviour
{

    public AudioClip witchTime;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            StartCoroutine(Slowmo());
            AudioManager.instance.PlayAudio(witchTime, "witchTimeAudio");
        }
    }

    IEnumerator Slowmo()
    {
        Time.timeScale = 0.25f;
        yield return new WaitForSeconds(1.0f);
        Time.timeScale = 1.0f;
    }





}
