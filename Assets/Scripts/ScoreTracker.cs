using UnityEngine;
using System.Collections;

public class ScoreTracker : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {

        print(Mathf.Max(KeepScore.playerAscore, KeepScore.playerBscore, KeepScore.playerCscore, KeepScore.playerDscore ));
        print(Mathf.Min(KeepScore.playerAscore, KeepScore.playerBscore, KeepScore.playerCscore, KeepScore.playerDscore ));

    }
}
