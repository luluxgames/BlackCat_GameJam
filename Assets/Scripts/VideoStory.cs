using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoSceneManager : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Assign the VideoPlayer in Inspector
    public string nextScene = "NextSceneName"; // Set the scene to load after the video

    void Start()
    {
        if (videoPlayer == null)
        {
            videoPlayer = GetComponent<VideoPlayer>(); // Auto-find the VideoPlayer if not set
        }

        // Start playing the video automatically
        videoPlayer.Play();

        // Detect when the video finishes
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        SceneManager.LoadScene(nextScene); // Load next scene when video ends
    }
}
