using System;
using System.Collections.Generic;
using System.Text;

namespace Line_Comparison.Line_Comparison
{
    class length

        namespace LineComparisonComputation
    {
        class LineComparison
        {
            public void length()
            {
                double pointX1;
                double pointY1;
                double pointX2;
                double pointY2;
                double distance;

                Console.WriteLine("Enter the first co-ordinate");
                pointX1 = Convert.ToDouble(Console.ReadLine());
                pointY1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the second co-ordinate");
                pointX2 = Convert.ToDouble(Console.ReadLine());
                pointY2 = Convert.ToDouble(Console.ReadLine());

                distance = Math.Sqrt((pointX2 - pointX1) * (pointX2 - pointX1) + (pointY2 - pointY1) * (pointY2 - pointY2));
                Console.WriteLine("Length of a line:" + distance);
            }
        }










    {
    }
}
