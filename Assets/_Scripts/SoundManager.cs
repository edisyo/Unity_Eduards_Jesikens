using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static AudioClip clickSound, doorOpen;
    static AudioSource audioSrc;

	void Start () {

        clickSound = Resources.Load<AudioClip>("clickSound");
        doorOpen = Resources.Load<AudioClip>("doorOpen");

        audioSrc = GetComponent<AudioSource>();
	}

    public static void PlaySound(string clip)
    {

        switch (clip)
        {
            case "click":
                audioSrc.PlayOneShot(clickSound);
                break;

            case "doorOpen":
                audioSrc.PlayOneShot(doorOpen);
                break;
        }

    }
}
