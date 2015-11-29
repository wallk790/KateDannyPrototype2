using UnityEngine;
using System.Collections;

public class VotingRound : MonoBehaviour
{

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




    }
}
