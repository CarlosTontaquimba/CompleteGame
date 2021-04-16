using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataController1 : MonoBehaviour {

    public RoundData1[] allRoundData;

	// Use this for initialization
	void Start ()
    {
		
	}

    public RoundData1 GetCurrentRoundData()
    {
        return allRoundData[0];
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
