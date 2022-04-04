using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.DAL
{
    interface InterfaceSinhvien
    {
        DataTable LoadData();
        bool Themsinhvien();
        bool Suasinhvien();
        bool Xoasinhvien();
    }
}
