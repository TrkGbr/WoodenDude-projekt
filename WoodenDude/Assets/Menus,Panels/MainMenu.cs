using UnityEngine;

public class MainMenu : MonoBehaviour
{
    //Kilépés a játékból
    public void QuitGame()
    {
        Debug.Log("Quiting...");
        Application.Quit();
    }
}
