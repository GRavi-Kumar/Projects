// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello User!");
int size;
int[] Array;
bool b;
do
{
    Console.WriteLine("Please Enter the Array Size");

    b = int.TryParse(Console.ReadLine(), out size);                 // Checking if array size is numerical

    if (b && size > 0)
    {
        Array = new int[size];
        for (int i = 0; i < size; i++)
        {
            bool c;
            int temp;
            do                                                         //Checking if array Element is numerical & Logging
            {
                Console.WriteLine("Please Enter the Array Element {0}", i + 1);
                c = int.TryParse(Console.ReadLine(), out temp);
                if (c)
                { Array[i] = temp; }
                else { Console.WriteLine("Invalid input Please Retry again\n"); }

            } while (c == false);
        }

        int l=(size%2);                                                     //If Array is Odd or Even
        if(l==1)            
        {
            Console.WriteLine("Median of Array is {0}",Array[size / 2]);    // Median of Odd Array
        }
        else 
        {
            float f= (Array[size / 2] + Array[(size / 2) - 1]);             //Median of Even Array
            float g = (f/ 2);
            Console.WriteLine("Median of Array is {0}", g);
        }
    }
    else
        Console.WriteLine("Invalid input Please Retry\n");

} while (b == false || size <= 0);
