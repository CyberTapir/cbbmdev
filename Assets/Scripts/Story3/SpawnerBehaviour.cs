using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnerBehaviour : MonoBehaviour
{

    public GameObject obstacle;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObstacle", 0,  Random.Range(0.5f, 1f));
    }

    void CreateObstacle()
    {
        //Set X position to between -9 and 9, and use the spawner's Y position.
        //transform.position = new Vector2(Random.Range(0f, 3000f), transform.position.y);

        obstacle.transform.position = transform.position;
        
        //Speed set to a number between 5 and 10
        ObstacleBehaviour obScript = obstacle.GetComponent<ObstacleBehaviour>();
        obScript.speed = 1000f;

        //random size set to between 0.1 and 0.2 (x axis)
        float size = Random.Range(45f, 50f);
        //random size2 set to between 0.2 and 0.5 (y axis)
        float size2 = Random.Range(45f, 50f);
        obstacle.transform.localScale = new Vector2(size, size2);

        //Create obstacle
        Instantiate(obstacle);
    }

    void Update()
    {

        Vector2 movement = new Vector2(speed, 0);
        transform.Translate(movement * Time.deltaTime, Space.World);

        if(transform.position.x < 0){
            speed = -speed;

        } 
        if(transform.position.x > 3750){
            speed = -speed;
        }
        
    }
}
