using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using dicionario.Helpers;

namespace dicionario.Model
{
    class tabelasBd
    {
        public const string PALAVRA = "palavra";
        public const string MARCAS_USO = "marca_uso";
        public const string REFERENCIAS = "referencias";
        public const string USUARIOS = "usr";
        public const string CONJUGACAO = "conjugacao";
        public const string EQUIVALENTE = "equivalencias";
    }
    internal class ConectaBanco
    {
        protected string servidor;
        protected string bancoDados;
        protected string usuario;
        protected string senha;
        protected string porta;
        protected MySqlConnection conexao;

        public ConectaBanco(string bd = "dicionario", string usr = "root", string pss = "gamesjoker", string svr = "localhost", string porta = "3306")
        {
            string connectionString = "Server=" + svr + ";" + "Port=" + porta + ";Database=" + bd + ";" + "User=" + usr + ";" + "pwd=" + pss + ";";
            conexao = new MySqlConnection(connectionString);
            servidor = svr;
            bancoDados = bd;
            usuario = usr;
            senha = pss;
            this.porta = porta;
        }
        public bool AbreConexao()
        {
            try
            {
                conexao.Open();
                if (conexao.ConnectionString.Contains("localhost"))
                    InformaDiag.Erro("Banco de testes ativo.");
                return true;
            }
            catch (MySqlException ex)
            {
                {
                    switch (ex.Number)
                    {
                        
                        case 0 :
                            InformaDiag.Erro("Falha ao conectar no servidor de dados.");
                            break;
                        case (int)MySqlErrorCode.NoSuchUser:
                            InformaDiag.Erro("A combina��o de usu�rio e senha n�o existe. Tente novamente.");
                            break;
                        default:
                            InformaDiag.Erro("Erro " + ex.Code.ToString() + ex.Message);
                            break;
                    }
                   
                }
                return false;
            }
            catch (InvalidOperationException)
            {
                return false;
            }
        }
        public bool FechaConexao()
        {
            try
            {
                conexao.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                InformaDiag.Erro(ex.Message);
                return false;
            }
        }
        public MySqlConnection PegaConexao()
        {
            return this.conexao;
        }
    }
    class CRUD{
        //private readonly ConectaBanco ControllerBanco = new ConectaBanco("lexdbase","lexdbase","Int3rl3x1c0gr@", "lexdbase.mysql.dbaas.com.br");
        private readonly ConectaBanco ControllerBanco = new ConectaBanco();
        private bool EnviaComando(string query){
            if (ControllerBanco.AbreConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, ControllerBanco.PegaConexao());
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException err) {
                    switch (err.Number)
                    {
                        case (int)MySqlErrorCode.DuplicateKeyEntry:
                            InformaDiag.Erro("O registro j� existe. Tente outros valores");
                            break;

                        default:
                            InformaDiag.Erro("Ocorreu um erro e a opera��o ser� abortada.");
                            break;
                    }
                    cmd.Dispose();
                    return false;
                };
                ControllerBanco.FechaConexao();
                cmd.Dispose();
                return true;
            }
            return false;
        }
        public bool InsereLinha(string tabela, List<string> campos, List<string> valores)
        {
            string s; 
            string query = "INSERT INTO " + tabela + " (";
            foreach (string item in campos)
            {
                query += item;
                query += ", ";
            }
            query = query.Remove(query.Length - 2);
            query += ") VALUES(";
            foreach (string item in valores)
            {
                if (HelperBd.VerificaInt(item)) { //na verdade eu tenho que verificar o Controller e o tipo do campo atual
                    query += item;
                }
                else {
                    if (HelperBd.VerificaBool(item, out s)){
                            query += s;
                    }
                    else {
                        query += "'";
                        query += HelperBd.SanitizaString(item);
                        query += "'";
                    }
                }
                query += ",";
            }
            query = query.Remove(query.Length - 1);
            query += ")";
            if (EnviaComando(query))
                return true;
            else
                return false;

        }
        public bool UpdateLine(string tabela, List<string> campos, List<string> valores, string filtro)
        {
            string query = "UPDATE " + tabela + " SET ";
            string temp1, temp2, s;
            while (campos.Count > 0)
            {
                temp1 = campos.First();
                  temp2 = valores.First();
                query += temp1 + "=";
                 if (HelperBd.VerificaInt(temp2)) { //na verdade eu tenho que verificar o Controller e o tipo do campo atual
                    query += temp2;
                }
                else {
                    if (HelperBd.VerificaBool(temp2, out s)){
                            query += s;
                    }
                    else {
                        query += "'";
                        query += HelperBd.SanitizaString(temp2);
                        query += "'";
                    }
                }
                campos.RemoveAt(0);
                valores.RemoveAt(0);
                if (campos.Count > 0)
                    query += ", ";
            }
            if (filtro != "")
                query += " WHERE " + filtro;
            if (EnviaComando(query))
                return true;
            else
                return false;
        }
        public void ApagaLinha(string tabela, string filtro)
        {
            string query = "DELETE FROM " + tabela + " WHERE " + filtro;
            EnviaComando(query);
        }
        public List<object[]> SelecionarTabela(string tabela, List<string> campos, string filtro = "", string outrosParam = "")
        {
            string query = "SELECT * FROM " + tabela;
            if (filtro != "")
                query += " WHERE " + filtro;
            if (outrosParam != "")
                query += " " + outrosParam;
            List<object[]> resultados = new List<object[]>();
            if (ControllerBanco.AbreConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, ControllerBanco.PegaConexao());
                MySqlDataReader dataReader = cmd.ExecuteReader();
                 //REF HERE https://dev.mysql.com/doc/dev/connector-net/6.10/html/T_MySql_Data_MySqlClient_MySqlDataReader.htm
                 if (dataReader.HasRows){
                    object[] colunas = new object[campos.Count];
                    while(dataReader.Read()){
                        dataReader.GetValues(colunas);
                        resultados.Add(RetornaCopia(colunas, campos.Count));
                    }
                 }
                 dataReader.Close();
                 ControllerBanco.FechaConexao();
                cmd.Dispose();
            }
            return resultados;
        }
        private object[] RetornaCopia (object[] obj, int t)
        {
            object[] o = new object[t];
            obj.CopyTo(o,0);
            return o;
        }
        public void InserirEmMassa(string tabela, string valores, List<string> camposAceitos = null)
        {
            string query = "INSERT INTO " + tabela + " (";
            List<string> t = new List<string>();
            if (camposAceitos == null)
            {
                switch (tabela)
                {
                    case "palavra":
                        t = Palavra.ToListTabela();
                        break;
                    case "rubrica":
                        t = MarcaUso.ToListTabela();
                        break;
                    case "referencias":
                        t = Referencia.ToListTabela();
                        break;
                }
            }
            else
            {
                t = camposAceitos;
            }
            foreach (string s in t)
            {
                query += (s + ",");
            }
            query = query.Remove(query.Count() - 1);
            query += ") VALUES ";
            if (valores.First() == '(')
                query += valores;
            else
                query += ("(" + valores + ");");
            EnviaComando(query);
        }
    }
}
