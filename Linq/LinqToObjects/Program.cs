namespace LinqToObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Filters (Where and TypeOf)

            //Filters.LinqWhere();

            //Filters.LinqOfType();

            #endregion

            #region Projection Operations (Select, SelectMany, Zip)

            //ProjectionOperations.SelectOperator();

            //ProjectionOperations.SelectManyOperator();

            //ProjectionOperations.ZipOperator();

            #endregion

            #region Set Operations (Distinct, DistinctBy, Except, ExceptBy)

            //SetOperations.DistinctOperator();

            //SetOperations.DistinctByOperator();

            //SetOperations.ExceptOperator();

            SetOperations.ExceptByOperator();

            #endregion
        }
    }
}