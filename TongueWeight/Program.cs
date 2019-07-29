using System;

namespace TongueWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            RunProgram();
        }

        private static void RunProgram()
        {
            double trailerWeight = GetWeightFromUser("trailer");

            double cargoWeight = GetWeightFromUser("cargo");

            double totalWeight = GetTotalWeight(trailerWeight, cargoWeight);
        
            double minTongueWeight = GetMinTongueWeight(totalWeight);

            double maxTongueWeight = GetMaxTongueWeight(totalWeight);

            PrintMinAndMaxTongueWeight(minTongueWeight, maxTongueWeight);
        }

        private static void PrintMinAndMaxTongueWeight(double minTongueWeight, double maxTongueWeight)
        {
            Console.WriteLine($"The minimum tongue weight is {minTongueWeight} lbs.");

            Console.WriteLine($"The maximum tongue weight is {maxTongueWeight} lbs.");
        }

        private static double GetMinTongueWeight(double totalWeight)
        {
            double minTongueWeight = totalWeight*.09;
            return minTongueWeight;
        }

        private static double GetMaxTongueWeight(double totalWeight)
        {
            double maxTongueWeight = totalWeight*.15;
            return maxTongueWeight;
        }

         private static double GetTotalWeight(double trailerWeight, double cargoWeight)
        {
            return trailerWeight + cargoWeight;
        }

        private static double GetWeightFromUser(string weightType)
        {
            Console.Write($"Please enter the {weightType} weight (double): ");

            double weight = Convert.ToDouble(Console.ReadLine());

            return weight;
        }

       
    }
}
