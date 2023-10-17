using Task18._10.Models;

namespace Task18._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListInt List = new ListInt(3);
            List[0] = 1;
            List[1] = 2;
            List[2] = 3;
            List.Add(4);
            List.AddRange(5, 6, 7);
            Console.WriteLine("List: " + List.ToString());
            Console.WriteLine("Sum: " + List.Sum());

            int numToRemove = 4;
            List.Remove(numToRemove);
            Console.WriteLine($"{numToRemove} silindi. Yeni list: " + List.ToString());

            int[] numsToRemove = { 2, 6 };
            List.RemoveRange(numsToRemove);
            Console.WriteLine(string.Join(", ", numsToRemove) + " silindi. Yeni list: " + List.ToString());

            int index = 3;
            Console.WriteLine($"Verilmish indexdeki eded {index}: {List[index]}");

            Console.WriteLine($"Contains 3: {List.Contains(3)}");
            Console.WriteLine($"Contains 12: {List.Contains(12)}");

        }
    }
}