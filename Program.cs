using  lab_0.Entities;
using lab_0.Exceptions;

namespace lab_0;

    class Program
    {
        public static int EnterLength()
        {
            Console.WriteLine();
            Console.Write("Enter the length of the array: ");
            
            string Length = Console.ReadLine();

            int length = int.Parse(Length);

            if (length < 2) throw new MinValueNotInValidRangeException("Минимальная длина не может быть меньше двух");
            
            return length;
        }
        
        static void Main()
        {
            Generation a1 = new Generation(EnterLength());
            a1.SetSorting(new BubbleSort(a1.Array));
            a1.Sorting();
        
            // Generation a2 = new Generation(EnterLength());
            // a2.SetSorting(new InsertionSort(a2.Array));
            // a2.Sorting();
            //
            // Generation a3 = new Generation(EnterLength());
            // a3.SetSorting(new SelectionSort(a3.Array));
            // a3.Sorting();
            //
            // Generation a4 = new Generation(EnterLength());
            // a4.SetSorting(new MergeSort(a4.Array));
            // a4.Sorting();
            //
            // Generation a5 = new Generation(EnterLength());
            // a5.SetSorting(new HeapSort(a5.Array));
            // a5.Sorting();
        }
    }