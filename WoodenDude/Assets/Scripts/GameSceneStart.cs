using UnityEngine;
using UnityEngine.SceneManagement;

public class WallCollision : MonoBehaviour
{
    private string game = "Game";

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Player-rel val� �tk�z�s eset�n
        if (collision.gameObject.CompareTag("Player"))
        {
            // Bet�lti a Game scenet
            SceneManager.LoadScene(game);
        }
    }
}