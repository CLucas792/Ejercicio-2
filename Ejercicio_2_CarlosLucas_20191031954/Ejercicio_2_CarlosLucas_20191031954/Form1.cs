using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2_CarlosLucas_20191031954
{
    public partial class Ejercicio2_CarlosLucasForm : Form
    {
        public Ejercicio2_CarlosLucasForm()
        {
            InitializeComponent();
        }

        bool cont;
        private async void Calcularbutton_Click(object sender, EventArgs e)
        {
            ValidarDatos();
            if (cont==true)
            {
            decimal primerP = Convert.ToDecimal(PrimerPtextBox.Text);
            decimal segundoP = Convert.ToDecimal(SegundoPtextBox.Text);
            decimal tercerP = Convert.ToDecimal(TercerPtextBox.Text);
            decimal cuartoP = Convert.ToDecimal(CuartoPtextBox.Text);

            decimal Promedio = await CalcularPromedioAsync(primerP, segundoP, tercerP, cuartoP);

            AgregarALista(Promedio);
            MessageBox.Show("El alumno:"+ NombretextBox.Text+" Tiene un promedio de:"+ Promedio);
            LimpiarControles();
            }

        }

        private void ValidarDatos()
        {
            cont = false;
            if (NombretextBox.Text == "")
            {
                errorProvider1.SetError(NombretextBox, "Debe ingresar un dato");
                return;
            }
            else
            {
                errorProvider1.Clear();

            }
            if (PrimerPtextBox.Text=="")
            {
                errorProvider1.SetError(PrimerPtextBox, "Debe ingresar un dato");
                return;
            }
            else
            {
                errorProvider1.Clear();
              
            }

            if (SegundoPtextBox.Text == "")
            {
                errorProvider1.SetError(SegundoPtextBox, "Debe ingresar un dato");
                return;
            }
            else
            {
                errorProvider1.Clear();
               
            }

            if (TercerPtextBox.Text == "")
            {
                errorProvider1.SetError(TercerPtextBox, "Debe ingresar un dato");
                return;
            }
            else
            {
                errorProvider1.Clear();
                
            }

            if (CuartoPtextBox.Text == "")
            {
                errorProvider1.SetError(CuartoPtextBox, "Debe ingresar un dato");
                return;
            }
            else
            {
                errorProvider1.Clear();
                
            }
            
            cont = true;
            
        }

        private void LimpiarControles()
        {
            PrimerPtextBox.Clear();
            SegundoPtextBox.Clear();
            TercerPtextBox.Clear();
            CuartoPtextBox.Clear();
            NombretextBox.Clear();
        }

        private void AgregarALista(decimal prom)
        {
            CalificacionesdataGridView.Rows.Add(NombretextBox.Text,PrimerPtextBox.Text, SegundoPtextBox.Text, 
                TercerPtextBox.Text,CuartoPtextBox.Text,prom.ToString());
        }

        private async Task<decimal> CalcularPromedioAsync(decimal primerP, decimal segundoP, decimal tercerP, decimal cuartoP)
        {
            decimal promedio = await Task.Run(() =>
            {
                return ((primerP+segundoP+tercerP+cuartoP)/4);
            });
            return promedio;
        }
    }
}
