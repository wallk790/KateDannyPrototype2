using UnityEngine;
using System.Collections;

public class ResetVariables : MonoBehaviour {

	// Use this for initialization
	void Start () {

        BlameCounter.questionNumber = 0;
        KeepScore.phase1[0] = "l";
        KeepScore.phase1[1] = "l";
        KeepScore.phase1[2] = "l";
        KeepScore.phase1[3] = "l";

        KeepScore.phase2[0] = "j";
        KeepScore.phase2[1] = "j";
        KeepScore.phase2[2] = "j";
        KeepScore.phase2[3] = "j";

        KeepScore.maxKey = "";
        KeepScore.minKey = "";

        KeepScore.playerAscore = 0;
        KeepScore.playerBscore = 0;
        KeepScore.playerCscore = 0;
        KeepScore.playerDscore = 0;

}
	
	// Update is called once per frame
	void Update () {
	
	}
}
