using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThiChung_02
{
    class NhanVienBC:NhanVien
    {
        private string mucxeploai;
        public NhanVienBC() : base()
        {

        }
        public NhanVienBC(string maso, string hoten, int luongcung, string mucxeploai) : base(maso, hoten, luongcung)
        {
            this.mucxeploai = mucxeploai;
        }
        public string MucXeploai
        {
            set { mucxeploai = value; }
            get { return mucxeploai; }
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap muc xep loai:");
            this.mucxeploai = Console.ReadLine();
        }
        public override int TinhLuong()
        {
            double luongthuclanh;
            double thuong;
            if (mucxeploai == "A")
            {
                thuong = 1.5 * LuongCung;
            }
            else if (mucxeploai == "B")
            {
                thuong = 1 * LuongCung;
            }
            else if (mucxeploai == "C")
            {
                thuong = 0.5 * LuongCung;
            }
            else
            {
                thuong = 0.0;
            }
            luongthuclanh = LuongCung + thuong;
            return (int)luongthuclanh;
        }
    }
}
