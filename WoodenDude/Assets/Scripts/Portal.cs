using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PortalCollision: MonoBehaviour
{
    private float delayBeforeDisappear = 5f;
    public Text MissionDescription;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        // Player tagû objekttel való ütközés ellenõrzése
        if (collision.gameObject.CompareTag("Player") && GameManager.Instance.symbolCount == 6)
        {
            SceneManager.LoadScene("Stone portal");

            ThirdMission();
        }
    }

    public void ThirdMission()
    {
        MissionDescription.text = GameManager.Instance.ThirdMission;
        Invoke("DisappearText", delayBeforeDisappear);
    }

    private void DisappearText()
    {
        gameObject.SetActive(false);

    }
}