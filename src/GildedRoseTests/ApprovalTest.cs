using GildedRoseKata;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using VerifyXunit;
using Xunit;

namespace GildedRoseTests
{
    public class ApprovalTest
    {
        [Fact]
        public Task NoDaysSpecified()
        {
            var fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader("a\n"));

            Program.Main(new string[] { });
            var output = fakeoutput.ToString();

            return Verifier.Verify(output);
        }

        [Fact]
        public Task ThirtyDays()
        {
            var fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader("a\n"));

            Program.Main(new string[] { "30" });
            var output = fakeoutput.ToString();

            return Verifier.Verify(output);
        }

        [Fact]
        public Task TwentyDays()
        {
            var fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader("a\n"));

            Program.Main(new string[] { "20" });
            var output = fakeoutput.ToString();

            return Verifier.Verify(output);
        }

        [Fact]
        public Task InvalidArgument()
        {
            var fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader("a\n"));

            Program.Main(new string[] { "A" });
            var output = fakeoutput.ToString();

            return Verifier.Verify(output);
        }

        [Fact]
        public Task DaysLessThanOne()
        {
            var fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader("a\n"));

            Program.Main(new string[] { "0" });
            var output = fakeoutput.ToString();

            return Verifier.Verify(output);
        }
    }
}
