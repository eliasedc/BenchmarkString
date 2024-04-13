using BenchmarkDotNet.Attributes;
using System.Text;

namespace TesteBanchMark
{
    [MemoryDiagnoser]
    public class BenchmarkStringTest
    {
        private readonly string _stringToAppend;

        [Params(10, 1000, 10_000)]
        public int ParameterLength;

        public BenchmarkStringTest()
        {
            _stringToAppend = new string('e', ParameterLength);
        }

        [Benchmark]
        public string ConcatenateStrings_StringBuilder()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < ParameterLength; i++)
            {
                sb.Append("Eliasdc.dev_" + i + " " + _stringToAppend);
            }

            return sb.ToString();
        }

        [Benchmark]
        public string ConcatenateStrings_GenericList()
        {
            var list = new List<string>();
            for (int i = 0; i < ParameterLength; i++)
            {
                list.Add("Eliasdc.dev_" + i + " " + _stringToAppend);
            }
            return string.Join(string.Empty, list);
        }

        [Benchmark]
        public string ConcatenateStrings_string()
        {
            string str = string.Empty;
            for (int i = 0; i < ParameterLength; i++)
            {
                str = str + "Eliasdc.dev_" + i + " " + _stringToAppend;
            }
            return str;
        }

        /////////////////////////////APPENDLINE///////////////////////////////

        [Benchmark]
        public string ConcatenateStrings_StringBuilderAppendLine()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < ParameterLength; i++)
            {
                sb.AppendLine("Eliasdc.dev_" + i + " " + _stringToAppend);
            }

            return sb.ToString();
        }

        [Benchmark]
        public string ConcatenateStrings_GenericListAppendLine()
        {
            var list = new List<string>();
            for (int i = 0; i < ParameterLength; i++)
            {
                list.Add("Eliasdc.dev_" + i + " " + _stringToAppend + "\r\n");
            }
            return string.Join(string.Empty, list);
        }

        [Benchmark]
        public string ConcatenateStrings_stringAppendLine()
        {
            string str = string.Empty;
            for (int i = 0; i < ParameterLength; i++)
            {
                str = str + "Eliasdc.dev_" + i + " " + _stringToAppend + "\r\n";
            }
            return str;
        }
    }
}
