using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.Events;

public class Controller : MonoBehaviour
{

    private LineRenderer line;
    RaycastHit hit;
    GameObject selectedButton;
    // - linepublic UnityEvent sceneLoad;

    private ActiveVideoScene activeVideoScene;

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
            
            if (Physics.Raycast(transform.position, transform.forward, out hit, 5.0f))
            {
                selectedButton = hit.collider.gameObject;
                Debug.Log(selectedButton.name);
                if (selectedButton.CompareTag("navigator"))
                {
                    Debug.Log("hit navigator tag on button1");
                    // selectedButton.GetComponent<Navigator>().sceneLoad.Invoke();
                    selectedButton.GetComponent<Navigator>().Navigate();
                }
                if (selectedButton.CompareTag("play"))
                {
                    selectedButton.GetComponent<Button>().onClick.Invoke();
                        
                }
                if (selectedButton.CompareTag("pause"))
                {
                    selectedButton.GetComponent<Button>().onClick.Invoke();
                }
                if (selectedButton.CompareTag("Load"))
                {
                    selectedButton.GetComponent<Button>().onClick.Invoke();
                }

            }
        }

    }   

}
