using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PortalCollision: MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        // Player tagû objekttel való ütközés ellenõrzése
        if (collision.gameObject.CompareTag("Player") && GameManager.Instance.symbolCount == 6)
        {
            SceneManager.LoadScene("Stone portal");
        }
    }
}