using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 20;
    public Transform player; // A j�t�kos Transform komponense

    private Rigidbody2D rb;
    private Vector2 direction;
    private Coroutine stopCoroutine;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        FindPlayer(); // Kezdetben megkeress�k a j�t�kost
        MoveEnemy();
    }

    void FindPlayer()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }

    void MoveEnemy()
    {
        if (player != null)
        {
            Rotate();

            // Ir�ny vektor kisz�m�t�sa a j�t�kos fel�
            direction = (player.position - transform.position).normalized;

            // Mozg�s az ir�nyba
            rb.velocity = direction * moveSpeed;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Border"))
        {
            StopEnemy();

            if (stopCoroutine != null)
            {
                StopCoroutine(stopCoroutine);
            }

            stopCoroutine = StartCoroutine(StopforSeconds(5f));

            // Ha �tk�zik, megkeress�k �jra a j�t�kost
            FindPlayer();

            direction = (player.position - transform.position).normalized;

            Rotate();
            moveSpeed = 20;

            Debug.Log("Anya j�v�k");
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            
            Debug.Log("Anya megj�ttem");
        }
    }

    public void Rotate()
    {        
        var relativePos = player.position - transform.position;
        var angle = Mathf.Atan2(relativePos.y, relativePos.x) * Mathf.Rad2Deg + 90;
        var rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = rotation;
    }

    void StopEnemy()
    {
        moveSpeed = 0;
        rb.velocity = direction * moveSpeed; ;
    }

    IEnumerator StopforSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        StartEnemy();
    }

    void StartEnemy()
    {
        direction = (player.position - transform.position).normalized;
        rb.velocity = direction * moveSpeed;
    }
    
}