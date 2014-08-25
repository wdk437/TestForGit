using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForGit
{
    public class IPProvider
    {
        private int _takeValue { get; set;  }
        public void SetValue(int value)
        {
            _takeValue = value;
        }
        public int GetValue()
        {
            return _takeValue;
        }
    }
}
