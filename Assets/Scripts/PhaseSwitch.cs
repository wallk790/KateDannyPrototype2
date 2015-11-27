using UnityEngine;
using System.Collections;

public class PhaseSwitch : MonoBehaviour {


	public SpriteRenderer vote;
	public SpriteRenderer voteBox;
	public SpriteRenderer voteText;
	public SpriteRenderer blame;
	public SpriteRenderer blameText;
	
	void Update () {

		if(BlameCounter.blameTime == 0){
			vote.enabled = true;
			voteBox.enabled = true;
			voteText.enabled = true;
			blame.enabled = false;
			blameText.enabled = false;
		}

		if(BlameCounter.blameTime == BlameCounter.timerStart - 1){
			voteBox.enabled = false;
			voteText.enabled = false;
			vote.enabled = false;
			blameText.enabled = true;
			blame.enabled = true;
		}
	}

}
