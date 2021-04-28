using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NavigationBehaviour : MonoBehaviour
{
    //Variables
    public bool escPressed = false;

    //Game objects
    public GameObject escMenu;

    // Start is called before the first frame update
    void Start()
    {
        escMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("002");
            escAction();
        }
    }

    //What happens when the esc key is pressed
    void escAction()
    {
        Debug.Log("Entered method");
        escMenu.SetActive(true);
    }
}
