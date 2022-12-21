using static System.Console;

Write("Input three-digit number: ");
int num = Convert.ToInt32(ReadLine());
WriteLine((num / 10) % 10);
