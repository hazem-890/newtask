List<int> numbers = [];
int inputnumber;
bool alwayson = true;
string input = " ";
while (alwayson)
{
    Console.WriteLine(" p - Print numbers  A - Add numbers  H - Display mean of the numbers S - Display the smallest number  L - Display the largest number     F - Find a number    C - Clear the whole list   Q - Quit   ");
    input = Console.ReadLine().ToUpper();

    if (input != "A" && input != "P" && input != "H" && input != "S" && input != "L" && input != "F" && input != "C" && input != "Q")
    {
        Console.WriteLine("not correct");
    }

    if (input == "A")
    {
        Console.WriteLine("Enter The Number to add: ");
        inputnumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(inputnumber + " Add");
        numbers.Add(inputnumber);

    }

    else if (input == "P")
        if (numbers.Count == 0)
        {
            Console.WriteLine(" the list is empty");
        }
        else
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
    else if (input == "Q")
        alwayson = false;



    else if (input == "M")

        if (numbers.Count == 0)
        {
            Console.WriteLine(" the list is empty");
        }
        else
        {
            double mean = 0;
            for (int i = 0; i < numbers.Count; i++)
            {

                mean += numbers[i];

            }

            Double result = mean / numbers.Count;
            Console.WriteLine(result);
        }

    else if (input == "S")

        if (numbers.Count == 0)
        {
            Console.WriteLine(" the list is empty");
        }
        else
        {
            int smallest = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];

                }
            }
            Console.WriteLine($"The smallest number is" + smallest);
        }
    else if (input == "L")
        if (numbers.Count == 0)
        {
            Console.WriteLine(" the list is empty");
        }
        else
        {
            int largest = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];

                }

            }

            Console.WriteLine($"The smallest number is" + largest);


        }

    else if (input == "C")
    {
        numbers.Clear();
        Console.WriteLine("The list has been cleared.");

    }

    // find حاول معرفتش


    //else if (input == "F")
    //    if (numbers.Count == 0)
    //    {
    //        Console.WriteLine(" the list is empty");
    //    }
    //    else
    //    {
    //        Console.Write("Enter a number to find: ");
    //        int find = Convert.ToInt32(Console.ReadLine());
    //        List<int> numindex = [];


    //        for (int i = 0; i < numbers.Count; i++)
    //        { 
    //            if (numbers[i] == find)

    //            {
    //                numindex.Add(i);

    //            }
    //        }




    //        else
    //            {
    //                Console.Write($"cant found ");
    //            }
    //    }
}

