using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MoveCursor : MonoBehaviour {



	public float speed;
    public SpriteRenderer crown;
    public SpriteRenderer loser;
	
	void FixedUpdate () {

        if (gameObject.tag == "A")
        {
            Vector3 move = new Vector3(Input.GetAxis("Horizontal1"), Input.GetAxis("Vertical1"), 0);
            transform.position += move * speed * Time.deltaTime;
            if (KeepScore.maxKey == "Emily")
            {crown.enabled = true;}
            else { crown.enabled = false; }
            if (KeepScore.minKey == "Emily")
            {loser.enabled = true;}
            else { loser.enabled = false; }
        }

        if (gameObject.tag == "B")
        {
            Vector3 move = new Vector3(Input.GetAxis("Horizontal2"), Input.GetAxis("Vertical2"), 0);
            transform.position += move * speed * Time.deltaTime;

            if (KeepScore.maxKey == "Barbara")
            {crown.enabled = true;}
            else { crown.enabled = false; }
            if (KeepScore.minKey == "Barbara")
            {loser.enabled = true;}
            else { loser.enabled = false; }
        }

        if (gameObject.tag == "C")
        {
            Vector3 move = new Vector3(Input.GetAxis("Horizontal3"), Input.GetAxis("Vertical3"), 0);
            transform.position += move * speed * Time.deltaTime;

            if (KeepScore.maxKey == "Rachel")
            {crown.enabled = true;}
            else { crown.enabled = false; }
            if (KeepScore.minKey == "Rachel")
            {loser.enabled = true;}
            else { loser.enabled = false; }
        }

        if (gameObject.tag == "D")
        {
            Vector3 move = new Vector3(Input.GetAxis("Horizontal4"), Input.GetAxis("Vertical4"),0);
            transform.position += move * speed * Time.deltaTime;

            if (KeepScore.maxKey == "Lauren")
            { crown.enabled = true; }
            else { crown.enabled = false; }
            if (KeepScore.minKey == "Lauren")
            { loser.enabled = true; }
            else { loser.enabled = false; }
        }










    }


}
