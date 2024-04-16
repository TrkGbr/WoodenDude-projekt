using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    // Refer�l�s a FailedPanelra
    public GameObject failedPanel;

    public void GameOver()
    {
        //J�t�k �s id� meg�ll�t�sa, men� megjelen�t�se
        failedPanel.SetActive(true);
        PauseMenu.GameIsPaused = true;
        Time.timeScale = 0f;
    }

    public void Update()
    {
        // Ha a j�t�kos �lete 0-ra vagy al� esne, megh�vja a GameOver f�ggv�nyt
        if (PlayerTakeDamage.currentHealth <= 0)
        {
            GameOver();
        }
    }

    public void ExitAfterFail()
    {
        SceneManager.LoadScene("Menu");

        //A felvett krediteket null�zzuk fail eset�n
        GameManager.Instance.symbolCount = 0;
    }
}
