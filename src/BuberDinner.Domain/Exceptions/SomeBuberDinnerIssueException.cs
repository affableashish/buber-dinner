using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Domain.Exceptions
{
    public class SomeBuberDinnerIssueException : Exception
    {
        public SomeBuberDinnerIssueException(string message)
        : base($"Some message about this issue: \"{message}\".")
        {
        }
    }
}
