

// collect 5 numbers and find sum and display
Console.Write("Enter the numbers count :");
int size = int.Parse(Console.ReadLine());
int[] numbers = new int[size];
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"Enter number {i + 1} ");
    numbers[i] = int.Parse(Console.ReadLine());
}

// find the sum

int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}

sum = numbers.Sum();
double avg = numbers.Average();
int max = numbers.Max();
int min = numbers.Min();

Array.Sort(numbers);
Array.Reverse(numbers);
Array.BinarySearch(numbers, 4);

// display all numbers
Console.WriteLine($"Sum is {sum}");
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

foreach (int nn in numbers)
{
    Console.WriteLine(nn);
}


int[,] twodarray = new int[3, 6];

int[] ns1 = new int[3] { 1, 2, 3 };
int[] ns2 = new int[] { 1, 2, 3 };
int[] ns3 = { 1, 2, 3, 4, 5 };

// Jagged Arrays
int[][] scores = new int[3][];
scores[0] = new int[6];
scores[1] = new int[3];
scores[2] = new int[1];

scores[0][0] = 20;

// want to store n number of ints
// Dyanmic collections -  generic

List<int> numbs = new List<int>();
// store

numbs.Add(10);
numbs.Add(20);

// read

int n = numbs[1];


