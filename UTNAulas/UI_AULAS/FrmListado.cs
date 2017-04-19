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
    public partial class FrmListado : Form
    {
        public FrmListado()
        {
            InitializeComponent();
        }


        public FrmListado(EntidadAula.Aula aula):this()
        {

            foreach (EntidadAula.Alumno item in aula.ListaAlumnos)
            {
                this.lstListado.Items.Add(item.Nombre);
            }
        }

        private void FrmListado_Load(object sender, EventArgs e)
        {

        }
    }
}
