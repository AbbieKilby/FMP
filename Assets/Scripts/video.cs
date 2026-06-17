using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class video : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Library");
    }
}
