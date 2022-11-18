using Iterator;

static void PrintVector<T>(IIterable<T> vector)
{
    var iterator = vector.GetIterator();
    while(iterator.MoveNext())
    {
        Console.WriteLine(iterator.Current);
    }
}

//PrintVector(new VectorRange(0, 10));
//PrintVector(new VectorArray(new double[] { 1.8, 2.2, 3, 4, 5, 6.9, 7, 8.3 }));

static void PrintVector2<T>(IEnumerable<T> vector)
{
    foreach(var item in vector)
    {
        Console.WriteLine(item);
    }
}

PrintVector2(new VectorRange(0, 10));
PrintVector2(new VectorArray(new double[] { 1.8, 2.2, 3, 4, 5, 6.9, 7, 8.3 }));