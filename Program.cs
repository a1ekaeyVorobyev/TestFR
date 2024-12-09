// See https://aka.ms/new-console-template for more information
Console.WriteLine("Start");
int i = 0;
while (i<100)
{
    Test test = new Test();
    Console.WriteLine($"Create {i} Report");
    Thread.Sleep(1000);
    i++;
}
Console.WriteLine("Finish");

class Test
{
    FastReport.Report report;
    public Test()
    {
        report = new FastReport.Report();
    }
}

