using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        int contador = 0;
        int partida = 0;
        string[,] matriz = new string[3, 3];

        private void Form1_Load(object sender, EventArgs e)
        {
            lblJogo.Text = "|     |     |     |\n|     |     |     |\n|     |     |     |\n";
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            if ((txtLinha.Text == "1" || txtLinha.Text == "2" || txtLinha.Text == "3") && (txtColuna.Text == "1" || txtColuna.Text == "2" || txtColuna.Text == "3" ))
            {
                lblJogo.Text = ("");
                int linha = int.Parse(txtLinha.Text) - 1;
                int coluna = int.Parse(txtColuna.Text) - 1;
                contador++;
                partida++;
                string jogador;

                if (contador % 2 == 0)
                {
                    jogador = "O";
                    lblJogador.Text = "X";
                }
                else
                {                   
                    jogador = "X";
                    lblJogador.Text = "O";
                }

                if (matriz[linha, coluna] == null)
                {
                    matriz[linha, coluna] = jogador;
                }
                else
                {
                    partida--;
                    contador-= 2;
                    MessageBox.Show("A posição já está ocupada por: " + jogador);
                }

                lblJogo.Text = ("");

                for (int l = 0; l < matriz.GetLength(0); l++)
                {
                    for (int c = 0; c < matriz.GetLength(1); c++)
                    {
                        if (matriz[l, c] == null)
                        {
                            lblJogo.Text += "|" + "     ";
                        }
                        else
                        {
                            lblJogo.Text += "| " + matriz[l, c] + " ";
                        }
                    }
                    lblJogo.Text += "|" + "\n";
                }
                
                if (matriz[0, 0] == jogador && matriz[1, 0] == jogador && matriz[2, 0] == jogador)
                {
                    lblGanhador.Text = jogador + " Ganhou!";
                    txtLinha.Enabled = false;
                    txtColuna.Enabled = false;
                    btnJogar.Enabled = false;
                }
                if (matriz[0, 1] == jogador && matriz[1, 1] == jogador && matriz[2, 1] == jogador)
                {
                    lblGanhador.Text = jogador + " Ganhou!";
                    txtLinha.Enabled = false;
                    txtColuna.Enabled = false;
                    btnJogar.Enabled = false;
                }
                if (matriz[0, 2] == jogador && matriz[1, 2] == jogador && matriz[2, 2] == jogador)
                {
                    lblGanhador.Text = jogador + " Ganhou!";
                    txtLinha.Enabled = false;
                    txtColuna.Enabled = false;
                    btnJogar.Enabled = false;
                }
                
                if (matriz[0, 0] == jogador && matriz[0, 1] == jogador && matriz[0, 2] == jogador)
                {
                    lblGanhador.Text = jogador + " Ganhou!";
                    txtLinha.Enabled = false;
                    txtColuna.Enabled = false;
                    btnJogar.Enabled = false;
                }
                if (matriz[1, 0] == jogador && matriz[1, 1] == jogador && matriz[1, 2] == jogador)
                {
                    lblGanhador.Text = jogador + " Ganhou!";
                    txtLinha.Enabled = false;
                    txtColuna.Enabled = false;
                    btnJogar.Enabled = false;
                }
                if (matriz[2, 0] == jogador && matriz[2, 1] == jogador && matriz[2, 2] == jogador)
                {
                    lblGanhador.Text = jogador + " Ganhou!";
                    txtLinha.Enabled = false;
                    txtColuna.Enabled = false;
                    btnJogar.Enabled = false;
                }
                
                if (matriz[0, 0] == jogador && matriz[1, 1] == jogador && matriz[2, 2] == jogador)
                {
                    lblGanhador.Text = jogador + " Ganhou!";
                    txtLinha.Enabled = false;
                    txtColuna.Enabled = false;
                    btnJogar.Enabled = false;
                }
                if (matriz[0, 2] == jogador && matriz[1, 1] == jogador && matriz[2, 0] == jogador)
                {
                    lblGanhador.Text = jogador + " Ganhou!";
                    txtLinha.Enabled = false;
                    txtColuna.Enabled = false;
                    btnJogar.Enabled = false;
                }

                if (partida == 9)
                {
                    lblGanhador.Text = "Deu véia";
                    txtLinha.Enabled = false;
                    txtColuna.Enabled = false;
                    btnJogar.Enabled = false;
                }               
            }
            else
            {
                MessageBox.Show("Insira volores válidos para linha e/ou coluna! \n 1 - 2 - 3");
            }

        }

    }
}
