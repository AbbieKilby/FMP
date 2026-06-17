using UnityEngine;

public class ClickToHide : MonoBehaviour
{
    void OnMouseDown()
    {
        gameObject.SetActive(false);
    }
}
