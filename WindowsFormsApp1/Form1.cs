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

        private void Form1_Load(object sender, EventArgs e)
        {
            var per = new Persona()
            {
                Cedula = "402",
                Nombre = "g",
                Apellidos="a"
            };
            var tel = new Telefono()
            {
                Tipo="Casa",
                Numero = "8096991656"
            };
            var tel1 = new Telefono()
            {
                Tipo = "tabajo",
                Numero = "8096991656"
            };
            var tel3 = new Telefono()
            {
                Tipo = "movil",
                Numero = "8096991656"
            };

            var list = new List<Telefono>();
            list.Add(tel);
            list.Add(tel1);
            list.Add(tel3);
            var lisp = new List<Persona>();
            lisp.Add(per);
            CrystalReport1 rep = new CrystalReport1();

            rep.SetDataSource(list);
            rep.SetParameterValue("Nombre", per.Nombre);
            rep.SetParameterValue("Cedula", per.Cedula);
            crystalReportViewer1.ReportSource = rep;
            
        }
    }
}
