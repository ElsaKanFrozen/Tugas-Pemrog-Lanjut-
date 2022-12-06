using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Delegate_Event
{
    public partial class Form1 : Form
    {
        private IList<Kalkulator> kalkulator = new List<Kalkulator>();
        public int HasilPerhitungan_OnPerhitungan { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void ProsesPerhitungan_OnCreate(Kalkulator kal)
        {
            ListViewItem item = new ListViewItem();
            item.SubItems.Add(kal.Operasion);
            item.SubItems.Add(kal.Nilai_A);
            item.SubItems.Add(kal.Nilai_B);
            ListHasilnya.Items.Add(item);
        }
        private void screen(int Operasi, int a, int b, int Hasil)
        {
            char[] operasi_simbol = { '+', '-', 'x', '/' };
            string[] operasi_str = { "penjumlahan", "pengurangan", "perkalian", "pembagian" };
            ListHasilnya.Items.Add($"Hasil {(operasi_str[Operasi]).ToLower()} {a} {operasi_simbol[Operasi]} {b} = {Hasil}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProsesPerhitungan mulaiproses = new ProsesPerhitungan();
            mulaiproses.OnProgres += screen;
            mulaiproses.ShowDialog();
        }
    }
}
