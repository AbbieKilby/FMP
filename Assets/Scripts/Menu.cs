using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("StartMenu");
    }
}