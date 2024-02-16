namespace CSharpCompPracTest;

internal static class Program
{
    public static void Main(string[] args)
    {
        StreamReader vendorFile = new StreamReader(File.OpenRead("Vendor.csv"));
        StreamReader productFile = new StreamReader(File.OpenRead("products.csv"));
        List<string[]> vendorsList = [];
        List<string[]> productList = [];
        string table = "";
        while (!vendorFile.EndOfStream)
        {
            var line = vendorFile.ReadLine();
            var values = line?.Split(",");
            if (values != null) vendorsList.Add(values);
        }
        while (!productFile.EndOfStream)
        {
            var line = productFile.ReadLine();
            var values = line?.Split(",");
            if (values != null) productList.Add(values);
        }

        foreach (var product in vendorsList)
        {
            foreach (var item in product)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
        

        for (int i = 0; i < vendorsList.Count; i++)
        {
            for (int j = 0; j < vendorsList[i].Length; j++)
            {
                table += vendorsList[i][j] + " | ";
                if (j % 2 == 1)
                {
                    for (int k = 0; k < productList[i].Length - 1; k++)
                    {
                        table += productList[i][j + k] + " | ";
                    }

                    table += "\n";
                }
            }
        }
        Console.Write(table);
    }
}