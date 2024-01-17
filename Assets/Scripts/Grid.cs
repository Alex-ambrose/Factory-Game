using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid
{
    private int width;
    private int height;
    private int[,] gridArray;
    

    public Grid(int width, int height)
    {
        this.width = width;
        this.height = height;

        gridArray = new int[width, height];

        for(int x = 0; x < gridArray.GetLength(0); x++)
        {
            for(int y = 0; y < gridArray.GetLength(1); y++)
            {
                VisualizeCell(x, y);
            }
        }
    }   

    public void VisualizeCell(int x, int y)
    {
        GameObject gameObject = new GameObject($"Grid cell: {x},{y}");
        gameObject.transform.localPosition = new Vector3(x, 0, y);
        gameObject.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        gameObject.transform.localRotation = Quaternion.Euler(new Vector3(90, 0, 0));

        TextMesh textMesh = gameObject.AddComponent<TextMesh>();
        textMesh.text = $"{x},{y}";
        textMesh.alignment = TextAlignment.Center;
        textMesh.anchor = TextAnchor.MiddleCenter;
        textMesh.fontSize = 50;

    }
}
