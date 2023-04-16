using System.Diagnostics;
using lab_0.Services;

namespace lab_0.Entities;

internal class SelectionSort : ISorting
{
    private List<double> _array = new List<double>();
    private Stopwatch _stopwatch = new Stopwatch();
    private int _counter = 0;

    public SelectionSort(List<double> Array)
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
        
        int minJ; 
        double temp;
        for (int i = 0; i < _array.Count; i++) 
        {
            minJ = i;  
            for (int j = i; j < _array.Count; j++) 
            {
                if (_array[j] < _array[minJ])  
                {
                    minJ = j; 
                }
            }
            if (_array[minJ] == _array[i]) 
                continue;
           
            temp = _array[i]; 
            _array[i] = _array[minJ];
            _array[minJ] = temp;
        }
        
        _stopwatch.Stop();
        
        Console.WriteLine("\tSorted array by selection sort:\n");
        
        foreach (var number in _array)
        {
            _counter++;
            Console.WriteLine($"{_counter}{")"}   {number.ToString("F" + 4)}");
        }

        _counter = 0;
        
        Console.WriteLine($"{"\nSorting asymptotics:"} {_stopwatch.ElapsedMilliseconds} {"milliseconds"}");
    }
}