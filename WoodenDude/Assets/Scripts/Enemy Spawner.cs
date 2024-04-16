using UnityEngine;
using UnityEngine.UI;

public class Tree_Enemy_Spawner : MonoBehaviour
{
    public Text CollectedSymbols;
    public Tree_Watcher treeWatcher;

    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            treeWatcher.EnemySpawn();
            Destroy(gameObject);
            GameManager.Instance.symbolCount++;
            CollectedSymbols.text = GameManager.Instance.symbolCount + "/6";
        }
    }
}
