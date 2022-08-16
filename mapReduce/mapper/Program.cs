using Microsoft.Hadoop.MapReduce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapper
{
    public class Program
    {
        public class ErrorTextMapper : MapperBase
        {
            public override void Map(string inputLine, MapperContext context)
            {
                if (inputLine.ToLowerInvariant().Equals("error"))
                    context.EmitLine(inputLine);
            }
        }
        public class ErrorTextReducerCombiner : ReducerCombinerBase
        {
            public override void Reduce(string key, IEnumerable<string> values, ReducerCombinerContext context)
            {
                context.EmitKeyValue("errortextcount: ", values.Count().ToString());
            }
        }
        static void Main(string[] args)
        {
            HadoopJobConfiguration hadoopConfiguration = new HadoopJobConfiguration();
            hadoopConfiguration.InputPath = "/input";
            hadoopConfiguration.OutputFolder = "/output";
            Uri myUri = new Uri("DEV URL for Hadoop");
            IHadoop hadoop = Hadoop.Connect(myUri, "user_name", "pwn");

            hadoop.MapReduceJob.Execute<ErrorTextMapper, ErrorTextReducerCombiner>(hadoopConfiguration);

            Console.Read();
        }
    }
}
