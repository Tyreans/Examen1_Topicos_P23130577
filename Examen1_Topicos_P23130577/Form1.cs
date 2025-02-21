namespace Examen1_Topicos_P23130577
{
    public partial class Form1 : Form
    {
        string filepath;
        public Form1()
        {
            InitializeComponent();
            filepath = "";
        }

        private void abirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult CRes = oFDCURP.ShowDialog();
            if (CRes == DialogResult.OK)
            {
                filepath = oFDCURP.FileName;

                string text = File.ReadAllText(filepath);
                string[] sepSaltos = text.Split('\n');
                dataGridView1.RowCount = sepSaltos.Length;

                for (int i = 0; i < sepSaltos.Length - 1; i++)
                {
                    string[] sepComa = sepSaltos[i].Split(",");
                    string txt = sepComa[0];
                    string sexo = "";
                    DateTime fecha = DateTime.Parse(txt.Substring(8, 2) + "/" + txt.Substring(6, 2) + "/" + txt.Substring(4, 2));
                    int edad;

                    int yrs = DateTime.Now.Year - fecha.Year;
                    int mnt = DateTime.Now.Month - fecha.Month;
                    int day = DateTime.Now.Day - fecha.Day;

                    if (mnt <= 0)
                    {
                        yrs = yrs - 1;
                    }
                    else if (mnt <= 1 && day < 0)
                    {
                        yrs = yrs - 1;
                    }

                    if (txt[10] == 'H')
                    {
                        sexo = "Hombre";
                    }
                    else
                    {
                        sexo = "Mujer";
                    }

                    dataGridView1.Rows[i].Cells[0].Value = sepComa[0];
                    dataGridView1.Rows[i].Cells[1].Value = yrs + "";
                    dataGridView1.Rows[i].Cells[2].Value = sexo;
                    dataGridView1.Rows[i].Cells[3].Value = sepComa[1];
                }
            }
        }

        private void abrirElArchivoAdjuntoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                filepath = "Examen1.csv";

                string text = File.ReadAllText(filepath);
                string[] sepSaltos = text.Split('\n');
                dataGridView1.RowCount = sepSaltos.Length;

                for (int i = 0; i < sepSaltos.Length - 1; i++)
                {
                    string[] sepComa = sepSaltos[i].Split(",");
                    string txt = sepComa[0];
                    string sexo = "";
                    DateTime fecha = DateTime.Parse(txt.Substring(8, 2) + "/" + txt.Substring(6, 2) + "/" + txt.Substring(4, 2));
                    int edad;

                    int yrs = DateTime.Now.Year - fecha.Year;
                    int mnt = DateTime.Now.Month - fecha.Month;
                    int day = DateTime.Now.Day - fecha.Day;

                    if (mnt <= 0)
                    {
                        yrs = yrs - 1;
                    }
                    else if (mnt <= 1 && day < 0)
                    {
                        yrs = yrs - 1;
                    }

                    if (txt[10] == 'H')
                    {
                        sexo = "Hombre";
                    }
                    else
                    {
                        sexo = "Mujer";
                    }

                    dataGridView1.Rows[i].Cells[0].Value = sepComa[0];
                    dataGridView1.Rows[i].Cells[1].Value = yrs + "";
                    dataGridView1.Rows[i].Cells[2].Value = sexo;
                    dataGridView1.Rows[i].Cells[3].Value = sepComa[1];
                }
            
        }
    }
}
