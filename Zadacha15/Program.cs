using static System.Console;

Write("Enter the week day number: ");
int num = Convert.ToInt32(ReadLine());
WriteLine(num >= 1 && num <= 5?"No":num == 6 || num == 7?"Yes":"Wrong number");