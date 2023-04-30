using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Para
    {
        public TimeSpan BeginPara { get; }
        public TimeSpan EndPara { get; }
        public TimeSpan BeginBreak { get; }
        public TimeSpan EndBreak { get; }
        public Smena Smena { get; }
        public Para (TimeSpan beginpara, TimeSpan endpara, TimeSpan beginbreak, TimeSpan endbreak, Smena smena)
        {
            BeginPara = beginpara;
            EndPara = endpara;
            BeginBreak = beginbreak;
            EndBreak = endbreak;
            Smena = smena;
        }
    }
}
