using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;

namespace DockerWrightManager
{    
    public static class Callbacker
    {
        public static string respath;
        public static Dictionary<string, string> cbs = new Dictionary<string, string>();

        public static void push(string job, string callback)
        {       
            lock (cbs)
            {
                cbs[job] = callback;
            }         
        }

        public static void run()
        {
            while (true)
            {
                try
                {
                    Thread.Sleep(5000);             
                    var forProcess = new Dictionary<string, string>();                    
                    lock (cbs)
                    {
                        foreach (var k in cbs.Keys)
                        {                        
                            if (File.Exists($"{respath}/{k}/index.html"))
                            {
                                forProcess.Add(k, cbs[k]);
                            }
                        }
                        foreach (var k in forProcess.Keys)
                        {
                            cbs.Remove(k);
                        }
                    }
                    foreach (var k in forProcess.Keys)
                    {
                        var res = new HttpClient().GetAsync(forProcess[k]).Result;              
                    }             
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + e.StackTrace);
                }
            }
        }
    }
}
