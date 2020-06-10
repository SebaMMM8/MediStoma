using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] Button firstButton;
    [SerializeField] Button secondButton;
    [SerializeField] Button thirdButton;

    protected virtual void OnEnable()
    {
        Debug.Log("OnEnable");
        SubscribeToEvents();
    }

    protected virtual void OnDisable()
    {
        Debug.Log("OnDisable");
        UnsubscribeToEvents();
    }

    private void SubscribeToEvents()
    {
        Debug.Log("SubscribeToEvents");

        firstButton.onClick.AddListener(OnFirstButtonClick);
        secondButton.onClick.AddListener(OnSecondButtonClick);
        thirdButton.onClick.AddListener(OnThirdButtonClick);
    }

    private void UnsubscribeToEvents()
    {
        Debug.Log("UnsubscribeToEvents");

        firstButton.onClick.RemoveListener(OnFirstButtonClick);
        secondButton.onClick.RemoveListener(OnSecondButtonClick);
        thirdButton.onClick.RemoveListener(OnThirdButtonClick);
    }

    private void OnFirstButtonClick()
    {
        Debug.Log("OnFirstButtonClick");
        Screens.Instance.SwitchScreens();
    }

    private void OnSecondButtonClick()
    {
        Debug.Log("OnSecondButtonClick");
    }

    private void OnThirdButtonClick()
    {
        Debug.Log("OnThirdButtonClick");
    }
}