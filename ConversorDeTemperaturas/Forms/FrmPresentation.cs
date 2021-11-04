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
            try
            {

                if (cmbA.SelectedIndex < 0 || cmbDe.SelectedIndex < 0)
                {
                    throw new Exception("Por favor, seleccione la conversion que desea");
                }

                if (txtTemperatura.Text == string.Empty)
                {
                    throw new Exception("Por favor, rellene el campo temperatura");
                }

                if (Decimal.TryParse(txtTemperatura.Text, out decimal p) == false)
                {
                    throw new Exception("Por favor, ingrese solo numeros");
                }

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

                    // Cree una fabrica de objetos que funcioan con los comboxs 
                    // Primero selecciono cual es la medicion que quiere convertir 

                    Resultado = Fabrica.CreateInstance(temp.De).
                    ConversionDeTemperatura(temp.Medicion, temp.A),
                };

                resumenServices.Add(resumen);

                dataResumen.DataSource = resumenServices.FindAll().ToList();
                dataResumen.Columns[0].Width = 200;
                dataResumen.Columns[4].Width = 200;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void CargarDataGridView()
        {
            dataResumen.DataSource = resumenServices.FindAll();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {

                if (cmbDeResumen.SelectedIndex < 0 || cmbAresumen.SelectedIndex < 0)
                {
                    throw new Exception("Por favor, seleccione la consulta que desea");
                }

                var a = resumenServices.GetByDeA((TipoDeConversion)cmbDeResumen.SelectedItem, (TipoDeConversion)cmbAresumen.SelectedItem);
                dataResumen.DataSource = a;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTemperatura_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
