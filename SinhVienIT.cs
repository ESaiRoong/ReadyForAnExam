using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyForAnExam
{
    public class SinhVienIT
    {
        public string MSSV {  get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string Lop {  get; set; }
        public DateTime NgaySinh { get; set; }
        public string SDT {  get; set; }

        public List<string> MonHoc { get; set; }


        public SinhVienIT() { }
        public SinhVienIT(string mSSV, string hoTen, string diaChi, string lop, DateTime ngaySinh, string sDT, List<string> monHoc)
        {
            MSSV = mSSV;
            HoTen = hoTen;
            DiaChi = diaChi;
            Lop = lop;
            NgaySinh = ngaySinh;
            SDT = sDT;
            MonHoc = monHoc;
        }
    }
}
