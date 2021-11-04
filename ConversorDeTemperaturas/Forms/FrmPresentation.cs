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
                A = (TipoDeConversion)cmbDe.SelectedItem,
                Fecha = DateTime.Now.ToLocalTime(),
                Medicion = decimal.Parse(txtTemperatura.Text),
            };

            temperatureColeccion.Add(temp);

            Resumen resumen = new Resumen()
            {
                De = (TipoDeConversion)cmbDe.SelectedItem,
                A = (TipoDeConversion)cmbDe.SelectedItem,
                Fecha = DateTime.Now.ToLocalTime(),
                Resultado = Fabrica.CreateInstance((TipoDeConversion)cmbDe.SelectedItem).ConversionDeTemperatura(temp.Medicion, (TipoDeConversion)cmbDe.SelectedItem),
            };

            resumenServices.Add(resumen);
        }

        private void CargarDataGridView()
        {
            dataResumen.DataSource = resumenServices.FindAll();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            dataResumen.DataSource = resumenServices.FindAll();
        }
    }
}
