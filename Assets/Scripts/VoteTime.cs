﻿using UnityEngine;
using System.Collections;

public class VoteTime : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Invoke("Next", 5f);
	
	}


    void Next() {
        Application.LoadLevel(Application.loadedLevel + 1) ; }

}
