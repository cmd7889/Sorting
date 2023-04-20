using System.Diagnostics;
using lab_0.Services;

namespace lab_0.Entities;

internal class InsertionSort : ISorting
{
    private List<double> _array = new List<double>();
    private Stopwatch _stopwatch = new Stopwatch();
    private int _counter = 0;

    public InsertionSort(List<double> Array)=> _array = Array;

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
        
        for (int i = 1; i < _array.Count; i++)

        for (int j = i; j > 0 && _array[j - 1] > _array[j]; j--)
        {
            item = _array[j - 1];
            _array[j - 1] = _array[j];
            _array[j] = item;
        }
        
        _stopwatch.Stop();
        
        Console.WriteLine("\tSorted array by insertion sort:\n");
        
        foreach (var number in _array)
        {
            _counter++;
            Console.WriteLine($"{_counter}{")"}   {number.ToString("F" + 4)}");
        }

        _counter = 0;
        
        Console.WriteLine($"{"\nSorting asymptotics:"} {_stopwatch.ElapsedMilliseconds} {"milliseconds"}");
    }
}