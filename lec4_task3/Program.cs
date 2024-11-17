namespace lec4_task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this program to reverse array ");

            int[] arr = new int[10] {1,2,3,4,5,6,7,8,9,10 };
            //int[] newArr = new int[10];
            print_reverse(arr);
        }

        static void print_reverse(int[] arr1 ) {
            int i, temp;
             
            Console.WriteLine("this is array :  ");
            for ( i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            int j = i - 1;
            Console.WriteLine("\n  \n the new array is :  ");
            for ( i = 0; i <j ; i++)
            {
                temp = arr1[i];
                arr1[i] = arr1[j];
                arr1[j] = temp;
                j--;
              
                
            }


            Console.WriteLine("this is array :  ");
            for ( i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }


        }
    }
}
