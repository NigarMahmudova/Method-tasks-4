using System;

namespace Method_practice_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrayin uzunlugunu daxil edin...");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[length];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Element {i}: ");
                numbers[i]= Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array-e elave etmek istediyiniz ededi daxil edin...");
            int number = Convert.ToInt32(Console.ReadLine());

            MakeNewArray(ref numbers, ref number);
            Console.WriteLine("Yeni array-in elementleri...");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        /* Verilmiş int array-ə verilmiş int dəyəri əlavə edən metod.
         * Misalçün metodu çağırıb array elementimi və 5 dəyəri göndərsəm, 
         * arrayim dəyişilməli və arrayin içində əvəlki elementləri, əlavə olaraq son indexində isə 
         * 5 elementi olmalıdır və arrayin uzunluğu 1 vahid artmış olmalıdır.*/
        static void MakeNewArray( ref int[] numbers, ref int num)
        {
            int[] newArray = new int[numbers.Length+1];
            int j = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                newArray[j] = numbers[i];
                j++;
            }
            newArray[numbers.Length] = num;

            numbers = newArray;
        }

    }
}
