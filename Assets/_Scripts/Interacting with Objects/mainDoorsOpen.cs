using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainDoorsOpen : MonoBehaviour {

    public Animator anim;
    private float theDistance;
    public bool isActive;
    public bool isOpened;
    public GameObject keys;

    private void Start()
    {
        isOpened = false;
        keys.SetActive(true);
    }

    void Update()
    {
        theDistance = PlayerCasting.DistanceFromTarget;
    }

    private void OnMouseOver()
    {
        if (theDistance <= 5)
        {
            if (Input.GetButtonDown("Use") && keys.activeInHierarchy == false)
            {
                anim.SetBool("openDoors", true);
                SoundManager.PlaySound("doorOpen");

            } else
            {
                if (Input.GetButtonDown("Use")){
                    SoundManager.PlaySound("lockedDoors");
                }
            }
        }
    }

    private void OnMouseExit()
    {
        if (theDistance <= 5)
        {
            if (Input.GetButtonDown("Use"))
            {
                anim.SetBool("openDoors", false);
                SoundManager.PlaySound("doorOpen");
            }
        }  
    }

}
