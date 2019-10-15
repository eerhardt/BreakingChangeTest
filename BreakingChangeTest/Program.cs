using ClassLibrary1;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using System;

namespace BreakingChangeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Class1();
            var c2 = new Class2<RegressionPredictionTransformer<LinearRegressionModelParameters>, LinearRegressionModelParameters>();

            StaticMethods.TakeOneIn(c1);
            StaticMethods.TakeOneIn(c2);

            StaticMethods.TakeGenericOneIn(c1);
            StaticMethods.TakeGenericOneIn(c2);

            var r1 = StaticMethods.ReturnOne();
            var r2 = StaticMethods.ReturnGenericOne<RegressionPredictionTransformer<LinearRegressionModelParameters>, LinearRegressionModelParameters>();

            Console.WriteLine("Hello World!");
        }
    }
}
