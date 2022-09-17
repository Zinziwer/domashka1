Console.Write("enter first number ");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.Write("enter second number ");
int num2 = Convert.ToInt32 (Console.ReadLine());
Console.Write("enter third number ");
int num3 = Convert.ToInt32 (Console.ReadLine());
int maxnum=num1;
if (maxnum>num2)
{
    if(maxnum<num3)
    {
        maxnum=num3;
    }
}
else 
{   
    maxnum=num2;
    if (maxnum<num3)
    {
        maxnum=num3;
    }
}
Console.Write("max number "+maxnum);
