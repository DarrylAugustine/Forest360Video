using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class OculusControllerPlayer : MonoBehaviour
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
        if (Input.GetButtonUp("XRI_Right_PrimaryButton"))
        {

            currentVideo.Play();
            
        }
        if (Input.GetButtonUp("XRI_Right_SecondaryButton"))
        {

            currentVideo.Pause();

        }
    }
}
