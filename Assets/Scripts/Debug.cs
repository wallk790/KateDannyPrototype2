using UnityEngine;
using System.Collections;

public class Debug : MonoBehaviour {

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown("space"))
        {
            NextScene();
        }

        if (Input.GetKeyDown("7"))
        {
            BlameCounter.questionNumber = 7;
        }

    }

    void NextScene()
    {
        if(BlameCounter.questionNumber == 8)
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
