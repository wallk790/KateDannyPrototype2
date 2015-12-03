using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Period : MonoBehaviour {

    string[] RoundNumber = {
            "Period 1",
            "Period 2",
            "Period 3",
            "Period 4",
            "Period 5",
            "Period 6",
            "Period 7",
            "Period 8",
            "End",
        };

    Text round;
    public GameObject roundNumber;

    void Start () {
        round = roundNumber.GetComponent<Text>();
    }

	void Update () { 
        round.text = RoundNumber[BlameCounter.questionNumber];
    }
}
