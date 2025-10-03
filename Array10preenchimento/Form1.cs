using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array10preenchimento
{
    public partial class Form1 : Form
    {
        int[] array = new int[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            try { 
                int a = cb_ord.SelectedIndex;
                if (array[a] == 0)
                    array[a] = Int32.Parse(tb_num.Text);
                else MessageBox.Show("Array já preenchido.");
            }
            catch(OverflowException)
            {
                MessageBox.Show("Insira números menores.");
            }
            catch(FormatException)
            {
                MessageBox.Show("Insira apenas números.");
            }
            catch
            {
                MessageBox.Show("Erro Geral.");
            }
        
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                MessageBox.Show($"Posição {i+1}: {array[i]}");
            }
        }
    }
}
