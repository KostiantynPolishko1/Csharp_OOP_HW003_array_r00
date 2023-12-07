namespace C__OOP_HW003_array_r00
{
    internal class Program
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