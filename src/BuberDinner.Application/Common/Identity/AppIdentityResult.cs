using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Application.Common.Identity
{
    public class AppIdentityResult
    {
        // This object can only be created from this assembly.
        // If you want to create it from Infrastructure, use Success and Failure methods.
        internal AppIdentityResult(bool succeeded, IEnumerable<string> errors)
        {
            Succeeded = succeeded;
            Errors = errors.ToArray();
        }

        public bool Succeeded { get; set; }

        public string[] Errors { get; set; }

        public static AppIdentityResult Success()
        {
            return new AppIdentityResult(true, Array.Empty<string>());
        }

        public static AppIdentityResult Failure(IEnumerable<string> errors)
        {
            return new AppIdentityResult(false, errors);
        }
    }
}
