using ProyectBasculaUtpl.Liquidacion.CrearLiquidacion;
using ProyectBasculaUtpl.Liquidacion.ReporteLiquidacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectBasculaUtpl.Liquidacion
{
    public partial class FrmMenuLiquidacion : Form
    {
        public FrmMenuLiquidacion()
        {
            InitializeComponent();
        }

        private Form FormActivo = null;
        private void AbrirFormulario(Form FrmHijo)
        {
            if (FormActivo != null)
            {
                FormActivo.Close();
            }
            FormActivo = FrmHijo;
            FrmHijo.TopLevel = false;
            FrmHijo.FormBorderStyle = FormBorderStyle.None;
            FrmHijo.Dock = DockStyle.None;
            PanelContenedorHijo.Controls.Add(FrmHijo);
            PanelContenedorHijo.Tag = FrmHijo;
            FrmHijo.BringToFront();
            FrmHijo.Show();
        }

        private void BtnLiquidar_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmCrearLiquidacion());
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmReporteLiquidacion());
        }
    }
}
