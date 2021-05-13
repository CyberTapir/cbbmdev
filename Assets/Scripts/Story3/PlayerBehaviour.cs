//
// I am committed to being a person of integrity.
// This project is submitted as part of the assessment for Year 9 IST.
// This is all my own work. I have referenced any work used from other
// sources and have not plagiarised the work of others.
// Ben Monro
//

//
// I am committed to being a person of integrity.
// This project is submitted as part of the assessment for Year 9 IST.
// This is all my own work. I have referenced any work used from other
// sources and have not plagiarised the work of others.
// Callum Bennett
//

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBehaviour : MonoBehaviour
{
    public static int score = 0;
    public static bool gameOver = false;
    public GameObject GameOverPopUp;
    public Text scoreText;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        //GameOverPopUp is set to false
        gameOver = false;
        GameOverPopUp.SetActive(false);
        //sets the Time to 1 second
        Time.timeScale = 1;
        //Increment score every 1 second
        InvokeRepeating("IncrementScore", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        //Sets speed and moves the player when the arrow keys are pressed
        float h = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(speed * h, 0);
        transform.Translate(movement * Time.deltaTime, Space.World);
        CheckGameOver();
    }

    void IncrementScore(){
        //increment the score
        score++;
    }


    void CheckGameOver()
    {
        if(gameOver)
        {
            //show the game over screen

            Time.timeScale = 0;
            scoreText.text = "Your score was " + score;
            GameOverPopUp.SetActive(true);
        }
    }

}
