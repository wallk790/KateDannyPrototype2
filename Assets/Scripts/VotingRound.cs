using UnityEngine;
using System.Collections;

public class VotingRound : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
{

    if (this.tag == "A")
    {
        if (other.CompareTag("VOTEA"))
        {
            KeepScore.phase2[0] = "a";
        }

        if (other.CompareTag("VOTEB"))
        {
            KeepScore.phase2[0] = "b";
        }

        if (other.CompareTag("VOTEC"))
        {
            KeepScore.phase2[0] = "c";
        }

        if (other.CompareTag("VOTED"))
        {
            KeepScore.phase2[0] = "d";
        }

    }
}
}
