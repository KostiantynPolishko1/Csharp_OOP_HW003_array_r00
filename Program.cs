namespace C__OOP_HW003_array_r00
{
    /*internal class Program1 //1D array wit custom size
    {
        static void Main(string[] args)
        {
            int length;
            bool flag;

            do
            {
                Console.Write("enter size arr -> ");
                flag = int.TryParse(Console.ReadLine(), out length);
                if (!flag)
                {
                    Console.Write("\tERROR\n");
                    continue;
                }
                else if (length == 0)
                {
                    Console.Write($"\tERROR! size = {length}\n");
                    flag = false;
                }

            } while (!flag);

            length = Math.Abs(length);
            Random rand = new Random();
            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                arr[i] = rand.Next(0, 11);
            }

            for (int i = 0; i < length; i++)
            {
                Console.Write($"{arr[i]} | ");
            }
        }
    }*/

    /*internal class Program2 //1D array with custom size height x width and chars that are not repeated
    {
        static void Main(string[] args)
        {
            int length;
            bool flag;
            const int START = 33, END = 127;

            do
            {
                Console.Write("enter size arr -> ");
                flag = int.TryParse(Console.ReadLine(), out length);
                if (!flag)
                {
                    Console.Write("\tERROR!\n");
                    continue;
                }
                else if (length > END - START)
                {
                    Console.Write("\tERROR! size out of range\n");
                    flag = false;
                }
                else if (length == 0)
                {
                    Console.Write($"\tERROR! size = {length}\n");
                    flag = false;
                }

            } while (!flag);

            length = Math.Abs(length);
            Random rand = new Random();
            char[] arr = new char[length];

            for (int i = 0; i < length;)
            {
                flag = false;
                char temp = (char)rand.Next(START, END);

                for (int j = 0; j < i; j++)
                {
                    if (temp == arr[j])
                        flag = true;
                }
                if (flag)
                    continue;
                arr[i] = temp;
                i++;
            }

            for (int i = 0; i < length; i++)
            {
                Console.Write($"{arr[i]} | ");
                if (i % 9 == 0 && i != 0)
                    Console.WriteLine();
            }
        }
    }*/

    internal class Program3 //creation 1-2-3D custom arrays in RunTime
    {
        static void Main(string[] args)
        {
            int numberRang;
            const int MIN = 33, MAX = 127;
            const int MAX_RANG = 3;
            bool flag;

            do
            {
                Console.Write("enter N rang -> ");
                flag = int.TryParse(Console.ReadLine(), out numberRang);
                if (!flag)
                {
                    Console.Write("\tERROR\n");
                    continue;
                }
                else if (numberRang == 0 || numberRang > MAX_RANG)
                {
                    Console.Write($"\tERROR! rang = {numberRang} is out max {MAX_RANG}\n");
                    flag = false;
                }

            } while (!flag);
            numberRang = Math.Abs(numberRang);

            int[] size = new int[MAX_RANG];

            for (int i = 0; i < numberRang; i++)
            {
                do
                {
                    Console.Write($"enter size rang {i + 1} -> ");
                    flag = int.TryParse(Console.ReadLine(), out size[i]);
                    if (!flag)
                    {
                        Console.Write("\tERROR\n");
                        continue;
                    }
                    else if (size[i] == 0)
                    {
                        Console.Write($"\tERROR! rang {i + 1} has size = {size[i]}\n");
                        flag = false;
                    }

                } while (!flag);
                size[i] = Math.Abs(size[i]);
            }
            Console.Clear();

            int[] arr1 = numberRang == 1 ? new int[size[0]] : System.Array.Empty<int>();
            int[,] arr2 = numberRang == 2 ? new int[size[0], size[1]] : new int[0, 0];
            int[,,] arr3 = numberRang == 3 ? new int[size[0], size[1], size[2]]: new int[0, 0, 0];

            Random random = new Random();

            //fill data          
            for (int i = 0; i < size[0]; i++)
            {
                if(size[1] != 0)
                {
                    for(int j = 0;j < size[1]; j++)
                    {
                        if(size[2] != 0)
                        {
                            for (int k = 0; k < size[2]; k++)
                            {
                                arr3[i, j, k] = random.Next(MIN, MAX);
                            }
                            continue;
                        }
                        arr2[i, j] = random.Next(MIN, MAX);
                    }
                    continue;
                }
                arr1[i] = random.Next(MIN, MAX);
            }
            
            //show data
            Console.Write($"\nmatrix in {numberRang} rang\n");
            for (int i = 0; i < numberRang; i++)
            {
                Console.Write($"rang {i + 1} = size {size[i]}\n");
            }
            Console.WriteLine();

            for (int i = 0; i < size[0]; i++)
            {
                if (size[1] != 0)
                {
                    for (int j = 0; j < size[1]; j++)
                    {
                        if (size[2] != 0)
                        {
                            for (int k = 0; k < size[2]; k++)
                            {
                                Console.Write($" | {arr3[i, j, k]}");
                            }
                            Console.Write("\n");
                            continue;
                        }
                        Console.Write($" | {arr2[i, j]}");
                    }
                    Console.Write("\n");
                    continue;
                }
                Console.Write($" | {arr1[i]}");
            }
        }
    }
}