using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickToChangeScene : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("Battle");
    }
}
