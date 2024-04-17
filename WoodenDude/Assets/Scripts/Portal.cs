using UnityEngine;
using UnityEngine.SceneManagement;


public class PortalCollision: MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        // Player tagû objekttel való ütközés ellenõrzése
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Stone portal");
        }
    }
}