using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TestScore : MonoBehaviour {
	
	public static string[] phase1 = {"a","b","d","c"};
	public static string[] phase2 = {"b","c","c","d"};
	public static string truth = "b";
	
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
	
	public GameObject timer;
	
	bool truthed;
	bool voted;
	bool blamed;
	
	public static int truthSwitch = -18;
	public static int blameSwitch = -15;
	public static int voteSwitch = -12;
	
	
	void Start (){
		
		playerA = A.GetComponent<Text>();
		playerB = B.GetComponent<Text>();
		playerC = C.GetComponent<Text>();
		playerD = D.GetComponent<Text>();
		
		BlameCounter.blame = true;
		timer.SendMessage ("blameTimer");
	}
	
	void Update(){
		
		playerA.text = " " + playerAscore;
		playerB.text = " " + playerBscore;
		playerC.text = " " + playerCscore;
		playerD.text = " " + playerDscore;
		
		if(BlameCounter.blameTime == BlameCounter.timerStart){
			truthed = false;
			voted = false;
			blamed = false;
		}
		if (!truthed && BlameCounter.blameTime  == truthSwitch){
			Truth ();
		}
		if (!voted && BlameCounter.blameTime  == voteSwitch){
			Voted ();
		}
		if (!blamed && BlameCounter.blameTime  == blameSwitch){
			Blamed ();
		}
		
	}
	
	
	void Truth () {
		if (phase2[0] == truth) playerAscore += 500;
		if (phase2[1] == truth) playerBscore += 500;
		if (phase2[2] == truth) playerCscore += 500;
		if (phase2[3] == truth) playerDscore += 500;
		truthed = true;
	}
	
	void Voted (){
		playerAscore -= occurrences("a", phase2) * 250;
		playerBscore -= occurrences("b", phase2) * 250;
		playerCscore -= occurrences("c", phase2) * 250;
		playerDscore -= occurrences("d", phase2) * 250;
		voted = true;
	}
	
	void Blamed () {
		playerAscore += occurrences(phase1[0], phase2) * 100;
		playerBscore += occurrences(phase1[1], phase2) * 100;
		playerCscore += occurrences(phase1[2], phase2) * 100;
		playerDscore += occurrences(phase1[3], phase2) * 100;
		blamed = true;
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
	
}