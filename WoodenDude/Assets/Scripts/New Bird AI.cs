using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform player; // A játékos Transform komponense

    private Rigidbody2D rb;
    private Vector2 direction;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        FindPlayer(); // Kezdetben megkeressük a játékost
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

            // Irány vektor kiszámítása a játékos felé
            direction = (player.position - transform.position).normalized;

            // Mozgás az irányba
            rb.velocity = direction * moveSpeed;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Border"))
        {
            StartCoroutine(Stopforseconds(50f));

            // Ha ütközik, megkeressük újra a játékost
            FindPlayer();
            // Új irány a játékos felé
            direction = (player.position - transform.position).normalized;

            Rotate();

            // Mozgás az irányba
            rb.velocity = direction * moveSpeed;
            Debug.Log("Anya jövök");
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            
            Debug.Log("Anya megjöttem");
        }
    }

    public void Rotate()
    {
        var relativePos = player.position - transform.position;
        var angle = Mathf.Atan2(relativePos.y, relativePos.x) * Mathf.Rad2Deg + 90;
        var rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = rotation;
    }

    IEnumerator Stopforseconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);
    }
}