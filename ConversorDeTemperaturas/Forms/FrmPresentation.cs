using AppCore.Facthory;
using AppCore.IServices;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorDeTemperaturas.Forms
{
    public partial class FrmPresentation : Form
    {
        private IResumenServices resumenServices;
        private ITemperatureColeccion temperatureColeccion;

        public FrmPresentation(ITemperatureColeccion temperatureColeccion, IResumenServices resumenServices)
        {
            this.resumenServices = resumenServices;
            this.temperatureColeccion = temperatureColeccion;
            InitializeComponent();
        }

        private void FrmPresentation_Load(object sender, EventArgs e)
        {
            cmbA.Items.AddRange(Enum.GetValues(typeof(TipoDeConversion)).Cast<object>().ToArray());
            cmbAresumen.Items.AddRange(Enum.GetValues(typeof(TipoDeConversion)).Cast<object>().ToArray());
            cmbDe.Items.AddRange(Enum.GetValues(typeof(TipoDeConversion)).Cast<object>().ToArray());
            cmbDeResumen.Items.AddRange(Enum.GetValues(typeof(TipoDeConversion)).Cast<object>().ToArray());
            CargarDataGridView();
        }

        private void btnCalculos_Click(object sender, EventArgs e)
        {
            Temperature temp = new Temperature(decimal.Parse(txtTemperatura.Text))
            {
                Id = 0,
                De = (TipoDeConversion)cmbDe.SelectedItem,
                A = (TipoDeConversion)cmbA.SelectedItem,
                Fecha = DateTime.Now.ToLocalTime(),
                Medicion = decimal.Parse(txtTemperatura.Text),
            };

            temperatureColeccion.Add(temp);

            Resumen resumen = new Resumen()
            {
                Fecha = DateTime.Now.ToLocalTime(),
                Conversion = temp.Medicion,
                De = (TipoDeConversion)cmbDe.SelectedItem,
                A = (TipoDeConversion)cmbA.SelectedItem,
                
                Resultado = Fabrica.CreateInstance(temp.De).
                ConversionDeTemperatura(temp.Medicion, temp.A),
            };

            resumenServices.Add(resumen);
            
            dataResumen.DataSource = resumenServices.FindAll().ToList();
            dataResumen.Columns[0].Width = 200;
            dataResumen.Columns[4].Width = 200;


        }

        private void CargarDataGridView()
        {
            dataResumen.DataSource = resumenServices.FindAll();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            dataResumen.DataSource = resumenServices.FindAll();
        }

        private void txtTemperatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else

            if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }
    }
}
