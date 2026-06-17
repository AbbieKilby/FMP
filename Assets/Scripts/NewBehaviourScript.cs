using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string nextSceneName = "Library";

    void Start()
    {
        videoPlayer.loopPointReached += OnVideoFinished;
    }

    void OnVideoFinished(VideoPlayer vp)
    {
        SceneManager.LoadScene(nextSceneName);
    }

    public void SkipVideo()
    {
        SceneManager.LoadScene(nextSceneName);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SkipVideo();
        }
    }
}