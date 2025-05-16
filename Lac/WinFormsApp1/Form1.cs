using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks.Sources;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<NhanVien> dsNhanVien = new List<Nhanvien>();
            bool dangThem = false;
        void ReadFile()
        {
            string filePath = "dulieu.txt";
            if (!File.Exists(filePath)) return;
            var lines =File.ReadAllLines(filePath);
            dsNhanVien.Clear();
            foreach (var line in lines)
            { 
                var PARTS = line.Split('');
                if parts.Length == 4 )
                {
                    dsNhanVien.Add(new NhanVien
                    {
                        MaSo = PARTS[0],
                        HoTen = PARTS[1],
                        NgaySinh = DateTime.ParseExact(PARTS[2], "đ/MM/yyyy", null),
                        Email = PARTS[3],
                    });
                };  
            }

        }
        
        void ShowOnListView()
        {
            ListView.Items.Clear();
            foreach(var nv in dsNhanVien)
            {
                var items = new ListViewItem(nv.MaSo);
                items.SubItems.Add(nv.HoTen);
                items.S
            }   
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
