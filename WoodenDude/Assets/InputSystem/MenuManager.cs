using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenuCanvasGo;
    [SerializeField] private GameObject _settingsMenuCanvasGo;
    [SerializeField] private GameObject _difficultyCanvasGo;

    [SerializeField] private GameObject _mainMenuFirst;
    [SerializeField] private GameObject _settingsMenuFirst;
    [SerializeField] private GameObject _difficultyMenuFirst;


    private void Start()
    {
        OpenMainMenu();
    }

    public void OpenMainMenu()
    {
        _mainMenuCanvasGo.SetActive(true);
        _settingsMenuCanvasGo.SetActive(false);
        _difficultyCanvasGo.SetActive(false);
        EventSystem.current.SetSelectedGameObject(_mainMenuFirst);
    }

    public void OpenSettingsMenu()
    {
        _settingsMenuCanvasGo.SetActive(true);
        _mainMenuCanvasGo.SetActive(false);
        _difficultyCanvasGo.SetActive(false);
        EventSystem.current.SetSelectedGameObject(_settingsMenuFirst);
    }

    public void OpenDiffultyMenu()
    {
        _settingsMenuCanvasGo.SetActive(false);
        _mainMenuCanvasGo.SetActive(false);
        _difficultyCanvasGo.SetActive(true);
        EventSystem.current.SetSelectedGameObject(_difficultyMenuFirst);
    }
    
}
