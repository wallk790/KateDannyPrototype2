using UnityEngine;
using System.Collections;

public class Hover : MonoBehaviour {

	public SpriteRenderer blueText;
	public SpriteRenderer redText;

	public SpriteRenderer image;
	public SpriteRenderer grey;

	void Start () {
	
	}

	void Update () {
	
	}

	void OnTriggerStay2D (Collider2D other){

		image.enabled = true;

		if(other.CompareTag("RED")){
			redText.enabled = true;
		}

		if(other.CompareTag("BLUE")){
			blueText.enabled = true;
		}

	}

	void OnTriggerExit2D (Collider2D other){

		grey.enabled = true;
		image.enabled = false;

		if(other.CompareTag("RED")){
			redText.enabled = false;
		}
		
		if(other.CompareTag("BLUE")){
			blueText.enabled = false;
		}
		
	}

}
