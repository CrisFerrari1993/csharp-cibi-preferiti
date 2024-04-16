namespace csharp_cibi_preferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] favouriteFoods = { "sushi", "pizza", "pasta al regu", "paella", "pizzoccheri", "cheesecake" };
            Console.WriteLine(favouriteFoods.Length);
            Array.Sort(favouriteFoods);
            Console.WriteLine(favouriteFoods);
        }
    }
}
