using ServiceStack.Redis;
using System;

namespace Redis
{
    class Program
    {
        static void Main(string[] args)
        {
            using (IRedisClient client=new  RedisClient() )
            {

                for (int i = 0; i < 5000; i++)
                {
                    client.Set<string>($"mycode{i}", i.ToString());
                }
                client.Set<string>("TestC#","123");
            }
            Console.WriteLine("Hello World!");
        }
    }
}
