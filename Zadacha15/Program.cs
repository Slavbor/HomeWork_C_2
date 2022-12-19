using static System.Console;

Write("Enter the week day number : ");
int num = Convert.ToInt32(ReadLine());
if(num >= 1 && num <= 5)
{
    WriteLine("No");
}
else if(num == 6 || num == 7)
{
    WriteLine("Yes");
}
else
{
    WriteLine("Wrong number");
}