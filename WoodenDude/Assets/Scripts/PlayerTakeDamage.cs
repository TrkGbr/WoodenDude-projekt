using UnityEngine;
using UnityEngine.UI;

public class PlayerTakeDamage : MonoBehaviour
{
    public static int currentHealth;
    private int damage;
    private int maxhealth = 100;
    public Text health;

    //Megadjuk a kezdeti �let m�rt�k�t
    public void Start()
    {
        currentHealth = 100;
    }

    //Be�ll�tjuk a csapd�k �s ellenfelek sebz�s�t �s megjelen�tj�k a HUD texten is
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bird Enemy"))
        {
            damage = 5 * GameManager.Instance.difficulty;
            currentHealth = currentHealth - damage;
            health.text = currentHealth + "";
            Debug.Log("Taking damage(5)...");
        }
        if (collision.gameObject.CompareTag("Tree Enemy"))
        {
            damage = 10 * GameManager.Instance.difficulty;
            currentHealth = currentHealth - damage;
            health.text = currentHealth + "";
            Debug.Log("Taking damage(10)...");
        }
        if (collision.gameObject.CompareTag("Stump"))
        {
            if (currentHealth <= 100)
            {
                currentHealth += 10;

                if (currentHealth > maxhealth)
                {
                    currentHealth = 100;
                }
                health.text = currentHealth.ToString();
            }
        }
    }
}