using UnityEngine;
using UnityEngine.EventSystems;

public class InGameMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _GameOverMenuCanvasGo;
    [SerializeField] private GameObject _GameOverMenuFirst;
    
    public void Update()
    {
        // Ha a j�t�kos �lete 0-ra vagy al� esne, megh�vja a GameOver f�ggv�nyt
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
        EventSystem.current.SetSelectedGameObject(_GameOverMenuFirst);
    }

    
}
