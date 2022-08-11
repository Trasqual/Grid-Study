using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionGrid
{
    private float _width;
    private float _length;
    private float _height;

    private int _columns;
    private int _rows;
    private int _layers;

    private Vector3[,,] _positions;

    public PositionGrid(float width, float length, float height, int columns, int rows, int layers)
    {
        _width = width;
        _length = length;
        _height = height;
        _columns = columns;
        _rows = rows;
        _layers = layers;


    }
}
