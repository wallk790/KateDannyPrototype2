using UnityEngine;
using System.Collections;

public class BlamingRound : MonoBehaviour {

    public SpriteRenderer E;
    public SpriteRenderer B;
    public SpriteRenderer R;
    public SpriteRenderer L;
    public SpriteRenderer A;

    void Start() {
        A.enabled = true;
    }


    void Update () {

        if (this.tag == "A")
        {

            if (Input.GetButtonDown("Emily1"))
            {
                KeepScore.phase1[0] = "a";
                E.enabled = true; B.enabled = false; R.enabled = false; L.enabled = false; A.enabled = false;
            }

            if (Input.GetButtonDown("Barbara1"))
            {
                KeepScore.phase1[0] = "b";
                E.enabled = false; B.enabled = true; R.enabled = false; L.enabled = false; A.enabled = false;
            }

            if (Input.GetButtonDown("Rachel1"))
            {
                KeepScore.phase1[0] = "c";
                E.enabled = false; B.enabled = false; R.enabled = true; L.enabled = false; A.enabled = false;
            }

            if (Input.GetButtonDown("Lauren1"))
            {
                KeepScore.phase1[0] = "d";
                E.enabled = false; B.enabled = false; R.enabled = false; L.enabled = true; A.enabled = false;
            }

        }

        if (this.tag == "B")
        {

            if (Input.GetButtonDown("Emily2"))
            {
                KeepScore.phase1[1] = "a";
                E.enabled = true; B.enabled = false; R.enabled = false; L.enabled = false; A.enabled = false;
            }

            if (Input.GetButtonDown("Barbara2"))
            {
                KeepScore.phase1[1] = "b";
                E.enabled = false; B.enabled = true; R.enabled = false; L.enabled = false; A.enabled = false;
            }

            if (Input.GetButtonDown("Rachel2"))
            {
                KeepScore.phase1[1] = "c";
                E.enabled = false; B.enabled = false; R.enabled = true; L.enabled = false; A.enabled = false;
            }

            if (Input.GetButtonDown("Lauren2"))
            {
                KeepScore.phase1[1] = "d";
                E.enabled = false; B.enabled = false; R.enabled = false; L.enabled = true; A.enabled = false;
            }

        }

        if (this.tag == "C")
        {

            if (Input.GetButtonDown("Emily3"))
            {
                KeepScore.phase1[2] = "a";
                E.enabled = true; B.enabled = false; R.enabled = false; L.enabled = false; A.enabled = false;
            }

            if (Input.GetButtonDown("Barbara3"))
            {
                KeepScore.phase1[2] = "b";
                E.enabled = false; B.enabled = true; R.enabled = false; L.enabled = false; A.enabled = false;
            }

            if (Input.GetButtonDown("Rachel3"))
            {
                KeepScore.phase1[2] = "c";
                E.enabled = false; B.enabled = false; R.enabled = true; L.enabled = false; A.enabled = false;
            }

            if (Input.GetButtonDown("Lauren3"))
            {
                KeepScore.phase1[2] = "d";
                E.enabled = false; B.enabled = false; R.enabled = false; L.enabled = true; A.enabled = false;
            }

        }

        if (this.tag == "D")
        {

            if (Input.GetButtonDown("Emily4"))
            {
                KeepScore.phase1[3] = "a";
                E.enabled = true; B.enabled = false; R.enabled = false; L.enabled = false; A.enabled = false;
            }

            if (Input.GetButtonDown("Barbara4"))
            {
                KeepScore.phase1[3] = "b";
                E.enabled = false; B.enabled = true; R.enabled = false; L.enabled = false; A.enabled = false;
            }

            if (Input.GetButtonDown("Rachel4"))
            {
                KeepScore.phase1[3] = "c";
                E.enabled = false; B.enabled = false; R.enabled = true; L.enabled = false; A.enabled = false;
            }

            if (Input.GetButtonDown("Lauren4"))
            {
                KeepScore.phase1[3] = "d";
                E.enabled = false; B.enabled = false; R.enabled = false; L.enabled = true; A.enabled = false;
            }

        }



    }
}
