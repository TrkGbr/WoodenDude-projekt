using UnityEngine;
using UnityEngine.UI;

public class Tree_Enemy_Spawner : MonoBehaviour
{
    public Text CollectedSymbols;
    public Tree_Watcher treeWatcher;

    private float delayBeforeDisappear = 5f;
    public Text MissionDescription;
    public AudioSource pickup;

    
    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            treeWatcher.EnemySpawn();
            pickup.Play();
            Destroy(gameObject);
            GameManager.Instance.symbolCount++;
            CollectedSymbols.text = GameManager.Instance.symbolCount + "/6";

            if (GameManager.Instance.symbolCount == 1)
            {
                FirstMission();
            }
            else if (GameManager.Instance.symbolCount == 6)
            {
                SecondMission();
            }
        }
    }

    public void FirstMission()
    {
        MissionDescription.text = GameManager.Instance.FirstMission;
        Invoke("DisappearText", delayBeforeDisappear);
    }

    public void SecondMission()
    {
        MissionDescription.text = GameManager.Instance.SecondMission;
        Invoke("DisappearText", delayBeforeDisappear);
    }

    private void DisappearText()
    {
        gameObject.SetActive(false);

    }
}
