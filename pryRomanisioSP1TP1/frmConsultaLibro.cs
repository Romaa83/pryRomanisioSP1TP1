using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryRomanisioSP1TP1
{
    public partial class frmConsultaLibro : Form
    {
        string[,] matConsultaLibro = new string [21,5];
        string[,] matDistribuidora = new string [7,2];
        string[,] matEditorial = new string[7, 2];
        int NumPag = 0;


        public frmConsultaLibro()
        {
            InitializeComponent();
        }

        private void frmConsultaLibro_Load(object sender, EventArgs e)
        {
            char separador = Convert.ToChar(",");
            int fm = 0;
            int fmDistribuidora = 0;
            int fmEditorial = 0;
            StreamReader srDistribuidora = new StreamReader("./Distribuidora.txt");
            StreamReader srConsultaLibro = new StreamReader("./LIBRO.txt");
            StreamReader srEditorial = new StreamReader("./Editorial.txt");

            while (!srDistribuidora.EndOfStream)
            {
                string[] arrayDistribuidora = srDistribuidora.ReadLine().Split(separador);
                matDistribuidora[fmDistribuidora, 0] = arrayDistribuidora[0]; //le agrego a la matriz los datos del array
                matDistribuidora[fmDistribuidora, 1] = arrayDistribuidora[1];
                fmDistribuidora = fmDistribuidora + 1;
            }
            while (!srEditorial.EndOfStream)
            {
                string[] arrayEditorial = srEditorial.ReadLine().Split(separador);
                matEditorial[fmEditorial, 0] = arrayEditorial[0];
                matEditorial[fmEditorial, 1] = arrayEditorial[1];
                fmEditorial++;
            }
            while (!srConsultaLibro.EndOfStream)
            {
                string[] arrayConsultaLibro = srConsultaLibro.ReadLine().Split(separador); 
                matConsultaLibro[fm, 0] = arrayConsultaLibro[0]; //Le agrego a la matriz los datos del array
                matConsultaLibro[fm, 1] = arrayConsultaLibro[1];
                matConsultaLibro[fm, 2] = arrayConsultaLibro[2];
                matConsultaLibro[fm, 3] = arrayConsultaLibro[3];
                matConsultaLibro[fm, 4] = arrayConsultaLibro[4];           

                switch (matConsultaLibro[fm,4]) //Segun el numero que tenga la matriz, va a ser el texto de la matriz
                {
                    case "\t1":matConsultaLibro[fm, 4] = matDistribuidora[0, 1]; break;
                    case "\t2":matConsultaLibro[fm, 4] = matDistribuidora[1, 1]; break;
                    case "\t3":matConsultaLibro[fm, 4] = matDistribuidora[2, 1];break;
                    case "\t4":matConsultaLibro[fm, 4] = matDistribuidora[3, 1];break;
                    case "\t5":matConsultaLibro[fm, 4] = matDistribuidora[4, 1];break;
                    case "\t6":matConsultaLibro[fm, 4] = matDistribuidora[5, 1];break;
                    case "\t7":matConsultaLibro[fm, 4] = matDistribuidora[6, 1];break;
                }
                switch (matConsultaLibro[fm, 2])
                {
                    case "\t1": matConsultaLibro[fm, 2] = matEditorial[0, 1]; break;
                    case "\t2": matConsultaLibro[fm, 2] = matEditorial[1, 1]; break;
                    case "\t3": matConsultaLibro[fm, 2] = matEditorial[2, 1]; break;
                    case "\t4": matConsultaLibro[fm, 2] = matEditorial[3, 1]; break;
                    case "\t5": matConsultaLibro[fm, 2] = matEditorial[4, 1]; break;
                    case "\t6": matConsultaLibro[fm, 2] = matEditorial[5, 1]; break;
                    case "\t7": matConsultaLibro[fm, 2] = matEditorial[6, 1]; break;
                }
                fm++;
            }
            srConsultaLibro.Close();
                   dgvConsultaLibros.Rows.Add(matConsultaLibro[NumPag, 0],
                   matConsultaLibro[NumPag, 1],
                   matConsultaLibro[NumPag, 2],
                   matConsultaLibro[NumPag, 3],
                   matConsultaLibro[NumPag, 4]);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            NumPag++; //la suma de pagina va afuera del if para que no se acumule
            if (NumPag < 21) 
            {
                dgvConsultaLibros.Rows.Clear();
                dgvConsultaLibros.Rows.Add(matConsultaLibro[NumPag, 0],
                   matConsultaLibro[NumPag, 1],
                   matConsultaLibro[NumPag, 2],
                   matConsultaLibro[NumPag, 3],
                   matConsultaLibro[NumPag, 4]);
            }
            else
            {
                MessageBox.Show("No hay mas datos que mostrar");
                NumPag = 20;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            NumPag--;
            if (NumPag>=0)
            {
                dgvConsultaLibros.Rows.Clear();
                dgvConsultaLibros.Rows.Add(matConsultaLibro[NumPag, 0],
                    matConsultaLibro[NumPag, 1],
                    matConsultaLibro[NumPag, 2],
                    matConsultaLibro[NumPag, 3],
                    matConsultaLibro[NumPag, 4]);
            }
            else
            {
                MessageBox.Show("No hay mas datos que mostrar");
                NumPag = 0;
            }
        }
    }
}
