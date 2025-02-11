using System.Collections;

namespace advoop2
{
    internal class Program
    {
        static void ReverseArrayList(ArrayList arrayList)
        {
      
            for (int i = 0, j = arrayList.Count - 1; i < j; i++, j--)
            {
                object temp = arrayList[i];
                arrayList[i] = arrayList[j];
                arrayList[j] = temp;
            }
        }
        static void Main(string[] args)
        {
            ArrayList numbers = new ArrayList { 1, 2, 3, 4, 5 };
            ReverseArrayList(numbers);
            Console.WriteLine("Reversed ArrayList: " + string.Join(", ", numbers.ToArray()));
        }
    }
}