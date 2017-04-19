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
        //EntidadAula.Aula miAula;

        public FrmListado()
        {
            InitializeComponent();
        }

        private void FrmListado_Load(object sender, EventArgs e)
        {
            //miAula = new EntidadAula.Aula(
        }

        public FrmListado(EntidadAula.Aula miAula)
        {
            foreach(var item in miAula)
	        {
                this.lstListado.Show(item);
	        }
        }
    }
}
