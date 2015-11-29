using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BlackText : MonoBehaviour {

    string[] textQuestion = {
            "Zoe told the principle one of you started a rumour that she got a nose job.",
            "Zoe told the principle she saw one of you at school early in the morning.",
            "Zoe told the principle one of you told everyone that she pooped her pants in 2nd grade.",
            "Zoe told the principle one of you wouldn’t let her joint the swim team.",
            "Zoe told the principle that one of you told everyone she is “fugly.”",
            "Zoe told the principle one of you asked everyone in the grade to sign the note.",
            "Zoe told the principle one of you started a rumour that Emily’s boyfriend was cheating on her with Zoe.",
            "Zoe told the principle one of you excluded her from a party she thought she should be invited to.",
        };

    string[] textBlack = {
            "Rachel and Lauren used to call Zoe Shrek.",
            "Lauren has a locker next to Zoe’s.",
            "Lauren told Rachel that Zoe peed her pants.",
            "Zoe used to hook up with Rachel’s ex-boyfriend. Rachel is best friends with the captain of the swim team.",
            "Barbara and Emily started a quiz on Facebook asking everyone to vote on who the ugliest girl in the school is.",
            "Everyone but Emily signed the note.",
            "Barbara and Rachel saw Zoe run her hand through Emily’s boyfriends hair.",
            "Lauren was in charge of inviting people to Rachel’s pool parties.",
        };

    Text black;
    Text question;
    public GameObject blacktext;
    public GameObject questiontext;

    void Start () {
        question = questiontext.GetComponent<Text>();
        black = blacktext.GetComponent<Text>();
    }

	void Update () { 
        black.text = textBlack[BlameCounter.questionNumber];
        question.text = textQuestion[BlameCounter.questionNumber];
    }
}
