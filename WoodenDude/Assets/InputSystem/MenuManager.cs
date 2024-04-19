using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenuCanvasGo;
    [SerializeField] private GameObject _difficultyCanvasGo;

    [SerializeField] private GameObject _mainMenuFirst;
    [SerializeField] private GameObject _difficultyMenuFirst;


    private void Start()
    {
        OpenMainMenu();
    }

    public void OpenMainMenu()
    {
        _mainMenuCanvasGo.SetActive(true);
        _difficultyCanvasGo.SetActive(false);
        EventSystem.current.SetSelectedGameObject(_mainMenuFirst);
    }

    public void OpenDiffultyMenu()
    {
        _mainMenuCanvasGo.SetActive(false);
        _difficultyCanvasGo.SetActive(true);
        EventSystem.current.SetSelectedGameObject(_difficultyMenuFirst);
    }
    
}
