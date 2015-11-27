using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MoveCursor : MonoBehaviour {



	public float speed;
	
	void Update () {

		if(gameObject.tag == "A"){
		Vector3 move = new Vector3(Input.GetAxis("Horizontal1"), Input.GetAxis("Vertical1"), 0);
		transform.position += move * speed * Time.deltaTime;
		}

		if(gameObject.tag == "B"){
			Vector3 move = new Vector3(Input.GetAxis("Horizontal2"), Input.GetAxis("Vertical2"), 0);
			transform.position += move * speed * Time.deltaTime;
		}
		if(gameObject.tag == "C"){
			Vector3 move = new Vector3(Input.GetAxis("Horizontal3"), Input.GetAxis("Vertical3"), 0);
			transform.position += move * speed * Time.deltaTime;
		}
		if(gameObject.tag == "D"){
			Vector3 move = new Vector3(Input.GetAxis("Horizontal4"), Input.GetAxis("Vertical4"), 0);
			transform.position += move * speed * Time.deltaTime;
		}



	}
}
