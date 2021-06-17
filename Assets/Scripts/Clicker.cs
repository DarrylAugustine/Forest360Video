using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Clicker : MonoBehaviour
{
    // Start is called before the first frame update
    private LineRenderer line;
    RaycastHit hit;
    GameObject selectedButton;

    private void Start()
    {
        line = GetComponent<LineRenderer>();
        line.enabled = false;
    }

    private void Update()
    {

        if (Input.GetButton("XRI_Right_TriggerButton"))
        {
            line.enabled = true;
        }
        else
        {
            line.enabled = false;
        }

        if (Input.GetButtonUp("XRI_Right_TriggerButton"))
        {
            // Debug.Log("works");
            if (Physics.Raycast(transform.position, transform.forward, out hit, 5.0f))
            {
                selectedButton = hit.collider.gameObject;
                selectedButton.GetComponent<VideoPlayer>().Play();
            }
        }
        





    }

    
}
