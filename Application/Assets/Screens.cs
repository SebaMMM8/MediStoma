using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Screens : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject mainMenuScreen;
    [SerializeField] private GameObject secondMenuScreen;

    private static Screens instance;

    public static Screens Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<Screens>();
            }

            return instance;
        }
    }

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void SwitchScreens()
    {
        bool isMainMenuActive = mainMenuScreen.activeSelf;
        mainMenuScreen.SetActive(!isMainMenuActive);
        secondMenuScreen.SetActive(isMainMenuActive);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //
    }
}
