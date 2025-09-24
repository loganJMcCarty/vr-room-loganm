using UnityEngine;
using UnityEngine.Video;

public class urlsript : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Assign in the Inspector
    public string videoUrl = "file://C:/Users/LOGANMCCARTY/Videos/Screen Recording 2025-09-23 201712.mp4";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Set the URL for the video
        videoPlayer.url = videoUrl;

        // Prepare and play the video
        videoPlayer.Prepare();
       
    }

    // Update is called once per frame
    public void PlayVideo()
    {
         videoPlayer.Play();
    }
}
