using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;
using UnityEngine.EventSystems;

public class VideoControlsInteractable : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{


    public CanvasGroup videoControlsCanvas;
    //private float videoControlsCanvasStart = 1;

    void Awake()
    {
        
       // videoControlsCanvasStart = videoControlsCanvas.alpha;
    }
    public void OnHoverStart()
    {
        videoControlsCanvas.DOFade(1, .5f);
    }
    public void OnHoverEnd()
    {
        videoControlsCanvas.DOFade(0, .5f);
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        OnHoverStart();
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        OnHoverEnd();
    }
    


}
