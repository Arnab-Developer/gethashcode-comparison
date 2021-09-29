using DotNet5App;
using static System.Console;

WriteLine("Class:");

StudentClass s1 = new() { Id = 1, FirstName = "Jon", LastName = "Doe" };
WriteLine(s1.GetHashCode());
WriteLine(s1.GetHashCode());
WriteLine(s1.GetHashCode());
WriteLine(s1.GetHashCode());

WriteLine();

StudentClass s2 = new() { Id = 2, FirstName = "Bob", LastName = "Dilon" };
WriteLine(s2.GetHashCode());
WriteLine(s2.GetHashCode());
WriteLine(s2.GetHashCode());
WriteLine(s2.GetHashCode());

WriteLine();
WriteLine("Record:");

StudentRecord s3 = new() { Id = 1, FirstName = "Rahul", LastName = "Roy" };
WriteLine(s3.GetHashCode());
WriteLine(s3.GetHashCode());
WriteLine(s3.GetHashCode());
WriteLine(s3.GetHashCode());

WriteLine();

StudentRecord s4 = new() { Id = 2, FirstName = "Sachin", LastName = "Bose" };
WriteLine(s4.GetHashCode());
WriteLine(s4.GetHashCode());
WriteLine(s4.GetHashCode());
WriteLine(s4.GetHashCode());

namespace DotNet5App
{
    internal class StudentClass
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }

    internal record StudentRecord
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }
}

/*
Output:

--------Run1:
Class:
58225482
58225482
58225482
58225482

54267293
54267293
54267293
54267293

Record:
2089296934
2089296934
2089296934
2089296934

686207319
686207319
686207319
686207319

--------Run2:
Class:
58225482
58225482
58225482
58225482

54267293
54267293
54267293
54267293

Record:
-442222548
-442222548
-442222548
-442222548

-1851475378
-1851475378
-1851475378
-1851475378

--------Run3:
Class:
58225482
58225482
58225482
58225482

54267293
54267293
54267293
54267293

Record:
567290484
567290484
567290484
567290484

1282661680
1282661680
1282661680
1282661680

--------Run4:
Class:
58225482
58225482
58225482
58225482

54267293
54267293
54267293
54267293

Record:
-1753287934
-1753287934
-1753287934
-1753287934

79729668
79729668
79729668
79729668

--------Run5:
Class:
58225482
58225482
58225482
58225482

54267293
54267293
54267293
54267293

Record:
-633310588
-633310588
-633310588
-633310588

1537080498
1537080498
1537080498
1537080498
*/