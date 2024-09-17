using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaAbstrato
{
    public partial class FrmCalcular : Form
    {
        public FrmCalcular()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbForma.Text)
            {
                case "Triangulo":
                    SelecionarTriangulo();
                    break;
                case "Retangulo":
                    SelecionarRetangulo();
                    break;
                case "Quadrado":
                    SelecionarQuadrado();
                    break;
                case "Circunferencia":
                    SelecionarRaio();
                    break;

                default:
                    break;                    
            }
        }
        private void ExibirRaio(bool visible)
        {
            lblRaio.Visible = txtRaio.Visible = visible;
        }

        private void ExibirAltura(bool visible)
        {
            lblAltura.Visible = txtAltura.Visible = visible;
        }

        private void ExibirBase(bool visible)
        {
            lblBase.Visible = txtBase.Visible = visible;
        }

        private void SelecionarTriangulo()
        {
            cmbTipo.Visible = true;
            ExibirBase(true);

            if (cmbTipo.Text.Equals("Equilatero"))
            {
                ExibirAltura(false);
            }
            else
            {
                ExibirAltura(true);
            }

            ExibirRaio(false);

        }
        private void SelecionarRetangulo()
        {
            ExibirBase(true);
            ExibirAltura(true);
            ExibirRaio(false);

            cmbTipo.Visible = false;
        }

        private void SelecionarQuadrado()
        {
            ExibirBase(true);
            ExibirAltura(false);
            ExibirRaio(false);

            cmbTipo.Visible = false;
        }

        private void SelecionarRaio()
        {
            ExibirBase(false);
            ExibirAltura(false);
            ExibirRaio(true);

            cmbTipo.Visible = false;
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelecionarTriangulo();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (cmbForma.Text.Equals("Triangulo"))
            {

                if(cmbTipo.Text.Equals("Equilatero"))
                {
                        Triangulo triangulo = new TrianguloEquilatero()
                        {
                            Base = Convert.ToDouble(txtBase.Text)
                   
                        };
                        cmbObjetos.Items.Add(triangulo);
                }
                else if (cmbTipo.Text.Equals("Isosceles"))
                {
                    Triangulo triangulo = new TrianguloIsosceles()
                    {
                        Base = Convert.ToDouble(txtBase.Text),
                        Altura = Convert.ToDouble(txtAltura.Text)
                    };
                    cmbObjetos.Items.Add(triangulo);
                }
                else if (cmbTipo.Text.Equals("Reto"))
                {
                    Triangulo triangulo = new TrianguloReto()
                    {
                        Base = Convert.ToDouble(txtBase.Text),
                        Altura = Convert.ToDouble(txtAltura.Text)
                    };
                    cmbObjetos.Items.Add(triangulo);
                }

            }

            else if (cmbForma.Text.Equals("Quadrado"))
            {
                FormaGeometrica quadrado = new Quadrado()
                {
                    Lado = Convert.ToDouble(txtBase.Text)
                };
                cmbObjetos.Items.Add(quadrado);

            }

            else if (cmbForma.Text.Equals("Retangulo"))
            {
                FormaGeometrica retangulo = new Retangulo()
                {
                    Base = Convert.ToDouble(txtBase.Text),
                    Alt = Convert.ToDouble(txtAltura.Text)
                };
                cmbObjetos.Items.Add(retangulo);

            }

            else if (cmbForma.Text.Equals("Circunferencia"))
            {
                FormaGeometrica circunferencia = new Circunferencia()
                {
                    Raio = Convert.ToDouble(txtRaio.Text),
                };
                cmbObjetos.Items.Add(circunferencia);

            }

        }

        private void cmbObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormaGeometrica obj = cmbObjetos.SelectedItem as FormaGeometrica;

            txtArea.Text = obj.CalcularArea().ToString();
            txtPerimetro.Text = obj.CalcularPerimetro().ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
                Close();
        }

        private void FrmCalcular_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Atençâo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
