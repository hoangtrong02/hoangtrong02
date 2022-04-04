using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.DAL
{
    interface InterfaceDiem
    {
        DataTable LoadData();
        bool Themdiem();
        bool Suadiem();
        bool Xoadiem();
        float Thangdiem10();
        float Thangdiem4();
        string Thangdiemchu();
    }
}
