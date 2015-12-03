using UnityEngine;
using System.Collections;

public class MoveOn : MonoBehaviour {

    public SpriteRenderer zero;
    public SpriteRenderer one;
    public SpriteRenderer two;
    public SpriteRenderer three;
    public SpriteRenderer four;

    int tracker = 0;
    

	void Update () {

        if (tracker == 0) {
            zero.enabled = true;
        } else {
            zero.enabled = false;
        }

        if (tracker == 1)
        {
            one.enabled = true;
        } else {
            one.enabled = false;
        }

        if (tracker == 2)
        {
            two.enabled = true;
        }else{
            two.enabled = false;
        }

        if (tracker == 3)
        {
            three.enabled = true;
        }else{
            three.enabled = false;
        }

        if (tracker == 4)
        {
            four.enabled = true;
            Invoke("NextScene", 1f);
        }
        else{
            four.enabled = false;
            
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "A" || other.gameObject.tag == "B" || other.gameObject.tag == "C" || other.gameObject.tag == "D") {
            tracker++;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "A" || other.gameObject.tag == "B" || other.gameObject.tag == "C" || other.gameObject.tag == "D")
        {
            tracker--;
        }
    }

    void NextScene() {
        if(Application.loadedLevelName == ("Period"))
        {
           Application.LoadLevel("BlueandRedRumour");
        } else {
           Application.LoadLevel(Application.loadedLevel + 1);
        }
        
        
    }

}
