using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultyMenu : MonoBehaviour
{
    public Tree_Watcher treeWatcher;

    private string game = "game scene";

    public void easy()
    {
        GameManager.Instance.difficulty = 1;
    }

    public void medium()
    {
        GameManager.Instance.difficulty = 2;
    }

    public void hard()
    {
        GameManager.Instance.difficulty = 3;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(game);
    }
}
