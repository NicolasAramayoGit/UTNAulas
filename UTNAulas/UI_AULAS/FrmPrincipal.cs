using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_AULAS
{
    public partial class FrmPrincipal : Form
    {
        EntidadAula.Aula miAula; //Creo objeto de tipo aula.

        public FrmPrincipal()
        {
            InitializeComponent();
            //Instancio objeto aula.
            miAula = new EntidadAula.Aula(333);
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //MAXIMIZO EL FORMULARIO.
            this.WindowState = FormWindowState.Maximized;
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlumno frm = new FrmAlumno();


            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                miAula.ListaAlumnos.Add(frm.miAlumno);
                //miAula.ListaAlumnos = miAula + frm.miAlumno;
                //miAula.AgregarAlumno(frm.miAlumno);
            }
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListado frm = new FrmListado(miAula);

            if (frm.ShowDialog() ==  System.Windows.Forms.DialogResult.OK)
            {
                
            }
        }
    }
}
