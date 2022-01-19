int[] numbers = {
    42,11,87,33,176,44,22,87,42,176,112,112,112,42,
    176,44,22,87,42,42,11,87,33,112,112,42,176,112,
    24,66,87,33,176,44,22,87,42,176,176,176,176,55
};

var query = numbers;

// Produces the entire sequence
//var query = numbers
//    .Sample(1)
//    ;

// Produces the subsequence: 42 176 176 112 24 42
//var query = numbers
//    .Where(i => i % 2 == 0)
//    .Sample(5)
//    ;

// Produces an ArgumentException illustrating the query being sampled wrongly
//var query = numbers
//    .Where(i => i < 0)
//    .Sample(5)
//    ;

foreach (var i in query)
{
    Console.Write($"{i} ");
}
