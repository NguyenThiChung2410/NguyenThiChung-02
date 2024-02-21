using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThiChung_02
{
    class QuanLyNV
    {
        private List<NhanVien> dsNV;
        public QuanLyNV()
        {
            dsNV = new List<NhanVien>();
        }
        public void NhapDS()
        {
            string nhap="y";
            int chon;
            NhanVien nv;
            do
            {
                Console.Write("Chon loai nhan vien[1.Bien Che,2.Hop Dong]:");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        nv = new NhanVienBC();
                        nv.Nhap();
                        dsNV.Add(nv);
                        break;
                    case 2:
                        nv = new NhanVienHD();
                        nv.Nhap();
                        dsNV.Add(nv);
                        break;
                    default:
                        Console.WriteLine("Ban chon sai.Vui long chon lai nhe.");
                        break;
                }
                Console.Write("Ban co muon tiep tuc khong?y/n:");
                nhap = Console.ReadLine();
            } while (nhap.ToLower() == "y");
        }
        public void XuatDS()
        {
            Console.WriteLine($"{"Maso",-10} {"Hoten",20} {"Luongcung",10} {"Luongthuclanh",20}");
            foreach(NhanVien a in dsNV)
            {
                Console.WriteLine($"{a.MaSo,-10} {a.HoTen,20} {a.LuongCung,10} {a.TinhLuong(),20:#,##0 vnd}");
            }
        }
        public int TinhTongLuong()
        {
            int sum = 0;
            foreach (NhanVien nv in dsNV)
            {
                sum += nv.TinhLuong();
            }
            return sum;
        }
        public double TinhLuongTrungBinh()
        {
            int sum = 0;
            int count = 0;
            foreach(NhanVien nv in dsNV)
            {
                sum += nv.TinhLuong();
                count++;
            }
            return sum / count;
        }
    }
}
