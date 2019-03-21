using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainDoorsOpen : MonoBehaviour {

    public Animator anim;
    private float theDistance;
    public bool isActive;
    public bool isOpened;

    private void Start()
    {
        isOpened = false;
    }

    void Update()
    {
        theDistance = PlayerCasting.DistanceFromTarget;
        doorsOpen();
        doorsClose();
    }

    private void doorsOpen()
    {
        if (isActive && Input.GetButtonDown("Use") && isOpened == false)
        {
            isOpened = true;
            anim.SetTrigger("doorsOpenMain");
            SoundManager.PlaySound("doorOpen");
            
            
        }
    }

    private void doorsClose()
    {
        if (isActive && Input.GetButtonDown("Use") && isOpened == true)
        {
            anim.SetTrigger("doorsCloseMain");
            SoundManager.PlaySound("doorOpen");
            isOpened = false;
        }

    }

    private void OnMouseOver()
    {
        if (theDistance <= 5)
        {
            isActive = true;
        }
    }
    private void OnMouseExit()
    {
        isActive = false;
    }

}
