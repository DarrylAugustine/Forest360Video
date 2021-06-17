using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TourManager : MonoBehaviour
{

    private static TourManager _Instance;

    public GameObject XRRig;

    //private VideoPlayer videoPlayer; 
    //public Material playButtonMaterial;
    //public Material pauseButtonMaterial;
    //public Renderer screenRenderer;

    public static TourManager Instance()
    {
        return _Instance;
    }

    void Awake()
    {
        if (_Instance != null && _Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _Instance = this;
        }

        //videoPlayer = GetComponent<VideoPlayer>(); // 
    }

    public void NavigateTo(GameObject scene)
    {
        XRRig.transform.position = scene.transform.position;

        //var activeScene = scene.GetComponent<VideoPlayer>();
        //activeScene.Play();


        Debug.Log("Video played on navigating into scene sphere");

    }

    /*public void PlayPause()
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
            screenRenderer.material = playButtonMaterial;

        }
        else
        {
            videoPlayer.Play();
            screenRenderer.material = pauseButtonMaterial;
        }

    }*/
}
