using UnityEngine;
using UnityEngine.EventSystems;

public class StoneMenu : MonoBehaviour
{
    [SerializeField] private GameObject _StoneMenuCanvasGo;
    [SerializeField] private GameObject _StoneMenuFirst;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        // Player tag� objekttel val� �tk�z�s ellen�rz�se
        if (collision.gameObject.CompareTag("Player"))
        {
            OpenStoneMenu();
        }
    }

    public void OpenStoneMenu()
    {
        _StoneMenuCanvasGo.SetActive(true);
        EventSystem.current.SetSelectedGameObject(_StoneMenuFirst);
    }
}
