using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPickup : MonoBehaviour {

    public Transform player;
    public Transform playerCam;
    public float throwForce = 10;
    bool hasPlayer = false;
    bool beingCarried = false;
    public int dmg;
    private bool touched = false;

    // Use this for initialization
    void Start () {
		//get audio here later
	}
	
	// Update is called once per frame
	void Update () {
        float dist = Vector3.Distance(gameObject.transform.position, player.position);
        if(dist <= 5f)
        {
            hasPlayer = true;
        }
        else
        {
            hasPlayer = false;
        }
        
        if(hasPlayer && Input.GetButtonDown("Use"))
        {
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = playerCam;
            beingCarried = true;
        }

        if (beingCarried)
        {
            if (touched)
            {
                //if object collides with wall or something
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                touched = false;
            }
            if (Input.GetMouseButtonDown(0))//throws the object
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                GetComponent<Rigidbody>().AddForce(playerCam.forward * throwForce);
                //play audio here
            }
            else if (Input.GetMouseButtonDown(1))//puts down the object
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
            }

        }
	}

    private void OnTriggerEnter()
    {
        if (beingCarried)
        {
            touched = true;
        }
    }
}
