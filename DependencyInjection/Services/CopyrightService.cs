using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public class CopyrightService : ICopyrightService
    {
        public string GetCopyrightString()
        {
            return $"Copyright {DateTime.Now.Year} all right reserved." +
                   $" from CopyrightSrvice. {GetHashCode()}";
        }

        public string CopyrightString { get; set; } = $"Copyright {DateTime.Now.Year} all right reserved.";
    }
}
