int i = 61;
int count = 1;
int loopCount = 0;

while(count <= 4)
{
    loopCount++;
    //if(i % 2 == 1 && i % 3 == 1 && i % 4 == 1 && i % 5 == 1 && i % 6 == 1)
    if(i % 7 == 0)
    {
        if (count != 3)
        {
            Console.WriteLine(i);
        }
        count++;
    }
    i += 60;
   
}
Console.WriteLine($"Loop Count {loopCount}");
