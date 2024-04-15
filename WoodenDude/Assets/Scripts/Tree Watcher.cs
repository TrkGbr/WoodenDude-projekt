using System.Collections.Generic;
using UnityEngine;

public class Tree_Watcher : MonoBehaviour
{

    public List<GameObject> All_Trees;
    public GameObject Tree_Enemy;
    public GameObject Tree_Stump;
    private int All_Trees_Count = 0;

    void Start()
    {
        All_Trees = new List<GameObject>(GameObject.FindGameObjectsWithTag("Tree"));
        All_Trees_Count = All_Trees.Count;
        Debug.Log("A fák száma:  " + All_Trees_Count);
    }

    public void EnemySpawn()
    {
        if(All_Trees_Count == 0)
        {
            return;
        }

        for (int i = 0; i < GameManager.Instance.difficulty * 10; i++)
        {
            int x = Random.Range(0, All_Trees_Count);

            int X = (int)All_Trees[x].transform.localPosition.x;
            int Y = (int)All_Trees[x].transform.localPosition.y;
            Vector2 Position = new Vector2(X, Y);

            Tree_Cutter(x, Position);
            Enemy_Spawn_Decider(Position);

        }

        Debug.Log("Megmaradt fák száma:" + All_Trees_Count);
    }

    void Enemy_Spawn_Decider(Vector2 Position)
    {
        int z = Random.Range(1, 101);

        if (z <= 25 + (GameManager.Instance.difficulty * 10))
        {
            Instantiate(Tree_Enemy, Position, Quaternion.identity);
        }
    }

    void Tree_Cutter(int x, Vector2 Position)
    {
        Destroy(All_Trees[x]);
        All_Trees.RemoveAt(x);
        All_Trees_Count--;

        Instantiate(Tree_Stump, Position, Quaternion.identity);
    }
}
