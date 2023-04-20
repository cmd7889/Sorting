using System.Diagnostics;
using lab_0.Services;

namespace lab_0.Entities;

internal class MergeSort : ISorting
{
    private List<double> _array = new List<double>();
    private Stopwatch _stopwatch = new Stopwatch();
    private int _counter = 0;

    public MergeSort(List<double> Array)=> _array = Array;

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
        
        int left = 0, right = _array.Count - 1;
        double item = 0;
        
        void merge(int left, int right)
        {

            if (right == left)
                return;
            if (right - left == 1)
            {
                if (_array[right] < _array[left])
                    item = _array[right];
                _array[right] = _array[left];
                _array[left] = item;
                    
                return;
            }

            int m = (right + left) / 2;
            merge(left, m);
            merge(m + 1, right);
            List<double> buf = new List<double>();
            int xl = left;
            int xr = m + 1;
            int cur = 0;
            while (right - left + 1 != cur)
            {
                if (xl > m)
                    buf[cur++] = _array[xr++];
                else if (xr > right)
                    buf[cur++] = _array[xl++];
                else if (_array[xl] > _array[xr])
                    buf[cur++] = _array[xr++];
                else buf[cur++] = _array[xl++];

            }

            for (int i = 0; i < cur; i++)
                _array[i + left] = buf[i];
        }
        
        _stopwatch.Stop();
        
        Console.WriteLine("\tSorted array by merge sort:\n");
        
        foreach (var number in _array)
        {
            _counter++;
            Console.WriteLine($"{_counter}{")"}   {number.ToString("F" + 4)}");
        }

        _counter = 0;
        
        Console.WriteLine($"{"\nSorting asymptotics:"} {_stopwatch.ElapsedMilliseconds} {"milliseconds"}");
    }
}