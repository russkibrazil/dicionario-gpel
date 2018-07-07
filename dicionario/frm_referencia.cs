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
    public partial class frm_referencia : Form
    {
        ConectaBanco conexao = new ConectaBanco("dicionario", "root", "gamesjoker");
        Referencia referencia = new Referencia();
        public frm_referencia()
        {
            InitializeComponent();
        }
        private void LimpaCampos() {
            txtAno.Text = "";
            txtDesc.Text = "";
            txtAutor.Text = "";
            txtCod.Text = "";
        }
        private void LimpaModel()
        {
            referencia.descricao = "";
            referencia.ano = 0;
            referencia.autor = "";
            referencia.Cod = -1;
        }
        private void MostraModel() {
            txtDesc.Text = referencia.descricao;
            txtAno.Text = referencia.ano.ToString();
            txtAutor.Text = referencia.autor;
            txtCod.Text = referencia.Cod.ToString();
        }
        private bool verificaCampos()
        {
            if (txtAutor.Text == "" || txtAno.Text == "")
                return true;
            return false;
        }
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            List<string>[] resultado = conexao.Select("referencias", Referencia.ToListTabela(true), "Cod=" + txtCod.Text);
            if (resultado[0].Count > 0) {
                //tratar resultado antes de continuar
                List<string> temp = new List<string>();
                for (int i = 0; i<4; i++)
                    temp.Add(resultado[i].ElementAt<string>(0));
                referencia = (Referencia) temp;
                MostraModel();
                
            } else {
                MessageBox.Show("Nenhum resultado encontrado.", "Busca", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void txtCod_Leave(object sender, EventArgs e)
        {
            if (txtCod.Text != "" && txtCod.ReadOnly == false)
            {
                btnApaga.Enabled = false;
                btnSalva.Enabled = false;
                txtAno.Enabled = false;
                txtAutor.Enabled = false;
                txtDesc.Enabled = false;
            }
            else {
                btnApaga.Enabled = true;
                btnSalva.Enabled = true;
                txtAno.Enabled = true;
                txtAutor.Enabled = true;
                txtDesc.Enabled = true;
            }
        }
        private void TravaCod(object sender, EventArgs e)
        {
            if (txtAno.Text != "" || txtAutor.Text != "" || txtDesc.Text != "")
                txtCod.ReadOnly = true;
            else
                txtCod.ReadOnly = false;
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text != referencia.descricao || txtAno.Text != referencia.ano.ToString() || txtAutor.Text != referencia.autor)
            {
                if (MessageBox.Show("Existem dados não salvos que serão perdidos. \n Deseja continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    return;
            }
            LimpaCampos();
            LimpaModel();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text == "" || txtAno.Text == "" || txtAutor.Text == "")
            {
                MessageBox.Show("Existem campos obrigatórios vazios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            referencia.descricao = txtDesc.Text;
            referencia.ano = int.Parse(txtAno.Text);
            referencia.autor = txtAutor.Text;
            if (referencia.Cod > 0)
                conexao.UpdateLine("referencias", Referencia.ToListTabela(false), referencia.ToListValores(), "Cod=" + referencia.Cod.ToString());
            else
                conexao.InsereLinha("referencias", Referencia.ToListTabela(false), referencia.ToListValores());
            LimpaCampos();
            LimpaModel();
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            if (referencia.Cod > 0)
            {
                if (MessageBox.Show("Remover um registro pode afetar vários outros. Recomenda-se observar as dependências antes de continuar" + '\n' + "Prosseguir?", "Confirmação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Esta ação é irreversível! Confirme a exculsão.", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        conexao.ApagaLinha("referencias", "Cod=" + referencia.Cod.ToString());
                        LimpaModel();
                        LimpaCampos();
                    }
                }
            }
        }
    }
}