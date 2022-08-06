internal class Variables
{
    private static void Main(string[] args)
    {
        object price = 2.99;
        object name = "Linda";
        Console.WriteLine($"{name} bought a sandwhich for ${price}.");

        // int length1 = name.Length; //gives a compile error!
        int length2 = ((string)name).Length;
        Console.WriteLine($"{name} has {length2} characters.");
    }
}