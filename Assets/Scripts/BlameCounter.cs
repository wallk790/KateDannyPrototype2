using UnityEngine;
using System.Collections;

public class BlameCounter : MonoBehaviour {

	static public bool blame = false;
	static public int blameTime = 30;
	public static int timerLength = -70;
	public static int timerStart = 30;
	public static int questionNumber = -1;

	void Update (){
		//print (blameTime);
		//print (questionNumber);
		if (blameTime == timerLength) {
			CancelInvoke();
			blameTimer();

	}
	}
	void blameTimer() {
		if (blame == true) {
			blameTime = timerStart;
			countdown();
			questionNumber ++;
			}
		}
	void countdown(){
		InvokeRepeating("minus", 0f, 1f);
	}
	void minus(){
		blameTime --;
	}
}
