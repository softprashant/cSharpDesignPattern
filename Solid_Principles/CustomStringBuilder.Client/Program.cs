using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringBuilder.Client
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class CodeBuilder // : StringBuilder >> Not possible
    {
        private string text = string.Empty;
        private readonly StringBuilder _stringBuilder;

        public CodeBuilder(string text)
        {
            _stringBuilder = new StringBuilder(text);
        }
        public CodeBuilder AppendLine(string text)
        {
            _stringBuilder.AppendLine(text);
            return this;
        }

        // Keep on Adding..
    }
}
