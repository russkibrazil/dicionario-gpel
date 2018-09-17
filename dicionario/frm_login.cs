﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dicionario.Model;

namespace dicionario
{
    public partial class Login : Form
    {
        Usuario usr = new Usuario();
        ConectaBanco conecta = new ConectaBanco("dicionario", "root", "gamesjoker");
        Form saida;
        byte nAcesso;
        enum Nacesso
        {
            ADM, EDT, USR, NOL
        };
        public Login(Form mostrarNaSaida, byte nAcesso = 2, byte log = 3)
        {
            InitializeComponent();
            saida = mostrarNaSaida;
            this.nAcesso = nAcesso;
            /*if(Nacesso.NOL.CompareTo(log) != 0) //se houver login...
            {

            }*/
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private byte ConverteAcesso(string acc)
        {
            if (acc == "ADM")
                return 0;
            else
            {
                if (acc == "EDT")
                    return 1;
                else
                    return 2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            List<string>[] list = new List<string>[1];    
            if (txtusuario.Text == "" || txtsenha.Text == "")
                MessageBox.Show("Usurio e(ou) senha não foram preenchidos. Por favor verifique os campos.");
            else
            {
                list = conecta.Select("usr", Usuario.ToListTabela(), "usr='" + txtusuario.Text + "'AND pass='" + txtsenha.Text + "'");
                if (list[0].Count<string>() == 0)
                {
                    MessageBox.Show("Combinação de usuário e senha não existe.");
                    txtsenha.Text = "";
                }
                else
                {
                    byte a = ConverteAcesso(list[2].ElementAt(0));
                    if (a <= nAcesso)
                    {
                        this.Hide();
                        saida.ShowDialog();
                        saida.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Usuário com privilégios insuficientes. \n Tente outro usuário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saida.Dispose();
            this.Close();
        }
    }
}
