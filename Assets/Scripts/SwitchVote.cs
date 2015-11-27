using UnityEngine;
using System.Collections;

public class SwitchVote : MonoBehaviour {

	public SpriteRenderer VoteRender;
	SpriteRenderer BlameRender;

	void Start(){
		BlameRender = GetComponent<SpriteRenderer>();
	}

	void Update () {
	
		if(BlameCounter.blameTime == 0){

			BlameRender.enabled = false;
			VoteRender.enabled = true;

			if(gameObject.tag == "BLAMEA"){
				gameObject.tag = "VOTEA";
			}
			if(gameObject.tag == "BLAMEB"){
				gameObject.tag = "VOTEB";
			}
			if(gameObject.tag == "BLAMEC"){
				gameObject.tag = "VOTEC";
			}
			if(gameObject.tag == "BLAMED"){
				gameObject.tag = "VOTED";
			}

		}

			if(BlameCounter.blameTime == BlameCounter.timerLength + 1){
				
				BlameRender.enabled = true;
				VoteRender.enabled = false;
				
				if(gameObject.tag == "VOTEA"){
					gameObject.tag = "BLAMEA";
				}
				if(gameObject.tag == "VOTAB"){
					gameObject.tag = "BLAMEB";
				}
				if(gameObject.tag == "VOTEC"){
					gameObject.tag = "BLAMEC";
				}
				if(gameObject.tag == "VOTED"){
					gameObject.tag = "BLAMED";
				}
		

		}

}
}
