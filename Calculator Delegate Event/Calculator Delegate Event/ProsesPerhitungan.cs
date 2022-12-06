using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculator_Delegate_Event
{
    public partial class ProsesPerhitungan : Form
    {
        public delegate void hubungProses(int Operasi, int a, int b, int Hasil);
        public event hubungProses OnProgres;
        public ProsesPerhitungan()
        {
            InitializeComponent();
            txtOperasi.SelectedIndex = 0;
        }

        public int OnPerhitungan { get; internal set; }

        private void button1_Click(object sender, EventArgs e)
        {
            string Operasi = txtOperasi.SelectedItem.ToString();
            int a = Convert.ToInt32(texNilai_A.Text);
            int b = Convert.ToInt32(texNilai_B.Text);
            int Hasil;

            switch (txtOperasi.SelectedIndex)
            {
                case 0 : // penjumlahan 
                    Hasil = a + b;
                        break;

                case 1: // pengurangan 
                    Hasil = a - b;
                    break;

                case 2: // perkalian
                    Hasil = a * b;
                    break;

                case 3: // pembagian
                    Hasil = a / b;
                    break;
                default:
                    Hasil = 0;
                    break;
            }
            this.OnProgres(txtOperasi.SelectedIndex, a, b, Hasil);
        }
    }
}
