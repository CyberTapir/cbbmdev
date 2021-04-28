using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene1ButtonBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Finds the game object with the tag of <Button> and when it is clicked go to TaskOnClick.
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void TaskOnClick(){
        //resets the variable score from PlayerBehaviour.cs to 0 and loads the scene "s1assign1"
        SceneManager.LoadScene("Scene 1");
    }
}
