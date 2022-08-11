using System;

public class Grid<T>
{
    private float _width;
    private float _height;
    private int _columns;
    private int _rows;
    private T[,] _cells;

    public Grid(float width, float height, int columns, int rows, Func<T> createGridObject)
    {
        _width = width;
        _height = height;
        _columns = columns;
        _rows = rows;

        _cells = new T[columns, rows];

        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                _cells[i, j] = createGridObject();
            }
        }
    }
}
