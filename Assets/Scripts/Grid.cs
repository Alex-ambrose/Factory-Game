using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Grid
{
    private int width;
    private int height;
    private float cellSize;
    private int[,] gridArray;
    

    public Grid(int width, int height, float cellSize)
    {
        this.width = width;
        this.height = height;
        this.cellSize = cellSize;
        gridArray = new int[width, height];

        for(int x = 0; x < gridArray.GetLength(0); x++)
        {
            for(int y = 0; y < gridArray.GetLength(1); y++)
            {
                var position = GetWorldPosition(x, y);
                VisualizeCell(position);
            }
        }
    }   

    public void VisualizeCell(Vector3 position)
    {
        GameObject gameObject = new GameObject($"Grid cell: {position.x},{position.y}");
        gameObject.transform.localPosition = position;
        gameObject.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        gameObject.transform.localRotation = Quaternion.Euler(new Vector3(90, 0, 0));

        TextMesh textMesh = gameObject.AddComponent<TextMesh>();
        textMesh.text = $"{position.x},{position.y}";
        textMesh.alignment = TextAlignment.Center;
        textMesh.anchor = TextAnchor.MiddleCenter;
        textMesh.fontSize = 50;

    }

    private Vector3 GetWorldPosition(int x, int y)
    {
        return new Vector3(x, y) * cellSize;
    }
}
