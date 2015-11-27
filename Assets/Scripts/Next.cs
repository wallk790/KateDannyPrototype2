using UnityEngine;
using System.Collections;

public class Next : MonoBehaviour {

	int instructionsCount = 1;
	public SpriteRenderer A;
	public SpriteRenderer B;
	public SpriteRenderer C;
	public SpriteRenderer D;
	public SpriteRenderer E;

	

	// Update is called once per frame
	void Update () {
		if(instructionsCount == 1){
			A.enabled = true;
		}
		if(instructionsCount == 2){
			A.enabled = false;
			B.enabled = true;
		}
		if(instructionsCount == 3){
			B.enabled = false;
			C.enabled = true;
		}
		if(instructionsCount == 4){
			C.enabled = false;
			D.enabled = true;
		}
		if(instructionsCount == 5){
			D.enabled = false;
			E.enabled = true;
		}

		if(instructionsCount == 6){
			Application.LoadLevel("test score");
		}



	
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "A" || 
		    other.gameObject.tag == "B" || 
		    other.gameObject.tag == "C" || 
		    other.gameObject.tag == "D"){
			instructionsCount ++;
		} 
	}
}
