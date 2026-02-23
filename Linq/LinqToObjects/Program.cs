namespace LinqToObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            #region Filters (Where and TypeOf)

            //Filters.LinqWhere();

            //Filters.LinqOfType();

            #endregion

            #region Projection Operations (Select, SelectMany, Zip)

            //ProjectionOperations.SelectOperator();

            //ProjectionOperations.SelectManyOperator();

            //ProjectionOperations.ZipOperator();

            #endregion

            #region Set Operations (Distinct, DistinctBy, Except, ExceptBy, Intersect, IntersectBy, Union, UnionBy)

            //SetOperations.DistinctOperator();

            //SetOperations.DistinctByOperator();

            //SetOperations.ExceptOperator();

            //SetOperations.ExceptByOperator();

            //SetOperations.IntersectOperator();

            //SetOperations.IntersectByOperator();

            //SetOperations.UnionOperator();

            //SetOperations.UnionByOperator();

            #endregion

            #region Sorting (OrderBy, OrderByDescending, ThenBy, ThenByDescending, Reverse)

            //Sorting.LinqOrderBy();

            //Sorting.LinqOrderByDescending();

            //Sorting.LinqThenBy();

            //Sorting.LinqThenByDescending();

            //Sorting.LinqReverse();

            #endregion

            #region Element Operations (First, FirstOrDefault, Last, LastOrDefault, Single, SingleOrDefault)

            //ElementOperations.LinqFirst();

            //ElementOperations.LinqLast();

            //ElementOperations.LinqSingle();

            #endregion

            #region Quantifier Operations (All, Any, Contains)

            //QuantifierOperations.LinqAll();

            //QuantifierOperations.LinqAny();

            //QuantifierOperations.LinqContains();

            #endregion

            #region Partitioning (Skip, Take, SkipWhile, TakeWhile, Chunk)

            //Partitioning.LinqSkip();

            //Partitioning.LinqTake();

            //Partitioning.LinqSkipAndTake();

            //Partitioning.LinqSkipWhile();

            //Partitioning.LinqTakeWhile();

            //Partitioning.LinqChunk();

            #endregion

            #region Join Operations (Inner Join, LeftJoin, RightJoin, GroupJoin)

            //JoinOperations.LinqJoin();

            //JoinOperations.LinqLeftJoin();

            //JoinOperations.LinqRightJoin();

            //JoinOperations.LinqGroupJoin();

            #endregion

            #region Grouping (GroupBy, Lookup)

            //Grouping.LinqGroupBy();

            //Grouping.LinqToLookup();

            #endregion
        }
    }
}