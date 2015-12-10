using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Period : MonoBehaviour {

    string[] RoundNumber = {
            "PERIOD 1",
            "PERIOD 2",
            "PERIOD 3",
            "PERIOD 4",
            "PERIOD 5",
            "PERIOD 6",
            "PERIOD 7",
            "LAST PERIOD",
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
