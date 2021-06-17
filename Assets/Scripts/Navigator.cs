using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Events;

[ExecuteInEditMode]
public class Navigator : MonoBehaviour
{
    public GameObject NavigateTo;

    

    // Update is called once per frame
    void Update()
    {
        if (NavigateTo != null)
        {
            Debug.DrawLine(transform.position, NavigateTo.transform.position, Color.green);
        }

        

    }

    public void Navigate()
    {
        TourManager.Instance().NavigateTo(NavigateTo);
        
    }
}
