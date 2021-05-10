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
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        //sets the Time to 1 second
        //Time.timeScale = 1;
        //Increment score every 1 second
        //InvokeRepeating("IncrementScore", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        //Sets speed and moves the player when the arrow keys are pressed
        float h = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(speed * h, 0);
        transform.Translate(movement * Time.deltaTime, Space.World);
    }

}
