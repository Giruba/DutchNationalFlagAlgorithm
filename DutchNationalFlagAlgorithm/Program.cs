using System;

namespace DutchNationalFlagAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dutch National Flag Algorithm!");
            Console.WriteLine("-----------------------------");

            try
            {
                int[] array = GetArrayFromInput();
                array = GetSortedArray(array);
                Console.WriteLine("The Sorted array------");
                for (int i = 0; i < array.Length; i++) {
                    Console.Write(array[i]+ " ");
                }
                Console.WriteLine();
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }


            Console.ReadLine();
        }

        private static int[] GetArrayFromInput() {
            int[] array = null;
            Console.WriteLine("Enter the number of elements in the input array");

            try
            {
                int noElements = int.Parse(Console.ReadLine());
                array = new int[noElements];
                Console.WriteLine("Enter the elements separated by space");
                String[] elements = Console.ReadLine().Split(' ');
                for(int index = 0; index < noElements; index++)
                {
                    array[index] = int.Parse(elements[index]);
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }

            return array;
        }

        private static int[] GetSortedArray(int[] array) {

            int low = 0;
            int mid = 0;
            int high = array.Length - 1;

            while (mid < high) {
                switch (array[mid]) {

                    case 0:
                        int temp = array[low];
                        array[low] = array[mid];
                        array[mid] = temp;
                        low++;
                        mid++;
                        break;
                    case 1:
                        mid++;
                        break;
                    case 2:
                        int tempo = array[mid];
                        array[mid] = array[high];
                        array[high] = tempo;
                        mid++;
                        high--;
                        break;
                }
            }

            return array;
        }
    }
}
