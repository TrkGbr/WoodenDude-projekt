using UnityEngine;

public class MainMenu : MonoBehaviour
{
    //Mentett �llapot eset�n folytat�s lehet�s�ge
    public void ContinueGame()
    {
        QuestionMenu questionMenuInstance = new QuestionMenu();

        // Bet�lti a ment�st
        questionMenuInstance.LoadByXml();

        Debug.Log("Continue...");
    }

    //Kil�p�s a j�t�kb�l
    public void QuitGame()
    {
        Debug.Log("Quiting...");
        Application.Quit();
    }
}
