using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ActiveVideoScene : MonoBehaviour
{
    public VideoPlayer currentVideo;

    // Start is called before the first frame update
    void Awake()
    {
        currentVideo.Prepare();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetButtonUp("XRI_Right_PrimaryButton"))
        {

            PlayVideo();

        }
        if (Input.GetButtonUp("XRI_Right_SecondaryButton"))
        {

            PauseVideo();

        }*/
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
