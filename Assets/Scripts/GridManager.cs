using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public Grid grid = new Grid(20, 10, 1f);
    public GameObject PathPiece;
    void Start()
    {
        CreatePath();
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    void CreatePath()
    {
        for (int x = 0; x < grid.width; x++)
        {
            for (int y = 0; y < grid.height; y++)
            {
                GameObject PieceInstence = Instantiate(PathPiece);
                grid.AddToGrid(PieceInstence, x, y);
            }
        }
    }
}
