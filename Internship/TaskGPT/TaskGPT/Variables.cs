using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TaskGPT
{
    class Variables
    {
        public void variAble()

        {
            var varVariable = 5;
            Console.WriteLine(varVariable);

            object objectVariable = "Object";
            Console.WriteLine(objectVariable);
            objectVariable = 20;
            Console.WriteLine(objectVariable);
            dynamic dynamicVariable = "Dynamic";
            Console.WriteLine(dynamicVariable);
            dynamicVariable = 20;

            Console.WriteLine(dynamicVariable);




        }
        public void tableGenerate()
        {
        rr:
            Console.WriteLine("Enter a number to generate its table");

            String input = Console.ReadLine();
            if (int.TryParse(input, out int nn))
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($" {nn} x {i + 1} = {nn * (i + 1)}");
                }
                int j = 0;
                while (j != 10)
                {
                    Console.WriteLine($"  {nn} x  {j + 1} = {nn * (j + 1)}");
                    j++;

                }
            }
            else
            {
                Console.WriteLine("invalid number");
                goto rr;
            }

        }
        public void quizTime()
        {
            Console.WriteLine("WELCOME TO THE quiz");
            Console.WriteLine("Answer the following question ");
            int score = 0;
            int questionNumber = 1;
            while (questionNumber <= 4)
            {
                Console.WriteLine($" Question number: {questionNumber}");
                String que = questions(questionNumber);
                String ans = answers(questionNumber);
                Console.WriteLine(que);
                Console.WriteLine("Your answer : ");
                String useranswer = Console.ReadLine();
                if (useranswer.Equals(answers(questionNumber)))
                {
                    Console.WriteLine("Correct Answer");
                    score++;
                }
                else
                {
                    Console.WriteLine("Wrong answer, the Correct answer is " + answers(questionNumber));
                }
                questionNumber++;
            }
            Console.WriteLine("Your score is " + score);

        }
        public static String questions(int q)

        {
            switch (q)
            {
                case 1:
                    return "what's 1+1";
                case 2:
                    return "What's 2+2";
                case 3:
                    return "What 3*3";
                case 4:
                    return "what 2+2*2";

                default: return "Must be wrong input";

            }

        }
        public static String answers(int q)
        {
            switch (q)
            {
                case 1:
                    return "2";
                case 2:
                    return "4";
                case 3:
                    return "9";
                case 4:
                    return "6";
                default: return "Something went wrong";



            }


        }
        public void stringComparison()
        {

            Console.WriteLine("Write your name ");
            String[] naaam = { "attiq", "ahmad", "Ali" };

            String inp = Console.ReadLine();

            for (int a = 0; a < naaam.Length; a++)
            {

                if (inp.Equals(naaam[a], StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Ok COmparison");
                    return;
                }
            }
            Console.WriteLine("Not okay");
        }
        public void cnic()
        {
            Console.WriteLine("Enter Valid CNIC");
            String cnic = Console.ReadLine();
            if (cnic.Length == 15)

            {
                string formattedInput = cnic.Substring(1, 5) + "-";
                Console.WriteLine(formattedInput);
            }
            else
            {
                Console.WriteLine("invalid !Enter 15 digits Number");
                cnic = Console.ReadLine();
            }




        }
        public void TwoDimensionArray()
        {
            Console.WriteLine("2 Dimension array");
            String[,] firstLastNAME = new string[3, 2]
            {
                { "a","b" },
                { "A","B" },
                { "1","2" }
            };
          

            for (int i = 0; i < firstLastNAME.GetLength(0); i++)
            {
                Console.WriteLine("lenghth "+ firstLastNAME.GetLength(0));
                for (int j = 0; j < firstLastNAME.GetLength(1); j++)
                {
                    Console.WriteLine("lenghth " + firstLastNAME.GetLength(1));
                    Console.Write(firstLastNAME[i, j]+"  ");
                }
                
                Console.WriteLine(firstLastNAME.Length);


            }







            String[] nasd = new string[] { "a", "b", "c", "d" };
            List<String> nam = new List<String>();
            for (int i = 0; i < nasd.Length; i++)
            {

                nam.Add(nasd[i]);
                Console.WriteLine(nam[i]);

            }







            String[,] names = new string[3, 2];
            names[0, 0] = "Imran";
            names[0, 1] = "khan";

            names[1, 0] = "Nawaz";
            names[1, 1] = "shreef";

            names[2, 0] = "Asif";
            names[2, 1] = "Zrdari";


            for (int i = 0; i < names.GetLength(0); i++)
            {
                for (int col = 0; col < names.GetLength(1); col++)
                {

                    Console.WriteLine(names[i, col] + " ");

                }

                Console.WriteLine("");
            }







        }

        

    }


}