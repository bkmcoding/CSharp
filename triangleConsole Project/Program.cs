static class TriangleProject
{
    static void Main(string[] args)
    {
        int triangleSize = 0;
        int triangleIteration = 0;
        Console.WriteLine("How large of a Triangle would you like?");
        while (true)
        {
            bool error = false;
            try
            {
                triangleSize = Convert.ToInt32(Console.ReadLine());
            } 
            catch (Exception)
            {
                Console.WriteLine("Please input a valid number");
                error = true;
            }
            if (!error)
            {
                break;
            }
        }
        Console.WriteLine("How much would you like the triangle to iterate by?");
        while (true)
        {
            bool error = false;
            try
            {
                triangleIteration = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please input a valid number");
                error = true;
            }
            if (!error)
            {
                break;
            }
        }
        createTriangle(triangleSize, triangleIteration);
    }

    static void createTriangle(int triangleSize, int triangleIteration)
    {
        string shape = "*";
        for (int i = triangleSize; i >= 0; i -= triangleIteration)
        {
            for (int j = i; j > 0; j--)
            {
                Console.Write(shape + " ");
            }
            Console.WriteLine();
        }
        for (int i = 0; i <= triangleSize; i += triangleIteration)
        {
            for (int j = i; j > 0; j--)
            {
                Console.Write(shape + " ");
            }
            Console.WriteLine();
        }
    }
}