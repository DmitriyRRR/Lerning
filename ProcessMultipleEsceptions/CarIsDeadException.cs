using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleEsceptions
{
    public class CarIsDeadException : ApplicationException
    {
        
            private string messageDetails = String.Empty;
            public DateTime ErrorTimeStamp { get; set; }
            public string CauseOfError { get; set; }
            public CarIsDeadException() { }
            public CarIsDeadException(string message, string cause, DateTime time): base (message)
            {
                //messageDetails = message;
                CauseOfError = cause;
                ErrorTimeStamp = time;
            }
            public override string Message => $"Car Error Message: {messageDetails}";
        
    }
}
