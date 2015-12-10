using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RankScores : MonoBehaviour {
	
	void Start () {
	
		List<KeyValuePair<string, int>> scoreList = new List<KeyValuePair<string, int>>();
		scoreList.Add(new KeyValuePair<string, int>("a",-250));
		scoreList.Add(new KeyValuePair<string, int>("b",0));
		scoreList.Add(new KeyValuePair<string, int>("c",0));
		scoreList.Add(new KeyValuePair<string, int>("d",500));


		int maxVal = -8000; // max lowest score
		int minVal = 6400;  // max highest score 
		string maxKey = "";
		string minKey = "";
		int maxTie = 0;
		int minTie = 0;

		foreach (KeyValuePair<string, int> item in scoreList) {
			if (item.Value > maxVal) {
				maxKey = item.Key;
				maxVal = item.Value;
			}
			
			if (item.Value < minVal) {
				minKey = item.Key;
				minVal = item.Value;
			}
		}
		
		foreach(KeyValuePair<string, int> item in scoreList) {
			if (item.Value == maxVal) maxTie++;
			if (item.Value == minVal) minTie++;
		}
		
		if (maxTie > 1) maxKey = "tie";
		if (minTie > 1) minKey = "tie";
		
		print ("Winner " + maxKey + ":" + maxVal + " Loser " + minKey + ":" + minVal);

	}
}
