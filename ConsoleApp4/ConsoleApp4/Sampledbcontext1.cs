using ConsoleApp4.Models;
using System;

namespace ConsoleApp4
{
    internal class Sampledbcontext
    {
        public object Tblsample { get; internal set; }

        public static implicit operator Sampledbcontext(SampleDBContext v)
        {
            throw new NotImplementedException();
        }
    }
}