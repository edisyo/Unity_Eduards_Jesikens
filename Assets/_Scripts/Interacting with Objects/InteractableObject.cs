using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InteractableObject : MonoBehaviour {

    public float theDistance;
    public GameObject theCursor;
    public GameObject theText;
    public string objectsName;
    bool isActive = false;

    private void Start()
    {
        theText.SetActive(false);
        theCursor.GetComponent<Animator>().Play("idle_cursor");
    }

    // Update is called once per frame
    void Update () {
        theDistance = PlayerCasting.DistanceFromTarget;
        if (isActive && Input.GetButtonDown("Use"))
        {
            
            if(gameObject.tag == "key1")
            {
                Debug.Log("collected wood");
                //scoringSystem.theWoodScore += 10;
                theCursor.GetComponent<Animator>().Play("close_cursor");
                theText.SetActive(false);
                isActive = false;
                gameObject.SetActive(false);
                SoundManager.PlaySound("click");
            }

        }
	}

    private void OnMouseOver()
    {
        if(theDistance <= 5)
        {
            theCursor.GetComponent<Animator>().Play("open_cursor");
            theText.GetComponent<TextMeshProUGUI>().text = objectsName;
            theText.SetActive(true);
            isActive = true;
        }
    }

    private void OnMouseExit()
    {
        theCursor.GetComponent<Animator>().Play("close_cursor");
        theText.SetActive(false);
        isActive = false;
    }
}
