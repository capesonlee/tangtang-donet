using System;
using System.Threading;


namespace MyThread
{
    public class ServerClass
    {

        public void InstanceMethod()
        {
            Console.WriteLine("ServerClass.InstanceMethod is running on another thread");
            Thread.Sleep(3000);
            Console.WriteLine("instance caller is alive");
            Thread.Sleep(3000);
            Console.WriteLine("the insnce method called by the worker thread has ended");
        }
        public static void StaticMethod()
        {
            Console.WriteLine("ServerClass.StaticMethos is running on another thread");
            Thread.Sleep(5000);
            Console.WriteLine("static caller is alive");
            Thread.Sleep(5000);
            Console.WriteLine("The static metod called by the worker thread has ended");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ServerClass serverClass = new ServerClass();
            Thread instanceCaller = new Thread(
                new ThreadStart(serverClass.InstanceMethod));
            instanceCaller.Start();
             Console.WriteLine("The Main() thread calls this after "
            + "starting the new InstanceCaller thread.");

            Thread staticCaller = new Thread( new ThreadStart(ServerClass.StaticMethod));
            staticCaller.Start();
             Console.WriteLine("The Main() thread calls this after "
            + "starting the new StaticCaller thread.");

        }
    }
}
