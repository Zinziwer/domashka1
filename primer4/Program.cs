Console.Write("enter the number ");
int N = Convert.ToInt32 (Console.ReadLine());
int tmp = 2;
while (tmp<=N-2)
{
    Console.Write(tmp +", ");
    tmp=tmp + 2;
}
if ( N % 2==0)                  //это я так запятую в конце удаляю
{
    Console.Write(N);
}
else
{
        Console.Write(N-1);
}