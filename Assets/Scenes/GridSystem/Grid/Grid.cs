using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid
{
    private float _width;
    private float _height;
    private int _columns;
    private int _rows;
    private int[,] _cells;

    public Grid(float width, float height, int columns, int rows)
    {
        _width = width;
        _height = height;
        _columns = columns;
        _rows = rows;

        _cells = new int[columns, rows];

        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {

            }
        }
    }
}
