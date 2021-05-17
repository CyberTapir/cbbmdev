using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextBehaviour : MonoBehaviour
{
    Text textComponent;
    // Start is called before the first frame update
    void Start()
    {
        //get the component <text>
        textComponent = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //Show the score updating from PlayerBehaviour
        textComponent.text = "Score: " + PlayerBehaviour.score.ToString();
    }
}
