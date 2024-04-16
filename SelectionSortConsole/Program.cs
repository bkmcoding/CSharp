Console.WriteLine("Please enter 5 numbers (one at a time)");
int num;
List<int> unorderedList = new List<int>();
for (int i = 0; i < 5; i++)
{
    num = Convert.ToInt32(Console.ReadLine());
    unorderedList.Add(num);
}
Console.WriteLine("Unordered List: " + "[{0}]", string.Join(", ", unorderedList));

SelectionSort(unorderedList);

void SelectionSort(List<int> ul)
{
    List<int> sortedList = new List<int>();
    while (ul.Count != 0)
    {
        int lowNum = ul[0];
        for (int i = 0; i < ul.Count; i++)
        {
            if (ul[i] < lowNum)
            {
                lowNum = ul[i];
            }
        }
        ul.Remove(lowNum);
        sortedList.Add(lowNum);
    }
    Console.WriteLine("Unordered List: " + "[{0}]", string.Join(", ", sortedList));
}