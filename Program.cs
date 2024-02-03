namespace secondHomework
{
    /*internal class MainTask
    {
        static void Main(string[] args)
        {

            //  ОСНОВНОЕ ЗАДАНИЕ

            int[] seats = SeatsGenerator(10);

            Console.WriteLine("\n\tДобро пожаловать в нашу авиакомпанию!\n\n");
            Console.Write("Выберите салон:\n1. Для курящих\n2. Для некурящих\n3. Выход\n-> ");
            int userChoice = int.Parse(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    {
                        for (int i = 0; i < seats.Length / 2; i++)
                        {
                            if (seats[i] == 0)
                            {
                                seats[i] = 1;
                                Console.WriteLine($"\nВаш посадочный талон:\nМесто: {i + 1}\nСалон: для курящих");
                                return;
                            }
                        }
                        Console.Write("\nСвободных мест не найдено.\nЖелаете ли занять место в салоне для некурящих?\n1. Да\n2. Нет\n-> ");
                        userChoice = int.Parse(Console.ReadLine());
                        if (userChoice == 1)
                        {
                            goto case 2;
                        }
                        else
                        {
                            Console.WriteLine("\nСледующий полет состоится через 3 часа!");
                        }
                    }
                    break;
                case 2:
                    {
                        for (int i = seats.Length / 2; i < seats.Length; i++)
                        {
                            if (seats[i] == 0)
                            {
                                seats[i] = 1;
                                Console.WriteLine($"\nВаш посадочный талон:\nМесто #{i + 1}\nСалон: для некурящих");
                                return;
                            }
                        }
                        break;
                    }
                case 3:
                    return;
                default:
                    Console.WriteLine("\nНеверный ввод.");
                    return;
            }
        }
        static int[] SeatsGenerator(int countOfPlaces)
        {
            int[] array = new int[countOfPlaces];

            Random random = new Random();

            for (int i = 0; i < countOfPlaces; i++)
            {
                array[i] = random.Next(0, 2);
            }

            return array;
        }

    }*/

    /*internal class AdditionalTask2
    {
        static void Main()
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Число {number} в степени 10: {DegreeConversion(ref number, 10)}");
        }

        static int DegreeConversion(ref int number, int degree)
        {
            int originalNumber = number;
            for (int i = 1; i < degree; i++)
            {
                number *= originalNumber;
            }
            return number;
        }
    }*/

    /*internal class AdditionalTask3
    {
        static void Main()
        {
            int[,] matrix = {
                { 0, 1, 2, -1 },
                { 1, 2, 3, 4 },
                { 2, 3, 4, 5 },
            };

            DeleteColumn(ref matrix, GetSmallestElementIndex(matrix));
            Console.WriteLine();
        }

        static int GetSmallestElementIndex(int[,] matrix)
        {
            int smallestElement = matrix[0, 0];
            int smallestElementIndex = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < smallestElement)
                    {
                        smallestElement = matrix[i, j];
                        smallestElementIndex = j;
                    }
                }
            }
            return smallestElementIndex;
        }

        static int[,] DeleteColumn(ref int[,] matrix, int smallestElementIndex)
        {
            int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1) - 1];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0, k = 0; j < matrix.GetLength(1); j++)
                {
                    if (j != smallestElementIndex)
                    {
                        newMatrix[i, k++] = matrix[i, j];
                    }
                }
            }
            matrix = newMatrix;
            return matrix;
        }
    }*/
}