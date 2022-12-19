using static System.Console;

Write("Input number: ");
int num = Convert.ToInt32(ReadLine());
if(num > 999)
{
    while(num / 10 > 100)
    {
        num = num / 10;
        
    }
    WriteLine(num % 10);
}
else if(num < 1000 && num > 99)
{
    WriteLine(num % 10);
}                         
else if(num < 100)
{
    WriteLine("NO 3rd digit");
}       