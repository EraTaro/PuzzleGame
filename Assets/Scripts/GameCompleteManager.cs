using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCompleteManager : MonoBehaviour {

    private GameObject puzzuleObject;
    private ST_PuzzleDisplay puzzleDisplay;

    // Use this for initialization
    void Start () {

        puzzuleObject = GameObject.Find("SlidingTile_3by3");
        puzzleDisplay =  puzzuleObject.GetComponent<ST_PuzzleDisplay>();
	}
	
	// Update is called once per frame
	void Update () {
        if (puzzleDisplay.Complete) {
            Debug.Log("clear!!");
            this.enabled = true;
        }
	}
}
