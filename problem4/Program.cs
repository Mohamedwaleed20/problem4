// See https://aka.ms/new-console-template for more information
Console.Write("enter the num : ");
int num =int .Parse(Console.ReadLine());
for(int i = 1; i <= 12; i++)
{
   int res= num * i;
    Console.WriteLine("{0}*{1}={2}",num,i,res);
}
