using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcdia4.Models
{
    public class Customer
    {
        private string _CustomerCode;
        public string CustomerCode
        {
            get { return _CustomerCode; }
            set { _CustomerCode = value; }
        }
    }
}