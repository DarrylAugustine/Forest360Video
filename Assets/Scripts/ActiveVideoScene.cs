using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System.IO;
using TMPro;

public class ActiveVideoScene : MonoBehaviour
{
    public VideoPlayer currentVideo;
    public string questSDcardVideoName;
    public string pcVideoPath;

    // Start is called before the first frame update
    void Awake()
    {
        //currentVideo.Prepare();
    }

    private void Start()
    {
        var sdCardPath = $"/sdcard/Android/Videos/{questSDcardVideoName}";

        if (File.Exists(sdCardPath))
        {
            LoadVideo(sdCardPath);
                    
        }
        else
        {
            LoadVideo(pcVideoPath);
        }

    }

    public void LoadVideo(string path)
    {
        currentVideo.url = path;
        //currentVideo.Play();
    }
    public void PlayVideo()
    {
        currentVideo.Play();

    }

    public void PauseVideo()
    {
        currentVideo.Pause();
    }
}

       


