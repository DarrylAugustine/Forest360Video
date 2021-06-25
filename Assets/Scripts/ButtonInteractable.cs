using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;
using UnityEngine.EventSystems;
public class ButtonInteractable : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    private const float hoverStartAniamtionDuration = 0.2f;
    private const float hoverEndAnimationDuration = 0.1f;
private  const float scaleFactor = .50f;
    private Button button;
    private Image image;
    private TMP_Text text;
    private Vector3 startScale;
    private Color startTextColor;
    private Color startImageColor;
    

    public Color textHoverColor;
    public Color buttonHoverColor;


    void Awake()
    {
        button = GetComponent<Button>();
        image = GetComponent<Image>();
        //text = GetComponentInChildren<TMP_Text>();
        startScale = transform.localScale;
        //startTextColor = text.color;
        startImageColor = image.material.color;
    }
    public void OnHoverStart()
    {
        // stop all animations
        transform.DOKill();
        transform.DOScale(scaleFactor, hoverStartAniamtionDuration);
        //text.DOColor(textHoverColor, hoverStartAniamtionDuration);
        //image.DOColor(buttonHoverColor, hoverStartAniamtionDuration);
    }
    public void OnHoverEnd()
    {
        // stop all animations
        transform.DOKill();
        transform.DOScale(startScale, hoverEndAnimationDuration);
        //text.DOColor(startTextColor, hoverEndAnimationDuration);
        image.DOColor(startImageColor, hoverEndAnimationDuration);
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        OnHoverStart();
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        OnHoverEnd();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        
    }
}