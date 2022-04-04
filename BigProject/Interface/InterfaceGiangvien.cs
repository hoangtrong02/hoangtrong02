using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.DAL
{
    interface InterfaceGiangvien
    {
        DataTable LoadData();
        bool Themgiangvien();
        bool Suagiangvien();
        bool Xoagiangvien();
    }
}
