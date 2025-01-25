using Linq.AggregationMethods;
using Linq.ConcatenationMethods;
using Linq.ConversionMethods;
using Linq.ElementMethods;
using Linq.EqualityMethods;
using Linq.FilteringMethods;
using Linq.GenerationMethods;
using Linq.GroupingMethods;
using Linq.JoinMethods;
using Linq.PartitioningMethods;
using Linq.ProjectionMethods;
using Linq.QualifireMethods;
using Linq.SetMethods;
using Linq.SortingMethods;
Console.WriteLine("Hello World");

#region Filtering Methods

    #region .Where()
    var whereMethod = new WhereMethod();
        whereMethod.Use_Where();
        whereMethod.Use_Where_With_Index();

        #endregion

    #region .OfType()
    OfTypeMethod ofTypeMethod = new OfTypeMethod();
    ofTypeMethod.Use_OfType();

    #endregion

#endregion

#region Sorting Methods

    #region .OrderBy()
    var orderByMethod = new OrderByMethod();
    orderByMethod.Use_OrderBy();

    #endregion

    #region .OrderByDescending()
    var orderByDescendingMethod = new OrderByDescendingMethod();
    orderByDescendingMethod.Use_OrderBy();

#endregion

    #region .ThenBy()
    var thenByMethod = new ThenByMethod();
    thenByMethod.Use_ThenBy();

    #endregion

    #region .ThenByDescending()
    var thenByDescendingMethod = new ThenByDescendingMethod();
    thenByDescendingMethod.Use_ThenByDescending();

    #endregion

    #region .Reverse()
    var reverseMethod = new ReverseMethod();
    reverseMethod.Use_Reverse();

#endregion

#endregion

#region Grouping Methods

    #region .GroupBy()
    var groupByMethod = new GroupByMethod();
    groupByMethod.Use_GroupBy();
#endregion

    #region .ToLookUp()
    var ToLookUpMethod = new ToLookUpMethod();
    ToLookUpMethod.Use_ToLookUp();
#endregion

#endregion

#region Join Methods

    #region .Join()
    var joinMethod = new JoinMethod();
    joinMethod.Use_Join();
#endregion

    #region .GroupJoin()
    var groupJoinMethod = new GroupJoinMethod();
    groupJoinMethod.Use_GroupJoin();
#endregion

#endregion

#region Projection Methods

    #region .Select()
    var selectMethod = new SelectMethod();
    selectMethod.Use_Select();

    #endregion

    #region .SelectMany()
    var selectManyMethod = new SelectManyMethod();
    selectManyMethod.Use_SelectMany();

#endregion

#endregion

#region Aggregation Methods

    #region .Aggregate()
    var aggregateMethod = new AggretateMethod();
    aggregateMethod.Use_Aggregate();
#endregion

    #region .Average()
    var averageMethod = new AverageMethod();
    averageMethod.Use_Average();
    #endregion

    #region .Count()
    var countMethod = new CountMethod();
    countMethod.Use_Count();
    #endregion

    #region .Max()
    var maxMethod = new MaxMethod();
    maxMethod.Use_Max();
    #endregion

    #region .Min()
    var minMethod = new MinMethod();
    minMethod.Use_Min();
    #endregion

    #region .Sum()
    var sumMethod = new SumMethod();
    sumMethod.Use_Sum();
#endregion

#endregion

#region Qualifire Methods

    #region .All()
    var allMethod = new AllMethod();
    allMethod.Use_AllMethod();

    #endregion

    #region .Any()
    var anyMethod = new AnyMethod();
    anyMethod.Use_AnyMethod();

    #endregion

    #region .Contains()
    var containsMethod = new ContainsMethod();
    containsMethod.Use_ContainsMethod();

#endregion

#endregion

