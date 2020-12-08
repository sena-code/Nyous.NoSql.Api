using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nyous.Api.NoSql.Contexts
{
    public class NyousDataBaseSettings : INyousDataBaseSettings
    {
        public string EventoColletionName { get ; set ; }
        public string ConnetionString { get ; set ; }
        public string DatabaseName { get ; set ; }
    }

    public interface INyousDataBaseSettings
    {
        string EventoColletionName { get; set; }
        string  ConnetionString { get; set; }
        string DatabaseName { get; set; }
    }
}
