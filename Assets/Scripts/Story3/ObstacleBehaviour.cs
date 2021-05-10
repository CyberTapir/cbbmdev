using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleBehaviour : MonoBehaviour
{
    public float speed;
    public GameObject Obstacle;

    private void OnCollisionEnter2D(Collision2D collision){
        //When a player collides with obstacle shows in console and sets the game to be over.  
        Debug.Log("Collision with player");
    }

    // Update is called once per frame
    void Update()
    {
        //If the obstacle is past the canvas then destroy it and the gameObject
        if(transform.position.y < -300){
            Destroy(gameObject);
            Debug.Log("Logged");
        }
        //Move the object
        transform.Translate(speed *-transform.up * Time.deltaTime, transform);
    }
}