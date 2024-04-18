using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoneTablet : MonoBehaviour
{
    public GameObject[] Symbols; 
    public GameObject[] PlacedSymbols;
    public GameObject StoneMenu;
    public int Counter = 0;

    private void Update()
    {
        if (Counter >= 3)
        {
            StoneMenu.SetActive(false);
        }
    }

    public void PlaceSymbol0()
    {
        GameObject newImage = Instantiate(Symbols[0], PlacedSymbols[Counter].transform.position, Quaternion.identity);
        // Set the parent of the image to the empty GameObject
        newImage.transform.parent = PlacedSymbols[Counter].transform;
        Counter++;
    }
    public void PlaceSymbol1()
    {
        GameObject newImage = Instantiate(Symbols[1], PlacedSymbols[Counter].transform.position, Quaternion.identity);
        // Set the parent of the image to the empty GameObject
        newImage.transform.parent = PlacedSymbols[Counter].transform;
        Counter++;
    }
    public void PlaceSymbol2()
    {
        GameObject newImage = Instantiate(Symbols[2], PlacedSymbols[Counter].transform.position, Quaternion.identity);
        // Set the parent of the image to the empty GameObject
        newImage.transform.parent = PlacedSymbols[Counter].transform;
        Counter++;
    }
    public void PlaceSymbol3()
    {
        GameObject newImage = Instantiate(Symbols[3], PlacedSymbols[Counter].transform.position, Quaternion.identity);
        // Set the parent of the image to the empty GameObject
        newImage.transform.parent = PlacedSymbols[Counter].transform;
        Counter++;
    }
    public void PlaceSymbol4()
    {
        GameObject newImage = Instantiate(Symbols[4], PlacedSymbols[Counter].transform.position, Quaternion.identity);
        // Set the parent of the image to the empty GameObject
        newImage.transform.parent = PlacedSymbols[Counter].transform;
        Counter++;
    }
    public void PlaceSymbol5()
    {
        GameObject newImage = Instantiate(Symbols[5], PlacedSymbols[Counter].transform.position, Quaternion.identity);
        // Set the parent of the image to the empty GameObject
        newImage.transform.parent = PlacedSymbols[Counter].transform;
        Counter++;
    }
}
