using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Pmatrizes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExercicio1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            string auxiliar = "";

            for (int i = 0; i < vetor.Length; i++)
            {
                auxiliar = Interaction.InputBox($"Digite o {i+1} número ", "Entrada de Dados");

                if (auxiliar == "")
                {
                    break;
                }

                if(!int.TryParse(auxiliar, out vetor[i]))
                {
                    MessageBox.Show("número inválido");
                    i--;
                }
            }
            Array.Reverse(vetor);

            auxiliar = "";

            foreach(int numero in vetor)
            {
                auxiliar += numero + "\n";
            }

            MessageBox.Show($"Os números invertidos são: {auxiliar}");
        }

        private void btnExercicio2_Click(object sender, EventArgs e)
        {
            ArrayList lista = new ArrayList();

            lista.AddRange(new object[] { "Ana", "André", "Beatriz", "Camila", "João", "Joana", "Otávio", "Marcelo", "Pedro", "Thais" });

            lista.Remove("Otávio");

            foreach (int nome in lista)
            {
                MessageBox.Show($"Nome: {nome}");
            }
        }

        private void btnExercicio3_Click(object sender, EventArgs e)
        {
            Double[,] alunosNotas = new Double[20, 3];
            string auxiliar, auxiliar2;

            for (int i = 0; i < 20; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    auxiliar = Interaction.InputBox($"Digite a nota do aluno {i+1} na prova {j + 1}", "Entrada de Dados");

                    if(!double.TryParse(auxiliar, out alunosNotas[i, j]))
                    {
                        MessageBox.Show("Nota inválida");
                        j--;
                    }

                    if(auxiliar == "")
                    {
                        break;
                    }

                    auxiliar2 = $"Aluno {i+1}: {(alunosNotas[i, 1] + alunosNotas[i, 2] + alunosNotas[i, 3]) / 3}\n";
                }
            }

            MessageBox.Show($"");
        }
    }
}
