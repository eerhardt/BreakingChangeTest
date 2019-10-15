using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using System;

namespace ClassLibrary1
{
    public class Class1 : ITrainerEstimator<RegressionPredictionTransformer<LinearRegressionModelParameters>, LinearRegressionModelParameters>
    {
        public TrainerInfo Info => null;

        public RegressionPredictionTransformer<LinearRegressionModelParameters> Fit(IDataView input)
        {
            return null;
        }

        public SchemaShape GetOutputSchema(SchemaShape inputSchema)
        {
            return null;
        }
    }

    public class Class2<TTransformer, TModel> : ITrainerEstimator<TTransformer, TModel>
        where TTransformer : ISingleFeaturePredictionTransformer<TModel>
        where TModel : class
    {
        public TrainerInfo Info => null;

        public TTransformer Fit(IDataView input)
        {
            return default;
        }

        public SchemaShape GetOutputSchema(SchemaShape inputSchema)
        {
            return null;
        }
    }

    public static class StaticMethods
    {
        public static void TakeOneIn(ITrainerEstimator<RegressionPredictionTransformer<LinearRegressionModelParameters>, LinearRegressionModelParameters> trainerEstimator)
        {
            Console.WriteLine(nameof(TakeOneIn));
        }

        public static ITrainerEstimator<RegressionPredictionTransformer<LinearRegressionModelParameters>, LinearRegressionModelParameters>  ReturnOne()
        {
            Console.WriteLine(nameof(ReturnOne));
            return null;
        }

        public static void TakeGenericOneIn<TTransformer, TModel>(ITrainerEstimator<TTransformer, TModel> trainerEstimator)
            where TTransformer : ISingleFeaturePredictionTransformer<TModel>
            where TModel : class
        {
            Console.WriteLine(nameof(TakeGenericOneIn));
        }

        public static ITrainerEstimator<TTransformer, TModel> ReturnGenericOne<TTransformer, TModel>()
            where TTransformer : ISingleFeaturePredictionTransformer<TModel>
            where TModel : class
        {
            Console.WriteLine(nameof(ReturnGenericOne));
            return null;
        }
    }
}
