using UnityEngine;
using UnityEngine.EventSystems;

public class InGameMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _GameOverMenuCanvasGo;
    [SerializeField] private GameObject _PauseMenuCanvasGo;

    [SerializeField] private GameObject _GameOverMenuFirst;
    [SerializeField] private GameObject _PauseMenuFirst;

    public void Update()
    {
        // Ha a játékos élete 0-ra vagy alá esne, meghívja a GameOver függvényt
        if (PlayerTakeDamage.currentHealth <= 0)
        {
            OpenGameOverMenu();
        }
    }

    public void OpenGameOverMenu()
    {
        PauseMenu.GameIsPaused = true;
        Time.timeScale = 0f;

        _GameOverMenuCanvasGo.SetActive(true);
        _PauseMenuCanvasGo.SetActive(false);
        EventSystem.current.SetSelectedGameObject(_GameOverMenuFirst);
    }

    public void OpenPauseMenu()
    {
        _GameOverMenuCanvasGo.SetActive(false);
        _PauseMenuCanvasGo.SetActive(true);
        EventSystem.current.SetSelectedGameObject(_PauseMenuFirst);
    }
}
