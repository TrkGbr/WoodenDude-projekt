using UnityEngine;
using UnityEngine.SceneManagement;

public class WallCollision : MonoBehaviour
{
    private string game = "Game";

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Player-rel való ütközés esetén
        if (collision.gameObject.CompareTag("Player"))
        {
            // Betölti a Game scenet
            SceneManager.LoadScene(game);
        }
    }
}