using UnityEngine;
using System.Collections;

public class ShowBlackText : MonoBehaviour {

	public SpriteRenderer Blacktext;

	void Update (){

		if(BlameCounter.blameTime == 0) {
			Blacktext.enabled = true;
		}

	}

}
