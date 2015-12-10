using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Winner : MonoBehaviour {

    public SpriteRenderer emily;
    public SpriteRenderer barbara;
    public SpriteRenderer rachel;
    public SpriteRenderer lauren;

    public GameObject winner;
    public GameObject winner2;
    Text winning;
    Text winning2;

    void Start() {
        winning = winner.GetComponent<Text>();
        winning2 = winner2.GetComponent<Text>();
    }
 
    void Update () {

        winning.text = " " + KeepScore.maxKey;
        winning2.text = " " + KeepScore.maxKey;

        if (KeepScore.maxKey == "Emily")
        { emily.enabled = true; }

        if (KeepScore.maxKey == "Barbara")
        { barbara.enabled = true; }

        if (KeepScore.maxKey == "Rachel")
        { rachel.enabled = true; }

        if (KeepScore.maxKey == "Lauren")
        { lauren.enabled = true; }

    }
}
