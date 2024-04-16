using System.Collections.Concurrent;
using System.Runtime;
using Microsoft.VisualBasic;

Console.WriteLine("Please enter 5 numbers (one at a time)");
int num;
int[] unorderedList = new int[5];
for (int i = 0; i < 5; i++)
{
    num = Convert.ToInt32(Console.ReadLine());
    unorderedList[i] = num;
}
Console.WriteLine("Unordered List: " + "[{0}]", string.Join(", ", unorderedList));

Quicksort(0, unorderedList.Length - 1, unorderedList);

void Quicksort(int lo, int hi, int[] a)
{
    if (lo >= 0 && hi >= 0 && lo < hi)
    {
        int p = Partition(lo, hi, a);
        Quicksort(lo, p, a);
        Quicksort(p + 1, hi, a);
        Console.WriteLine("Unordered List: " + "[{0}]", string.Join(", ", a));
    }

}

int Partition(int lo, int hi, int[] a)
{
    int pivot = a[lo];
    int i = lo - 1;
    int j = hi + 1;

    while (true)
    {
        do
        {
            i++;
        } 
        while (a[i] < pivot);

        do
        {
            j--;
        }
        while (a[j] > pivot);

        if (i >= j)
        {
            return j;
        }

        (a[i], a[j]) = (a[j], a[i]);
    }

}