using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.DAL
{
    class ClassDiem : InterfaceDiem
    {
        public float Diemchuyencan { get; set; }
        public float Diemgiuaky { get; set; }
        public float Diemcuoiky { get; set; }
        public ClassDiem() { }
        public ClassDiem(float _diemchuyencan, float _diemgiuaky, float _diemcuoiky)
        {
            this.Diemchuyencan = _diemchuyencan;
            this.Diemgiuaky = _diemgiuaky;
            this.Diemcuoiky = _diemcuoiky;
        }
        public DataTable LoadData()
        {
            throw new NotImplementedException();
        }

        public bool Suadiem()
        {
            throw new NotImplementedException();
        }

        public float Thangdiem10()
        {
            return (float)(this.Diemchuyencan * 0.1 + this.Diemgiuaky * 0.2 + this.Diemcuoiky * 0.7);
        }

        public float Thangdiem4()
        {
            return (float)(Thangdiem10() * 0.4);
        }

        public string Thangdiemchu()
        {
            string diemchu;
            if (Thangdiem10() < 4)
                diemchu = "F";
            else if (Thangdiem10() >= 4 && Thangdiem10() < 5)
                diemchu = "D";
            else if (Thangdiem10() >= 5 && Thangdiem10() < 6f)
                diemchu = "D+";
            else if (Thangdiem10() >= 6 && Thangdiem10() < 6.5f)
                diemchu = "C";
            else if (Thangdiem10() >= 6.5f && Thangdiem10() < 7)
                diemchu = "C+";
            else if (Thangdiem10() >= 7 && Thangdiem10() < 8)
                diemchu = "B";
            else if (Thangdiem10() >= 8 && Thangdiem10() < 8.5f)
                diemchu = "B+";
            else if (Thangdiem10() > 8.5f && Thangdiem10() < 9)
                diemchu = "A";
            else
                diemchu = "A+";
            return diemchu;
        }

        public bool Themdiem()
        {
            throw new NotImplementedException();
        }

        public bool Xoadiem()
        {
            throw new NotImplementedException();
        }
    }
}
