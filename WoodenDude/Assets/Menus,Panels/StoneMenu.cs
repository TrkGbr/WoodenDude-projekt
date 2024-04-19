using UnityEngine;
using UnityEngine.EventSystems;

public class StoneMenu : MonoBehaviour
{
    [SerializeField] private GameObject _StoneMenuCanvasGo;
    [SerializeField] private GameObject _StoneMenuFirst;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        // Player tagû objekttel való ütközés ellenõrzése
        if (collision.gameObject.CompareTag("Player"))
        {
            OpenStoneMenu();
        }
    }

    public void OpenStoneMenu()
    {
        Time.timeScale = 0f;
        _StoneMenuCanvasGo.SetActive(true);
        EventSystem.current.SetSelectedGameObject(_StoneMenuFirst);
    }
}
