static void Main(string[] args)
{
    Console.WriteLine("Number of elements:");
    int size = int.Parse(Console.ReadLine());
    int[] pins = new int[size];
    Console.WriteLine("Input " + size + " elements:");
    for (int i = 0; i < size; i++)
    {
        pins[i] = Convert.ToInt32(Console.ReadLine());
    }
    for (int i = 0; i < size; i++)
    {
        Console.Write(pins[i] + " ");
    }
    Console.ReadKey();

}
