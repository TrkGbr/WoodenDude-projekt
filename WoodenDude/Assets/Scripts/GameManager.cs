using UnityEngine;

//Olyan v�ltoz�k l�trehoz�sa, amik nem vesznek el a Scenek v�lt�sakor, �gy t�rolva a bet�lt�tt adatokat
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int difficulty = 1;
    public int symbolCount;
    public int stageCounter;

    public string introduction;
    public string Ndescription;
    public string Fdescription;

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