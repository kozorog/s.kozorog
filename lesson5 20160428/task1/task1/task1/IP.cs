using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class IP : Client
    {
        private string _fio;
        private DateTime _birth;


        public IP(string fio, DateTime birth)
        {
            _fio = fio;
            _birth = birth;
        }

    }
}
