using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonReader
{
    class Test
    {
        private readonly IConfiguration configuration;
        public Test(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public void TestMethod()
        {
            var dataFromjsonFile = configuration.GetSection("From").Value;
            Console.WriteLine(dataFromjsonFile);
            var dataFromjsonFile1 = configuration.GetSection("To").Value;
            Console.WriteLine(dataFromjsonFile1);
        }
    }
}
