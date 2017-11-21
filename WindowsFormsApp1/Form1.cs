using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CrystalReport1 repo = new CrystalReport1();
            repo.Load("CrystalReport.rpt");

            var Tel = new Telefono()
            {
                Numero="8096991656"
            };

            List<Telefono> lis = new List<Telefono>();
            lis.Add(Tel);

            var pers = new Persona()
            {
                Nombre = "Geordano",
                Apellidos = "Alcantara",
                Telefono = Tel
            };

            DataSet1 ds = new DataSet1();
            List<Persona> lisp = new List<Persona>();
            lisp.Add(pers);

            crystalReportViewer1.ReportSource = repo;
            repo.SetDataSource (lisp);


        }
    }
}
