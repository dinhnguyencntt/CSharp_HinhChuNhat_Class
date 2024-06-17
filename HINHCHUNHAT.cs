using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_HinhChuNhat_Class
{
    internal class HINHCHUNHAT
    {
        public Double chieucao;
        public Double chieurong;
        public double tinhdientich()
        {
            return chieucao * chieurong;
        }
        public double tinhchuvi()
        {
            return (chieucao + chieurong) * 2;
        }
    }
}