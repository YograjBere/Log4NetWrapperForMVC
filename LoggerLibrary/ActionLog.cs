using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerLibrary
{
    public class ActionLog
    {
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public Exception ExceptionAssociated { get; set; }
        public DateTime TimeStamp { get; set; }

        public override string ToString()
        {
            return string.Format("Action Method Name: {0} Controller Name: {1} Exception Associated: {2}", ActionName, ControllerName, ExceptionAssociated);
        }
    }
}
