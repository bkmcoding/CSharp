Console.WriteLine("Please enter 5 numbers (one at a time)");
int num;
int[] unorderedList = new int[5];
for (int i = 0; i < 5; i++)
{
    num = Convert.ToInt32(Console.ReadLine());
    unorderedList[i] = num;
}
Console.WriteLine("Unordered List: " + "[{0}]", string.Join(", ", unorderedList));

BubbleSort(unorderedList);
int[] BubbleSort(int[] ul)
{
    while (true)
    {
        bool swapped = false;
        int temp = 0;
        for (int i = 0; i < ul.Length - 1; i++)
        {
            if (ul[i] > ul[i + 1])
            {
                temp = ul[i + 1];
                ul[i + 1] = ul[i];
                ul[i] = temp;
                swapped = true;
            }
        }
        if (!swapped)
        {
            break;
        }
    }
    Console.WriteLine("Ordered List: " + "[{0}]", string.Join(", ", ul));

    return ul;
}