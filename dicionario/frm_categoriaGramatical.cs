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
    public partial class frm_categoriaGramatical : Form
    {
        ConectaBanco conexao = new ConectaBanco("dicionario", "root", "gamesjoker");
        CategoriaGramatical CtGr = new CategoriaGramatical();
        public frm_categoriaGramatical()
        {
            InitializeComponent();
        }
    
        private void LimpaCampos() { txtDesc.Text = ""; txtSigla.Text = ""; txtDefine.Text = ""; }
        private void LimpaModel()
        {
            CtGr.descricao = "";
            CtGr.id = -1;
            CtGr.sigla = "";
            CtGr.Definicao = String.Empty;
        }
        private void MostraModel()
        {
            txtDesc.Text = CtGr.descricao;
            txtSigla.Text = CtGr.sigla;
            txtDefine.Text = CtGr.Definicao;
        }
        private bool verificaCampos()
        {
            if (txtDesc.Text == "" || txtSigla.Text == "")
                return true;
            return false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text != CtGr.descricao || txtSigla.Text != CtGr.sigla)
            {
                if (MessageBox.Show("Existem dados não salvos que serão perdidos. \n Deseja continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    return;
            }
            LimpaCampos();
            LimpaModel();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (verificaCampos())
            {
                MessageBox.Show("Existem campos obrigatórios vazios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CtGr.descricao = txtDesc.Text;
            CtGr.sigla = txtSigla.Text;
            CtGr.Definicao = txtDefine.Text;
            if (CtGr.id > 0)
                conexao.UpdateLine("categoriagram", ClasseGramatical.ToListTabela(false), CtGr.ToListValores(), "id=" + CtGr.id.ToString());
            else
                conexao.InsereLinha("categoriagram", ClasseGramatical.ToListTabela(false), CtGr.ToListValores());
            LimpaCampos();
            LimpaModel();
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            if (CtGr.id > 0)
            {
                if (MessageBox.Show("Remover um registro pode afetar vários outros. Recomenda-se observar as dependências antes de continuar" + '\n' + "Prosseguir?", "Confirmação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Esta ação é irreversível! Confirme a exculsão.", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        conexao.ApagaLinha("categoriagram", "Id=" + CtGr.id.ToString());
                        LimpaModel();
                        LimpaCampos();
                    }
                }
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            if (txtSigla.Text != "")
            {
                List<string>[] resultado = conexao.Select("categoriagram", ClasseGramatical.ToListTabela(true), "sigla='" + txtSigla.Text + "'");
                if(resultado[0].Count > 0)
                {
                    List<string> temp = new List<string>();
                    for (int i = 0; i < 3; i++)
                        temp.Add(resultado[i].ElementAt<string>(0));
                    CtGr = (CategoriaGramatical)temp;
                    MostraModel();
                }
                else
                {
                    MessageBox.Show("Nenhum resultado encontrado.", "Busca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
