using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StoneTablet : MonoBehaviour
{
    public GameObject[] Symbols; 
    public GameObject[] PlacedSymbols;
    public GameObject[] DeletableSymbols;
    public int Counter = 0;
    public bool GoodSymbol1;
    public bool GoodSymbol2;
    public bool GoodSymbol3;

    [SerializeField] private GameObject FinalMenuCanvasGo;
    [SerializeField] private GameObject FinalMenuFirst;

    private void Update()
    {
        if (Counter >= 3 && GoodSymbol1 && GoodSymbol2 && GoodSymbol3)
        {
            FinalMenuCanvasGo.SetActive(true);
            EventSystem.current.SetSelectedGameObject(FinalMenuFirst);
        }
        else if (Counter >= 3)
        {
            Counter = 0;
            for (int i = 0; i < 3; i++)
            {
                Destroy(DeletableSymbols[i]);
                GoodSymbol1 = false;
                GoodSymbol2 = false;
                GoodSymbol3 = false;
            }
        }
        
    }

    public void PlaceSymbol0()
    {
        GameObject newImage = Instantiate(Symbols[0], PlacedSymbols[Counter].transform.position, Quaternion.identity);
        // Set the parent of the image to the empty GameObject
        newImage.transform.parent = PlacedSymbols[Counter].transform;
        DeletableSymbols[Counter] = newImage;
        Counter++;
    }

    public void PlaceSymbol1()
    {
        GameObject newImage = Instantiate(Symbols[1], PlacedSymbols[Counter].transform.position, Quaternion.identity);
        // Set the parent of the image to the empty GameObject
        newImage.transform.parent = PlacedSymbols[Counter].transform;
        DeletableSymbols[Counter] = newImage;
        GoodSymbol1 = true;
        Counter++;
    }

    public void PlaceSymbol2()
    {
        GameObject newImage = Instantiate(Symbols[2], PlacedSymbols[Counter].transform.position, Quaternion.identity);
        // Set the parent of the image to the empty GameObject
        newImage.transform.parent = PlacedSymbols[Counter].transform;
        DeletableSymbols[Counter] = newImage; 
        Counter++;
    }

    public void PlaceSymbol3()
    {
        GameObject newImage = Instantiate(Symbols[3], PlacedSymbols[Counter].transform.position, Quaternion.identity);
        // Set the parent of the image to the empty GameObject
        newImage.transform.parent = PlacedSymbols[Counter].transform;
        DeletableSymbols[Counter] = newImage;
        GoodSymbol2 = true;
        Counter++;
    }

    public void PlaceSymbol4()
    {
        GameObject newImage = Instantiate(Symbols[4], PlacedSymbols[Counter].transform.position, Quaternion.identity);
        // Set the parent of the image to the empty GameObject
        newImage.transform.parent = PlacedSymbols[Counter].transform;
        DeletableSymbols[Counter] = newImage;
        GoodSymbol3 = true;
        Counter++;
    }

    public void PlaceSymbol5()
    {
        GameObject newImage = Instantiate(Symbols[5], PlacedSymbols[Counter].transform.position, Quaternion.identity);
        // Set the parent of the image to the empty GameObject
        newImage.transform.parent = PlacedSymbols[Counter].transform;
        DeletableSymbols[Counter] = newImage;
        Counter++;
    }
}