#region Element Methods

    #region .ElementAt()
    var elementAtMethod = new ElementAtMethod();
    elementAtMethod.Use_ElementAt();

    #endregion

    #region .ElementAtOrDefault()
    var elementAtOrDefaultMethod = new ElementAtOrDefaultMethod();
    elementAtOrDefaultMethod.Use_ElementAtOrDefault();

    #endregion

    #region .First()
    var firstMethod = new FirstMethod();
    firstMethod.Use_Frist();

    #endregion

    #region .FirstOrDefault()
    var firstOrDefaultMethod = new FirstOrDefaultMethod();
    firstOrDefaultMethod.Use_FirstOrDefault();

    #endregion

    #region .Last()
    var lastMethod = new LastMethod();
    lastMethod.Use_Last();

    #endregion

    #region .LastOrDefault()
    var lastOrDefaultMethod = new LastOrDefaultMethod();
    lastOrDefaultMethod.Use_LastOrDefault();

    #endregion

    #region .Single()
    var singleMethod = new SingleMethod();
    singleMethod.Use_Single();

    #endregion

    #region .SingleOrDefault()
    var singleOrDefaultMethod = new SingleOrDefaultMethod();
    singleOrDefaultMethod.Use_SingleOrDefault();

#endregion

#endregion

#region Set Methods

    #region .Distinct()
    var distinctMethod = new DistinctMethod();
    distinctMethod.Use_Distinct();
    distinctMethod.Use_Distinct_Class();
    #endregion

    #region .Except()
    var exceptMethod = new ExceptMethod();
    exceptMethod.Use_Except();
    exceptMethod.Use_Except_Class();

    #endregion

    #region .Intersect()
    var intersectMethod = new IntersectMethod();
    intersectMethod.Use_Intersect();
    intersectMethod.Use_Intersect_Class();

    #endregion

    #region .Union()
    var unionMethod = new UnionMethod();
    unionMethod.Use_Union();

#endregion

#endregion

#region Concatenation Methods

    #region .Concat()
    var concatMethod = new ConcatMethod();
    concatMethod.Use_Concat();
    concatMethod.Use_Concat_Class();

#endregion

#endregion

#region Partitioning Methods

    #region .Take()
    var takeMethod = new TakeMethod();
    takeMethod.Use_Take();

    #endregion

    #region .TakeWhile()
    var takeWhileMethod = new TakeWhileMethod();
    takeWhileMethod.Use_TakeWhile();

    #endregion

    #region .Skip()
    var skipMethod = new SkipMethod();
    skipMethod.Use_Skip();

    #endregion

    #region .SkipWhile()
    var skipWhileMethod = new SkipWhileMethod();
    skipWhileMethod.Use_SkipWhile();

#endregion

#endregion

#region Equality Methods

    #region .SequenceEqual()
    var sequenceEqual = new SequenceEqualMethod();
    sequenceEqual.Use_SequenceEqual();

#endregion

#endregion

#region Generation Methods

    #region .DefaultIfEmpty()
    var defaultIfEmpty = new DefaultIfEmptyMethod();
    defaultIfEmpty.Use_DefaultIfEmpty();

    #endregion

    #region .Empty()
    var empty = new EmptyMethod();
    empty.Use_Empty();

    #endregion

    #region .Range()
    var range = new RangeMethod();
    range.Use_Range();

    #endregion

    #region .Reapeat()
    var repeat = new RepeatMethod();
    repeat.Use_Repeat();

#endregion

#endregion

#region Conversion Methods

    #region .AsEnumerable()
    var asEnumerableMethod = new AsEnumerableMethod();
    asEnumerableMethod.Use_AsEnumerable();

    #endregion

    #region .AsQueryable()
    var asQueryableMethod = new AsQueryableMethod();
    asQueryableMethod.Use_AsQueryable();

    #endregion

    #region .Cast()
    var castMethod = new CastMethod();
    castMethod.Use_Cast();

    #endregion

    #region .ToArray()
    var toArrayMethod = new ToArrayMethod();
    toArrayMethod.Use_ToArray();

    #endregion

    #region .ToList()
    var toListMethod = new ToListMethod();
    toListMethod.Use_ToList();

    #endregion

    #region .ToDictionary()
    var toDictionaryMethod = new ToDictionaryMethod();
    toDictionaryMethod.Use_ToDictionary();

    #endregion

#endregion