/*
 * Author: Matthew Tan
 * Course: COMP003A
 * Purpose: Assignment Week 5
 * 
*/
namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSeparator();
            PrintSeparator("\tTriangle Section");
            PrintSeparator();
            Console.Write("Enter a single character: ");
            char inputCharacter = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter a positive whole number: ");
            int size = Convert.ToInt32(Console.ReadLine());
            IsoscelesTriangleBuilder(inputCharacter, size);
            PrintSeparator();
            PrintSeparator("\tFavorite Characters Section");
            PrintSeparator();
            CharacterInfo("Spawn", 1992);
            CharacterInfo("Ted Mosby", 1978);
            CharacterInfo("Ultimate Warrior", 1959);
            CharacterInfo("Marvin the Martian", 1948);
            CharacterInfo("Himura Kenshin", 1849);
        } // main close

        static void PrintSeparator()
        {
            Console.WriteLine("".PadRight(50, '*'));
        }

        /// <summary>
        /// Step 4
        /// </summary>
        /// <param name="param"></param>
        static void PrintSeparator(string param)
        {
            Console.WriteLine(param);
        }

        /// <summary>
        /// Step 5
        /// </summary>
        /// <param name="inputCharacter"></param>
        /// <param name="size"></param>
        static void IsoscelesTriangleBuilder(char inputCharacter, int size)
        {
            string outputCharacters = "";
            for (int i = 0; i <= size; i++)
            {
                Console.WriteLine(outputCharacters);
                outputCharacters += inputCharacter;
            }
            for (int i = size - 1; i >= 1; i--)
            {
                outputCharacters = outputCharacters.Substring(0, i);
                Console.WriteLine(outputCharacters);
            }
        }

        /// <summary>
        /// Step 6
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        static int AgeCalculator(int year)
        {
            return DateTime.Now.Year - year;
        }

        /// <summary>
        /// Step 7
        /// </summary>
        /// <param name="name"></param>
        /// <param name="birthYear"></param>
        static void CharacterInfo(string name, int birthYear)
        {
            int calculatedAge = AgeCalculator(birthYear);
            Console.WriteLine($"{name} turns {calculatedAge} this year!");
        }

    }
}