using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowTellers : MonoBehaviour {


	public SpriteRenderer blame;
	public SpriteRenderer votes;
	public SpriteRenderer truths;

	public SpriteRenderer box1;
	public SpriteRenderer box2;
	public Text red;
	public Text blue;
	public Text black;

	void Update(){

		if (BlameCounter.blameTime == KeepScore.voteSwitch + 1){
			votes.enabled = true;
			box1.enabled = false;
			box2.enabled = false;
			red.enabled = false;
			blue.enabled = false;
			black.enabled = false;
		}
		if (BlameCounter.blameTime == KeepScore.blameSwitch + 1){
			votes.enabled = false;
			blame.enabled = true;
		}
		if (BlameCounter.blameTime == KeepScore.truthSwitch + 1){
			blame.enabled = false;
			truths.enabled = true;
		}
		if (BlameCounter.blameTime == BlameCounter.timerLength + 1){
			truths.enabled = false;
		}

		if (BlameCounter.blameTime == BlameCounter.timerLength){
			truths.enabled = false;
			box1.enabled = true;
			box2.enabled = true;
			red.enabled = true;
			blue.enabled = true;
			black.enabled = true;
			
		}

	}

}