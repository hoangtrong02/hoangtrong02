using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.Interface
{
    interface InterfaceLop
    {
        DataTable LoadData();
        bool ThemLop();
        bool SuaLop();
        bool XoaLop();
    }
}
