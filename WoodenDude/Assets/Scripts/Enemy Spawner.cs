using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree_Enemy_Spawner : MonoBehaviour
{
    public Tree_Watcher treeWatcher;

    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            treeWatcher.EnemySpawn();
        }
    }
}
