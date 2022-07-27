// Write a code to display the 1st, 2nd and 4th multiples of 7
// which gives the reminder 1 when divided by 2, 3, 4, 5 and 6
Approach1();
Approach11();
Approach2();
Approach3();
Approach4();

void Approach1() // 223
{
    // 7 14 21 28 35 42 49
    Console.WriteLine("Approach 1");
    int i = 7;
    int count = 1;
    int loopCount = 0;

    while (count <= 4)
    {
        loopCount++;
        if(i % 2 == 1 && i % 3 == 1 && i % 4 == 1 && i % 5 == 1 && i % 6 == 1)
        {
            if(count !=3)
            {
                Console.WriteLine(i);
            }
            count++;
        }
        i = i + 7;
    }
    Console.WriteLine($"Done Loopcount {loopCount}");
}


void Approach11()
{
    Console.WriteLine("Approach v1.1");
    int i = 7;
    int count = 1;
    int loopCount = 0;

    while (count <= 4)
    {
        loopCount++;
        if (i % 2 == 1 && i % 3 == 1 && i % 4 == 1 && i % 5 == 1 && i % 6 == 1)
        {
            if (count != 3)
            {
                Console.WriteLine(i);
            }
            count++;
        }
        i = i + 14;
    }
    Console.WriteLine($"Done Loopcount {loopCount}");
}

void Approach2()
{
    Console.WriteLine("Approach 2");
    int i = 61; // LCM=60
    int count = 1;
    int loopCount = 0;
    while (count <= 4)
    {
        loopCount++;
        //if (i % 2 == 1 && i % 3 == 1 && i % 4 == 1 && i % 5 == 1 && i % 6 == 1)
        if (i % 7 == 0)
        {
            if (count != 3)
            {
                Console.WriteLine(i);
            }
            count++;
        }
        i = i + 60;
    }
    Console.WriteLine($"Done Loopcount {loopCount}");
}
void Approach3()
{
    Console.WriteLine("Approach 3");
    int i = 1; 
    int count = 1;
    int loopCount = 0;
    while (count <= 4)
    {
        loopCount++;
            if (count != 3)
            {
                Console.WriteLine((60 * (5 + (7 * (i - 1)))) + 1);
            }
            i++;
            count++;
        
    }
    Console.WriteLine($"Done Loopcount {loopCount}");
}
void Approach4()
{
    Console.WriteLine("Approach 4");
    int i = 0;
    int count = 1;
    int loopCount = 0;
    while (count <= 4)
    {
        loopCount++;
        if (count != 3)
        {
            Console.WriteLine(301 + 420 * i);
        }
        i++;
        count++;

    }
    Console.WriteLine($"Done Loopcount {loopCount}");
}


