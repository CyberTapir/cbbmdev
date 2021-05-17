using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class DoorBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D()
    {
        Destroy(gameObject);
        Debug.Log("Loading new scene");
        SceneManager.LoadScene("Story2");
    }
}
