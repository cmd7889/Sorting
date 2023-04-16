using System.Diagnostics;
using lab_0.Services;

namespace lab_0.Entities;

internal class BubbleSort : ISorting
{
    private List<double> _array = new List<double>();
    private Stopwatch _stopwatch = new Stopwatch();
    private int _counter = 0;

    public BubbleSort(List<double> Array)
    {
        _array = Array;
    }
    
    void ISorting.Sorting()
    {
        Console.WriteLine("\n\tThe original array:\n");
        
        foreach (var number in _array)
        {
            _counter++;
            Console.WriteLine($"{_counter}{")"}   {number.ToString("F" + 4)}");
        }

        _counter = 0;
        Console.WriteLine();
        
        _stopwatch.Start();
        
        double item = 0;
        
        for (int i = 0; i < _array.Count; i++)

        for (int j = 0; j < _array.Count - 1; j++)

            if (_array[j] > _array[j + 1])
            {
                item = _array[j];
                _array[j] = _array[j + 1];
                _array[j + 1] = item;
            }
        
        _stopwatch.Stop();
        
        Console.WriteLine("\tSorted array by bubble method:\n");
        
        foreach (var number in _array)
        {
            _counter++;
            Console.WriteLine($"{_counter}{")"}   {number.ToString("F" + 4)}");
        }

        _counter = 0;

        Console.WriteLine($"{"\nSorting asymptotics:"} {_stopwatch.ElapsedMilliseconds} {"milliseconds"}");
    }
}