using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KeepScore : MonoBehaviour {

	public static string[] phase1 = {"a","b","d","c"};
	public static string[] phase2 = {"b","c","c","d"};
	public static string truth;

	int playerAscore = 0;
	int playerBscore = 0;
	int playerCscore = 0;
	int playerDscore = 0;

	Text playerA;
	Text playerB;
	Text playerC;
	Text playerD;

	public GameObject A;
	public GameObject B;
	public GameObject C;
	public GameObject D;

	bool truthed;
	bool voted;
	bool blamed;
	
	void Start (){
		playerA = A.GetComponent<Text>();
		playerB = B.GetComponent<Text>();
		playerC = C.GetComponent<Text>();
		playerD = D.GetComponent<Text>();
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
	

	void Truth () {
		if (phase2[0] == truth) playerAscore += 500;
		if (phase2[1] == truth) playerBscore += 500;
		if (phase2[2] == truth) playerCscore += 500;
		if (phase2[3] == truth) playerDscore += 500;

	}
		
	void Voted (){
		playerAscore -= occurrences("a", phase2) * 250;
		playerBscore -= occurrences("b", phase2) * 250;
		playerCscore -= occurrences("c", phase2) * 250;
		playerDscore -= occurrences("d", phase2) * 250;

	}
		
	void Blamed () {
		playerAscore += occurrences(phase1[0], phase2) * 100;
		playerBscore += occurrences(phase1[1], phase2) * 100;
		playerCscore += occurrences(phase1[2], phase2) * 100;
		playerDscore += occurrences(phase1[3], phase2) * 100;

	}
	
	public static int occurrences(string item, string[] ary)
	{
		int count = 0;
		for (int i=0;i<ary.Length;i++)
		{
			if (ary[i] == item)
				count++;
		}
		return count;
	}
	
}