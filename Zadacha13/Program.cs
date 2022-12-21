using static System.Console;

Write("Input number: ");
long num = long.Parse(ReadLine()!);
if (num > 999)
{
    while (num > 999)
    {
    
        num = num / 10;
            
    
    } 
    WriteLine(num % 10);
    return;
   
}
WriteLine(num < 1000 && num > 99?num % 10:num < 100?"NO 3rd digit":"");
