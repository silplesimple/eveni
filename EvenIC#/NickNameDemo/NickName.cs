using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NickNameDemo
{
    public class NickName
    {
        private Hashtable _names = new Hashtable();

        public string this[string key]
        {
            get { return _names[key].ToString(); }
            set { _names[key] = value; }
        }
        
    }
}
