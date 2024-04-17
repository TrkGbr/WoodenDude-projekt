using UnityEngine;
using UnityEngine.SceneManagement;


public class PortalCollision: MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        // Player tag� objekttel val� �tk�z�s ellen�rz�se
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Stone portal");
        }
    }
}