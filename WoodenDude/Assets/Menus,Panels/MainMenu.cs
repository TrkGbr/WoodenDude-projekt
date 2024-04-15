using UnityEngine;

public class MainMenu : MonoBehaviour
{
    //Mentett állapot esetén folytatás lehetõsége
    public void ContinueGame()
    {
        QuestionMenu questionMenuInstance = new QuestionMenu();

        // Betölti a mentést
        questionMenuInstance.LoadByXml();

        Debug.Log("Continue...");
    }

    //Kilépés a játékból
    public void QuitGame()
    {
        Debug.Log("Quiting...");
        Application.Quit();
    }
}
