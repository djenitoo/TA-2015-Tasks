namespace PrintStatistics
{
    using System;

    class StatisticPrinter {

        public void PrintStatistics(double[] arr, int numberOfElementsToWorkWith)
        {
            double maximalElement = arr[0], minimalElement = arr[0], sumOfArray = 0;

            for (int i = 0; i < numberOfElementsToWorkWith; i++)
            {
                if (arr[i] > maximalElement)
                {
                    maximalElement = arr[i];
                }
                if (arr[i] < minimalElement)
                {
                    minimalElement = arr[i];
                }

                sumOfArray += arr[i];
            }

            this.PrintMax(max);
            this.PrintMin(max);

            double averageOfElements = sumOfArray / numberOfElementsToWorkWith;

            PrintAvg(averageOfElements);
        }

        private void PrintMax(double value)
        {
            Console.WriteLine('Max value is {0}', value);
        }

        private void PrintMin(double value)
        {
            Console.WriteLine('Min value is {0}', value);
        }

        private void PrintAverage(double value)
        {
            Console.WriteLine('Average value is {0}', value);
        }
    }
}
