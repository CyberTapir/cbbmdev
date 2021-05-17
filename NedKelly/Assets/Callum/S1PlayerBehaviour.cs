using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S1PlayerBehaviour : MonoBehaviour
{
    public static string haveKey="n";
    public static string haveFriend="n";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal") * 750, Input.GetAxis("Vertical") * 750);

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Key")
        {
            Debug.Log("Picked up key");
            haveKey = "y";
        }
        else if ((other.tag == "door") && (haveKey == "y"))
        {
            Debug.Log("lad scene 2");
            SceneManager.LoadScene("Story2");
        }
    }
}
