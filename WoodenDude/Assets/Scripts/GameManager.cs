using UnityEngine;

//Olyan v�ltoz�k l�trehoz�sa, amik nem vesznek el a Scenek v�lt�sakor, �gy t�rolva a bet�lt�tt adatokat
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int difficulty = 1;
    public int symbolCount;
    public int stageCounter;

    public string Introduction = "";
    public string FirstMission = "Szedd �ssze mind a 6 szimb�lumot!";
    public string SecondMission = "Keresd meg a kaput!";
    public string ThirdMission = "Helyezd be a megfelel� szimb�lumokat!";

    //Ne t�r�lje ki ezeket az adatokat Scene v�lt�skor
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}