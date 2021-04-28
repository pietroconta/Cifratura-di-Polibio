using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace polibio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[,] matrice = new string[6, 6];
        string[] alfabeto = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "kq", "l", "m", "n", "o", "p", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

        int i = 0;
        int x = 0;
        int j = 0;

        int rw = 0, cl = 0;

        bool dec = false, cript = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            tab_data.RowCount = 6;
            tab_data.ColumnCount = 6;

            for (int r = 0; r < 6; r++)
            {

                for (int c = 0; c < 6; c++)
                {

                    
                    
                    tab_data.Rows[r].Height = 40;
                    tab_data.Columns[c].Width = 40;
                   
                }

            }

            matrice[0, 0] = "#";
            for (int c = 1; c < 6; c++) { x++; matrice[0, c] = x + ""; }
            x = 0;
            for (int r = 1; r < 6; r++) { x++; matrice[r, 0] = x + ""; }

            for (int r = 1; r < 6; r++) {

                for (int c = 1; c < 6; c++) {
                 
                    if(i < 25)
                    matrice[r, c] = Convert.ToString(alfabeto[i]);
                    i++;

                }
               
            }

            aggiorna();
        }

        private void aggiorna() {
            for (int r = 0; r < 6; r++)
            {
                for (int c = 0; c < 6; c++)
                {


                    tab_data.Rows[r].Cells[c].Value = matrice[r, c];
                }

            }
        }

        private void tab_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int row = tab_data.CurrentCell.RowIndex;
            int col = tab_data.CurrentCell.ColumnIndex;

            if (row != 0 || col != 0)
            {

                if (row != 0 && col != 0)
                {
                    if (dec)
                    {
                        lbl_decifrato.Text = "";
                        dec = false;
                    }
                    String decifrato = matrice[0, col] + matrice[row, 0];

                    lbl_decifrato.Text += decifrato;
                    cript = true;
                }

                else
                {
                    if (tab_data.CurrentCell.RowIndex != 0 && j == 0)
                        MessageBox.Show("Seleziona prima una cella di colonna per comporre la lettera da decriptare");
                    else if (tab_data.CurrentCell.ColumnIndex != 0 && j != 0)
                        MessageBox.Show("Seleziona ora una cella di riga per comporre la lettera da decriptare");
                    else
                    {
                        if (cript)
                        {
                            lbl_decifrato.Text = "";
                            cript = false;
                        }
                        if (j == 0)
                        {
                            cl = Convert.ToInt16(matrice[tab_data.CurrentCell.RowIndex, tab_data.CurrentCell.ColumnIndex]);
                            j++;
                        }

                        else
                        {
                            rw = Convert.ToInt16(matrice[tab_data.CurrentCell.RowIndex, tab_data.CurrentCell.ColumnIndex]);
                            lbl_decifrato.Text += matrice[rw, cl];
                            j = 0;
                            rw = 0;
                            cl = 0;
                            dec = true;
                        }
                    }

                }
            }
        }
    }
}
