using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SevenSegmentManager : MonoBehaviour
{
    public GameObject sevenSegmentPrefab; // Prefab der 7-Segment-Anzeige
    public int rows = 10;
    public int cols = 10;
    public float spacing = 1.5f; // Abstand zwischen den Anzeigen
    private SevenSegmentDisplay[,] displays;

    void Start()
    {
        displays = new SevenSegmentDisplay[rows, cols];
        InstantiateDisplays();
    }

    void InstantiateDisplays()
    {
        float startX = -(cols / 2f) * spacing;
        float startY = -(rows / 2f) * spacing;

        for (int y = 0; y < rows; y++) // Reihen steuern Y-Position
        {
            for (int x = 0; x < cols; x++) // Spalten steuern X-Position
            {
                Vector3 position = new Vector3(startX + x * spacing, startY - y * spacing, 0); // ACHTUNG: "-" bei Y
                GameObject displayObj = Instantiate(sevenSegmentPrefab, position, Quaternion.identity, transform);
                displays[y, x] = displayObj.GetComponent<SevenSegmentDisplay>();
            }
        }
    }


    public void SetNumberAt(int x, int y, int number)
    {
        if (x >= 0 && x < rows && y >= 0 && y < cols)
        {
            displays[x, y].SetNumber(number);
        }
    }
}