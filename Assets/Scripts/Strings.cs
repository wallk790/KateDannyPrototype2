using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Strings : MonoBehaviour {

		string[] textQuestion = {
			"Zoe told the principal one of you started a rumour that she got a nose job.",
			"Zoe told the principal she saw one of you at school by the lockers in the morning.",
			"Zoe told the principal one of you told everyone that she pooped her pants in 2nd grade.",
			"Zoe told the principal one of you wouldn’t let her join the swim team.",
			"Zoe told the principal that one of you told everyone she is “fugly.”",
			"Zoe told the principal one of you asked everyone in the grade to sign the note.",
			"Zoe told the principal one of you started a rumour that Emily’s boyfriend was cheating on her with Zoe.",
			"Zoe told the principal one of you excluded her from a party she thought she should be invited to.",
		};
		
		string[] textRed = {
			"Rachel’s Dad is the biggest nose surgeon in town.",
			"Lauren came in early to clean out her locker before class.",
			"Lauren heard from Zoe’s neighbour that Zoe peed her pants in 2nd grade ",
			"Lauren doesn't like Zoe. She used to be on the swim team but isn’t anymore.",
			"Rachel always talks about girls looks behind their backs.",
			"Lauren signed the note first, and then asked Rachel to sign it.",
			"Rachel saw Zoe and Emily’s boyfriend coming out of a room at a party together.",
			"Rachel had pool parties all summer and never invited Zoe.",
		}; 
		
		string[] textBlue = {
			"Barbara used to talk behind Zoe’s back and make fun of her appearance.",
			"Emily was at school early for swim practice, she would have had time alone by the lockers.",
			"Emily was in Zoe’s 2nd grade class.",
			"Barbara is the best swimmer on the team. If she says she doesn’t want someone on the team, they won’t be allowed to join.",
			"Emily made a comment in class about how Zoe is the ugliest girl in school.",
			"Barbara was the first one to ever see the note.",
			"Emily was fighting with her boyfriend and told everyone he was cheating on her to make him look bad.",
			"Emily had a party and invited everyone in the whole grade except for Zoe.",
		};
		
		

	Text question;
	Text red;
	Text blue;

	
	public GameObject questiontext;
	public GameObject redtext;
	public GameObject bluetext;



	void Start() {

		question = questiontext.GetComponent<Text>();
		red = redtext.GetComponent<Text>();
		blue = bluetext.GetComponent<Text>();
		

	}

	void Update () {

		question.text = textQuestion[BlameCounter.questionNumber];
		red.text = textRed[BlameCounter.questionNumber];
		blue.text = textBlue[BlameCounter.questionNumber];
	}



	}