using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadAula;

namespace UI_AULAS
{
    public partial class FrmAlumno : Form
    {
        private Alumno _miAlumno;

        public Alumno miAlumno
        {
            get { return _miAlumno; }
            //set { _miAlumno = value; }
        }
        

        public FrmAlumno()
        {
            InitializeComponent();
        }

        //Para borrar un evento, tenemos que ir a FrmAlumno.Designer.cs
        //Y comentar: this.lblNombre.Click += new System.EventHandler(this.label1_Click);
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAlumno_Load(object sender, EventArgs e)
        {
            this.cmbSexo.Items.Add(ESexo.Femenino);
            this.cmbSexo.Items.Add(ESexo.Masculino);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var legajo = int.Parse(txtLegajo.Text);

            //Creo objeto alumno.
            _miAlumno = new Alumno(legajo,(ESexo) this.cmbSexo.SelectedItem, txtNombre.Text);
            this.DialogResult = System.Windows.Forms.DialogResult.OK; //Cierra Form, esta OK.
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel; //Cancela.
        }
    }
}
