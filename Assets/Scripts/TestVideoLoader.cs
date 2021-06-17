using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System.IO;
using System;
using TMPro;

public class TestVideoLoader : MonoBehaviour
{
    [SerializeField]
    private string filePath;
    [SerializeField]
    private string platform = "Android";

    [SerializeField]
    private string fileName;
    private string videoPath;

    public VideoPlayer videoPlayer;
    public TMP_Text debugText;

    void Update()
    {
       
    }

    
    public void Retrieve()
    {
        
        //getting the rooth path for the app that's installed
        filePath = Application.persistentDataPath.Substring(0, Application.persistentDataPath.IndexOf(platform, System.StringComparison.Ordinal));

        // look for the path of the created folder you saved the file in 
        // combining the root path for the app that's installed with the folder you created
        string path = Path.Combine(Path.Combine(filePath, "Android/SaveData/Videos"), fileName);

        //debugText.text = path; // find out where the file path is for the persitent data path??

        var sdCardPath = "/sdcard/Android/Videos/whiteRabbit7.mp4";

        if (File.Exists(sdCardPath))
        {
            
            debugText.text = "Found the file " + sdCardPath;
        }
        else
        {
            debugText.text = "Path not found";
        }

            LoadVideo(sdCardPath); 
    }

    public void LoadVideo(string path)
    {
        videoPlayer.url = path;
        videoPlayer.Play();
    }

}
