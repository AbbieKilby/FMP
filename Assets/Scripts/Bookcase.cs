using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bookcase : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Bookshelf");
    }
}
