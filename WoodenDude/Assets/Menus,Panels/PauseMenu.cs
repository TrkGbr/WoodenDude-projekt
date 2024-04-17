using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    //J�t�k meg�ll�t�shoz �s refer�l�sok
    public static bool GameIsPaused = false;
    public GameObject pauseMenu;

    void Pause()
    {
        //J�t�k �s id� meg�ll�t�sa, men� behoz�sa
        pauseMenu.SetActive(true);
        GameIsPaused = true;
        Time.timeScale = 0f;
    }


    public void Resume()
    {
        //J�t�k �s id�elind�t�s, men� elt�ntet�se
        pauseMenu.SetActive(false);
        GameIsPaused = false;
        Time.timeScale = 1f;
    }


    void Update()
    {
        //Ha lenyomjuk a Escape gombot
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //�s a j�t�k �ppen megy
            if (GameIsPaused == false)
            {
                //A j�t�k �lljon meg
                Pause();
            }
            //Ellenkez� esetben menjen tov�bb
            else
            {
                Resume();
            }
        }
    }

    //Kil�p�s a f�men�be
    public void ExitToMain()
    {
        SceneManager.LoadScene("Menu");
        GameManager.Instance.symbolCount = 0;
    }
}
