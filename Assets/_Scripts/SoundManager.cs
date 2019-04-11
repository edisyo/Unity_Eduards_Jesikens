using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static AudioClip clickSound, doorOpen, lockedDoors;
    static AudioSource audioSrc;

	void Start () {

        clickSound = Resources.Load<AudioClip>("clickSound");
        doorOpen = Resources.Load<AudioClip>("doorOpen");
        lockedDoors = Resources.Load<AudioClip>("lockedDoors");

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
            case "lockedDoors":
                audioSrc.PlayOneShot(lockedDoors);
                break;
        }

    }
}
