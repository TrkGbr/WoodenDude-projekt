using UnityEngine;

//Olyan változók létrehozása, amik nem vesznek el a Scenek váltásakor, így tárolva a betöltött adatokat
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int difficulty = 1;
    public int symbolCount;
    public int stageCounter;

    public string introduction;
    public string Ndescription;
    public string Fdescription;

    //Ne törölje ki ezeket az adatokat Scene váltáskor
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