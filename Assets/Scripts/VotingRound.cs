using UnityEngine;
using System.Collections;

public class VotingRound : MonoBehaviour
{

    static int voteCounter = 0;

    void Start() {
        voteCounter = 0;
    }

    void Update()
    {
        

        if (voteCounter == 4)
        {
            Invoke("NextScene", 1f);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (this.tag == "VOTEA")
        {
            if (other.CompareTag("A"))
            {
                KeepScore.phase2[0] = "a";
            }

            if (other.CompareTag("B"))
            {
                KeepScore.phase2[1] = "a";
            }

            if (other.CompareTag("C"))
            {
                KeepScore.phase2[2] = "a";
            }

            if (other.CompareTag("D"))
            {
                KeepScore.phase2[3] = "a";
            }

        }

        if (this.tag == "VOTEB")
        {
            if (other.CompareTag("A"))
            {
                KeepScore.phase2[0] = "b";
            }

            if (other.CompareTag("B"))
            {
                KeepScore.phase2[1] = "b";
            }

            if (other.CompareTag("C"))
            {
                KeepScore.phase2[2] = "b";
            }

            if (other.CompareTag("D"))
            {
                KeepScore.phase2[3] = "b";
            }

        }

        if (this.tag == "VOTEC")
        {
            if (other.CompareTag("A"))
            {
                KeepScore.phase2[0] = "c";
            }

            if (other.CompareTag("B"))
            {
                KeepScore.phase2[1] = "c";
            }

            if (other.CompareTag("C"))
            {
                KeepScore.phase2[2] = "c";
            }

            if (other.CompareTag("D"))
            {
                KeepScore.phase2[3] = "c";
            }

        }

        if (this.tag == "VOTED")
        {
            if (other.CompareTag("A"))
            {
                KeepScore.phase2[0] = "d";
            }

            if (other.CompareTag("B"))
            {
                KeepScore.phase2[1] = "d";
            }

            if (other.CompareTag("C"))
            {
                KeepScore.phase2[2] = "d";
            }

            if (other.CompareTag("D"))
            {
                KeepScore.phase2[3] = "d";
            }

        }

        if (other.gameObject.tag == "A" || other.gameObject.tag == "B" || other.gameObject.tag == "C" || other.gameObject.tag == "D")
        {
            voteCounter++;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "A" || other.gameObject.tag == "B" || other.gameObject.tag == "C" || other.gameObject.tag == "D")
        {
            voteCounter--;
        }
    }

    void NextScene()
    {
        if (BlameCounter.questionNumber == 8)
        {
            Application.LoadLevel("End");
        }

        if (BlameCounter.questionNumber != 8)
        {
            if (Application.loadedLevelName == ("Period"))
            {
                Application.LoadLevel("BlueandRedRumour");
            }
            else
            {
                Application.LoadLevel(Application.loadedLevel + 1);
            }
        }
    }
}

 
