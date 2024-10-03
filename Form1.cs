using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace ReadyForAnExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btbParse_Click(object sender, EventArgs e)
        {
            string Str = "";
            string Path = "../../sinhvien.json";
            List<SinhVienIT> sinhVienITs = LoadJSON(Path);
            for (int i = 0; i < sinhVienITs.Count; i++)
            {
                SinhVienIT sv = sinhVienITs[i];
                Str += string.Format("SV {0} MSSV {1}", (i + 1), sv.MSSV);
            }
            MessageBox.Show(Str);

        }
        private List<SinhVienIT> LoadJSON(string path)
        {
            List<SinhVienIT> List = new List<SinhVienIT>();
            StreamReader r = new StreamReader(path);
            string json = r.ReadToEnd();

            var array = (JObject)JsonConvert.DeserializeObject(json);

            var students = array["sinhvien"].Children();

            foreach (var item in students)
            {
                string mssv = item["MSSV"].Value<string>();
                string hoten = item["HoTen"].Value<string>();
                string diachi = item["DiaChi"].Value<string>();
                string lop = item["Lop"].Value<string>();
                DateTime ngaysinh = item["NgaySinh"].Value<DateTime>();
                string sodt = item["SoDT"].Value<string>();
                List<string> monhoc = item["MonHoc"].Value<string>().Split(new[] { ", " }, StringSplitOptions.None).ToList();

                SinhVienIT sv = new SinhVienIT(mssv, hoten, diachi, lop, ngaysinh, sodt, monhoc);
                List.Add(sv);

            }
            return List;
        }
    }
}
