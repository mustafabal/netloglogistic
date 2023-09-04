// See https://aka.ms/new-console-template for more information

using Logistic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

class Program
{
    static void Main(string[] args)
    {
        

        SchedulerHelper.SchedulerSetup();

        Console.ReadLine();
    }
}
