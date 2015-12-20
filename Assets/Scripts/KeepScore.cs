using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class KeepScore : MonoBehaviour {

	public static string[] phase1 = {"l","l","l","l"};
	public static string[] phase2 = {"j","j","j","j"};
    public static string truth;
    public static string maxKey = "";
    public static string minKey = "";

    public static int playerAscore = 0;
	public static int playerBscore = 0;
	public static int playerCscore = 0;
	public static int playerDscore = 0;

	Text playerA;
	Text playerB;
	Text playerC;
	Text playerD;
    Text LeaderGirl;
    

    public GameObject A;
	public GameObject B;
	public GameObject C;
	public GameObject D;
    public GameObject Popular;
   

    public GameObject blameSticker;
	public GameObject voteSticker;
	public GameObject truthSticker;

    public SpriteRenderer truthText;
    public SpriteRenderer blameText;
    public SpriteRenderer pinnedText;


    public GameObject[] PositionsA;
	public GameObject[] PositionsB;
	public GameObject[] PositionsC;
	public GameObject[] PositionsD;
		
	int storageSpotA = 0;
	int storageSpotB = 0;
	int storageSpotC = 0;
	int storageSpotD = 0;
	
	void Start (){
		Invoke ("BlameStickers", 1f);
		Invoke ("VoteStickers", 8f);
		Invoke ("TruthStickers", 15f);
		Invoke ("Blamed", 1f);
		Invoke ("Voted", 8f);
		Invoke ("Truth", 15f);
        Invoke("Leader", 18f);
		Invoke ("setMatrix", 22f);


		playerA = A.GetComponent<Text>();
		playerB = B.GetComponent<Text>();
		playerC = C.GetComponent<Text>();
		playerD = D.GetComponent<Text>();
        LeaderGirl = Popular.GetComponent<Text>();

    }

	void Update(){

		if(BlameCounter.questionNumber == 0){
			truth = "b";
		}
		if(BlameCounter.questionNumber == 1){
			truth = "d";
		}
		if(BlameCounter.questionNumber == 2){
			truth = "c";
		}
		if(BlameCounter.questionNumber == 3){
			truth = "d";
		}
		if(BlameCounter.questionNumber == 4){
			truth = "a";
		}
		if(BlameCounter.questionNumber == 5){
			truth = "c";

		}if(BlameCounter.questionNumber == 6){
			truth = "b";
		}
		if(BlameCounter.questionNumber == 7){
			truth = "a";
		}

		playerA.text = " " + playerAscore;
		playerB.text = " " + playerBscore;
		playerC.text = " " + playerCscore;
		playerD.text = " " + playerDscore;

	}

    void Leader () {
 
        List<KeyValuePair<string, int>> scoreList = new List<KeyValuePair<string, int>>();
        scoreList.Add(new KeyValuePair<string, int>("Emily", playerAscore));
        scoreList.Add(new KeyValuePair<string, int>("Barbara", playerBscore));
        scoreList.Add(new KeyValuePair<string, int>("Rachel", playerCscore));
        scoreList.Add(new KeyValuePair<string, int>("Lauren", playerDscore));


        int maxVal = -8000; // max lowest score
        int minVal = 6400;  // max highest score 
        int maxTie = 0;
        int minTie = 0;

        foreach (KeyValuePair<string, int> item in scoreList)
        {
            if (item.Value > maxVal)
            {
                maxKey = item.Key;
                maxVal = item.Value;
            }

            if (item.Value < minVal)
            {
                minKey = item.Key;
                minVal = item.Value;
            }
        }

        foreach (KeyValuePair<string, int> item in scoreList)
        {
            if (item.Value == maxVal) maxTie++;
            if (item.Value == minVal) minTie++;
        }

        if (maxTie > 1) maxKey = "Tie";
        if (minTie > 1) minKey = "Tie";

        LeaderGirl.text = " " + maxKey;
        //LoserGirl.text = " " + minKey;

       // print("Winner " + maxKey + ":" + maxVal + " Loser " + minKey + ":" + minVal);
    }


	void Truth () {
		if (phase2[0] == truth) playerAscore += 500;
		if (phase2[1] == truth) playerBscore += 500;
		if (phase2[2] == truth) playerCscore += 500;
		if (phase2[3] == truth) playerDscore += 500;
        truthText.enabled = true;
        blameText.enabled = false;
        pinnedText.enabled = false;

}
		
	void Voted (){
		playerAscore -= occurrences("a", phase2) * 250;
		playerBscore -= occurrences("b", phase2) * 250;
		playerCscore -= occurrences("c", phase2) * 250;
		playerDscore -= occurrences("d", phase2) * 250;

        truthText.enabled = false;
        blameText.enabled = true;
        pinnedText.enabled = false;

    }
		
	void Blamed () {
		playerAscore += occurrences(phase1[0], phase2) * 100;
		playerBscore += occurrences(phase1[1], phase2) * 100;
		playerCscore += occurrences(phase1[2], phase2) * 100;
		playerDscore += occurrences(phase1[3], phase2) * 100;

        truthText.enabled = false;
        blameText.enabled = false;
        pinnedText.enabled = true;

    }
	
	 int occurrences(string item, string[] ary)
	{
		int count = 0;
		for (int i=0;i<ary.Length;i++)
		{
			if (ary[i] == item)
				count++;
		}
		return count;
	}



	void BlameStickers (){
		for (int i = 0; i < occurrences(phase1[0], phase2); i++) {
			Instantiate (blameSticker, PositionsA[storageSpotA].transform.position, Quaternion.identity);
			storageSpotA++;
		}
		for (int i = 0; i < occurrences(phase1[1], phase2); i++) {
			Instantiate (blameSticker, PositionsB[storageSpotB].transform.position, Quaternion.identity);
			storageSpotB++;
		}
		for (int i = 0; i < occurrences(phase1[2], phase2); i++) {
			Instantiate (blameSticker, PositionsC [storageSpotC].transform.position, Quaternion.identity);
			storageSpotC++;
		}
			for (int i = 0; i < occurrences(phase1[3], phase2); i++) {
			Instantiate (blameSticker, PositionsD[storageSpotD].transform.position, Quaternion.identity);
			storageSpotD++;
		}
	}

	void VoteStickers (){
		for (int i = 0; i < occurrences("a", phase2); i++) {
			Instantiate (voteSticker, PositionsA[storageSpotA].transform.position, Quaternion.identity);
			storageSpotA++;
		}
		for (int i = 0; i < occurrences("b", phase2); i++) {
			Instantiate (voteSticker, PositionsB[storageSpotB].transform.position, Quaternion.identity);
			storageSpotB++;
		}
		for (int i = 0; i < occurrences("c", phase2); i++) {
			Instantiate (voteSticker, PositionsC [storageSpotC].transform.position, Quaternion.identity);
			storageSpotC++;
		}
		for (int i = 0; i < occurrences("d", phase2); i++) {
			Instantiate (voteSticker, PositionsD[storageSpotD].transform.position, Quaternion.identity);
			storageSpotD++;
		}
	}

	void TruthStickers () {
		if (phase2[0] == truth) Instantiate (truthSticker, PositionsA[storageSpotA].transform.position, Quaternion.identity);
		if (phase2[1] == truth) Instantiate (truthSticker, PositionsB[storageSpotB].transform.position, Quaternion.identity);
		if (phase2[2] == truth) Instantiate (truthSticker, PositionsC[storageSpotC].transform.position, Quaternion.identity);
		if (phase2[3] == truth) Instantiate (truthSticker, PositionsD[storageSpotD].transform.position, Quaternion.identity);
	}

	void setMatrix() {

		phase1 [0] = "l";
		phase1 [1] = "l";
		phase1 [2] = "l";
		phase1 [3] = "l";

		phase2 [0] = "j";
		phase2 [1] = "j";
		phase2 [2] = "j";
		phase2 [3] = "j";

        BlameCounter.questionNumber++;
        Application.LoadLevel (Application.loadedLevel + 1);

        if(BlameCounter.questionNumber == 8)
        {
            Application.LoadLevel("End");
        }




	}

	
}