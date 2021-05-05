using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehaviour : MonoBehaviour
{

    public GameObject obstacle;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObstacle", 0.1f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateObstacle()
    {
        //Set X position to between -9 and 9, and use the spawner's Y position.
        obstacle.transform.position = new Vector2(Random.Range(0f, 3800f), transform.position.y);
        
        //Speed set to a number between 5 and 10
        //ObstacleBehaviour obScript = obstacle.GetComponent<ObstacleBehaviour>();
        //obScript.speed = Random.Range(10f, 15f);

        //random size set to between 0.1 and 0.2 (x axis)
        float size = Random.Range(1f, 1.5f);
        //random size2 set to between 0.2 and 0.5 (y axis)
        float size2 = Random.Range(1f, 1.5f);
        obstacle.transform.localScale = new Vector2(size, size2);

        //Create obstacle
        Instantiate(obstacle);
    }

}
