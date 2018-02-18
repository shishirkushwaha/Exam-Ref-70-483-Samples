using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ExamRef70483.ManageProgramFlow.ImplMultithreading
{
    public class Listing1P18
    {
        public static void UsingAsyncAndAwait()
        {
            var result = DownloadContent().Result;
            Console.WriteLine(result);
        }

        public static async Task<string> DownloadContent()
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetStringAsync("http://www.microsoft.com");
                return result;
            }
        }
    }
}