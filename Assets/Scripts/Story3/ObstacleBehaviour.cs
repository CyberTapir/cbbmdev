using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleBehaviour : MonoBehaviour
{
    public GameObject Obstacle;
    public float speed;

    private void OnCollisionEnter2D(Collision2D collision){
        //When a player collides with obstacle shows in console and sets the game to be over.  
        Debug.Log("Collision with player");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If the obstacle is past the canvas then destroy it and the gameObject
        if(transform.position.y < -300){
            Destroy(gameObject);
            Destroy(Obstacle);
        }

        //Move the object
        transform.Translate(speed *-transform.up * Time.deltaTime, transform);
    }
}
