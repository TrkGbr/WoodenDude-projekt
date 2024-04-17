using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    [SerializeField] private GameObject _PauseMenuCanvasGo;

    private bool isPaused;

    private void Start()
    {
        _PauseMenuCanvasGo.SetActive(false);
    }

    private void Update()
    {
        if (InputManager.instance.MenuOpenCloseInput)
        {
            if(!isPaused)
            {
                Pause();
            }
            else
            {
                Resume();
            }

        }
    }

    #region Pause/Unpause Functions

    public void Pause()
    {
        isPaused = true;
        Time.timeScale = 0f;

        OpenPauseMenu();
    }

    public void Resume()
    {
        isPaused = false;
        Time.timeScale = 1f;

        ClosePauseMenu();
    }

    #endregion

    #region Canvas Activatian/Deactivation

    private void OpenPauseMenu()
    {
        _PauseMenuCanvasGo.SetActive(true);
    }

    private void ClosePauseMenu()
    {
        _PauseMenuCanvasGo.SetActive(false);
    }

    #endregion

    public void ExitToMain()
    {
        SceneManager.LoadScene("Menu");
        GameManager.Instance.symbolCount = 0;
    }
}
