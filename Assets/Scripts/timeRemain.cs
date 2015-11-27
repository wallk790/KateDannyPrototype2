using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timeRemain : MonoBehaviour {

	int timeRemaining = 30;

	public GameObject words;
	Text time;



	// Use this for initialization
	void Start () {
		Invoke("Countdown", 2);
		time = words.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		time.text = " " + timeRemaining;

		if(timeRemaining == 0){
			timeRemaining = 30;
			Application.LoadLevel("Vote");
		}

	}

	void Minus (){
		timeRemaining --;
	}
	void Countdown(){
		InvokeRepeating ("Minus", 0f, 1f);
	}
}
