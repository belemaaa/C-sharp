using System.ComponentModel;
using System.Runtime.InteropServices;

namespace CSHARPTUTORIAL;

public class QuizApp
{
    public static void Quiz()
    {
        string[,] data = new string[10, 6];

        // question 1
        data[0, 0] = "What technology is used in self-driving cars for navigation?";
        data[0, 1] = "Radar";
        data[0, 2] = "Sonar";
        data[0, 3] = "Lidar";
        data[0, 4] = "Infrared sensors";
        data[0, 5] = "C";

        // question 2
        data[1, 0] = "What does IoT stand for?";
        data[1, 1] = "Internet of Things";
        data[1, 2] = "Institute of Technology";
        data[1, 3] = "Input-Output Transfer";
        data[1, 4] = "International Online Trading";
        data[1, 5] = "A";

        // question 3
        data[2, 0] = "Which programming language is commonly used for developing artificial intelligence applications?";
        data[2, 1] = "Python";
        data[2, 2] = "Java";
        data[2, 3] = "C++";
        data[2, 4] = "Ruby";
        data[2, 5] = "A";

        // question 4
        data[3, 0] = "What is blockchain technology primarily known for?";
        data[3, 1] = "Online gaming";
        data[3, 2] = "Cryptocurrency transactions";
        data[3, 3] = "Virtual reality simulations";
        data[3, 4] = "Generic engineering";
        data[3, 5] = "B";

        // question 5
        data[4, 0] = "In quantum computing, what is a qubit?";
        data[4, 1] = "A classical bit";
        data[4, 2] = "A quantum bit";
        data[4, 3] = "A binary bit";
        data[4, 4] = "A computer memory unit";
        data[4, 5] = "B";

        // question 6
        data[5, 0] = "What is CRISPR-Cas9 used for?";
        data[5, 1] = "VR design";
        data[5, 2] = "Cryptography";
        data[5, 3] = "Gene editing";
        data[5, 4] = "Climate modeling";
        data[5, 5] = "C";

        // question 7
        data[6, 0] = "Which technology enables wireless communication between devices in close proximity?";
        data[6, 1] = "Bluetooth";
        data[6, 2] = "Infrared";
        data[6, 3] = "Wi-Fi";
        data[6, 4] = "Ethernet";
        data[6, 5] = "A";

        // question 8
        data[7, 0] = "What is 3D printing also known as?";
        data[7, 1] = "Stereolithography";
        data[7, 2] = "Tri-dimensional modeling";
        data[7, 3] = "Holographic replication";
        data[7, 4] = "Solid-state fabrication";
        data[7, 5] = "A";

        // question 9
        data[8, 0] = "What is the primary function of a neural network in machine learning?";
        data[8, 1] = "Sorting data alphabetically";
        data[8, 2] = " Mimicking the human brain for pattern recognition";
        data[8, 3] = "Calculating mathematical constants";
        data[8, 4] = " Translating languages";
        data[8, 5] = "B";

        // question 10
        data[9, 0] = "What is the capital city of Australia?";
        data[9, 1] = "Sydney";
        data[9, 2] = " Melbourne";
        data[9, 3] = "Canberra";
        data[9, 4] = " Brisbane";
        data[9, 5] = "C";


        // application
        ShuffleQuestions(data);

        Console.WriteLine("Input your name: ");
        string? name = Console.ReadLine();

    start:
        Console.WriteLine($"\nWelcome {name}!");
        Console.WriteLine("You are going to be playing a simple quiz game today");
        Console.WriteLine("Instruction: Input the number of the option you wish to pick.");

    begin:
        Console.WriteLine("\nDo you wish to begin?");
        string start = Console.ReadLine();

        if (!(string.Equals(start, "no", StringComparison.OrdinalIgnoreCase) || string.Equals(start, "yes", StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine("Invalid input");
            goto begin;
        }
        else if (string.Equals(start, "no", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Your session has ended");
            goto start;
        }
        else
        {
            int total_score = 0;

            for (int i = 0; i < data.GetLength(0); i++)
            {
            startQuiz:
                Console.Write($"\nQuestion {i + 1} - ");
                Console.WriteLine(data[i, 0]);
                Console.WriteLine($"a. {data[i, 1]}");
                Console.WriteLine($"b. {data[i, 2]}");
                Console.WriteLine($"c. {data[i, 3]}");
                Console.WriteLine($"d. {data[i, 4]}");

                string? input = Console.ReadLine().ToLower();

                // convert input string to char
                char ch = input[0];

                if ((ch >= 'a' && ch <= 'd') || (ch >= 'A' && ch <= 'D'))
                {
                    string correctAnswer = data[i, 5].ToLower();

                    // convert correctAnswer string to char
                    char chAnswer = correctAnswer[0];

                    if (ch == chAnswer)
                    {
                        Console.WriteLine("Correct.");
                        total_score += 1;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect.");
                        Console.WriteLine($"Correct answer: {data[i, 5]}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, please input a valid letter.");
                    goto startQuiz;
                }

            }

            Console.WriteLine($"Welldone! \nYour total score is {total_score}/10");
        }

    }

    public static void ShuffleQuestions(string[,] data)
    {
        Random random = new Random();
        int numOfRows = data.GetLength(0);

        for (int i = numOfRows - 1; i > 0; i--)
        {
            int j = random.Next(0, i + 1);

            // swap questions after each rerun
            for (int k = 0; k < data.GetLength(1); k++)
            {
                string temp = data[i, k];
                data[i, k] = data[j, k];
                data[j, k] = temp;
            }
        }
    }
}