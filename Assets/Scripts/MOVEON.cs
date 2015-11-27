using UnityEngine;
using System.Collections;

public class MOVEON : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
	
		if(BlameCounter.questionNumber == 8){
			Application.LoadLevel("Z");
		}

	}
}
