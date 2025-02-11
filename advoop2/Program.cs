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
        static List<int> GetEvenNumbers(List<int> list)
        {
            List<int> numbersList = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    numbersList.Add(list[i]);
                }
            }
            return numbersList;
        }
            static void Main(string[] args)
            {
            #region Q1
            ArrayList numbers = new ArrayList { 1, 2, 3, 4, 5 };
            ReverseArrayList(numbers);
            Console.WriteLine("Reversed ArrayList: " + string.Join(", ", numbers.ToArray()));
            #endregion
            #region Q2
            List<int> numbersList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> evenNumbers = GetEvenNumbers(numbersList);
            Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers)); 
            #endregion

        }
    }
    
}