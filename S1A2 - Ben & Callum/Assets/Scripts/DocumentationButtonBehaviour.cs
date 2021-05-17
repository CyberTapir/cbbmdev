using UnityEngine;

public class DocumentationButtonBehaviour : MonoBehaviour
{
    public string url;

    public void open()
    {
        Application.OpenURL(url);
    }
}
