using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoringSystem : MonoBehaviour {

    public Text textWood;
    public Text textStone;

    public static int theWoodScore;
    public static int theStoneScore;

	// Use this for initialization
	void Start () {
        theWoodScore = 0;
        theStoneScore = 0;
	}
	
	// Update is called once per frame
	void Update () {

        if (theWoodScore > 50)
            theWoodScore = 50;
        if (theStoneScore > 50)
            theStoneScore = 50;

        textWood.text = "Wood: "+theWoodScore+"/50";
        textStone.text = "Stone: " + theStoneScore + "/50";
    }
}
