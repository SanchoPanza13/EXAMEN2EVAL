using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitchTime : MonoBehaviour
{

    public AudioClip witchTime;
    public AudioSource AudioCosa;
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            StartCoroutine(Slowmo());
            AudioCosa=AudioManager.instance.PlayAudio(witchTime, "witchTimeAudio");
            //AudioManager.instance.WaitAudioEnd(AudioCosa);
        }
    }

    IEnumerator Slowmo()
    {
        Time.timeScale = 0.25f;
        yield return new WaitForSeconds(1.4f);
        Time.timeScale = 1.0f;
    }





}
