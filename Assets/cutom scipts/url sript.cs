using UnityEngine;
using UnityEngine.Video;

public class urlsript : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Assign in the Inspector
    public string videoUrl = "https://youtu.be/sB5n6wnT61w";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Set the URL for the video
        videoPlayer.url = videoUrl;

        // Prepare and play the video
        videoPlayer.Prepare();
        videoPlayer.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
