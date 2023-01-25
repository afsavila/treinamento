using Dapper;
using System;
using System.Data.SQLite;
using System.IO;
using System.Linq;
//using Tarefas.DTO;


namespace Tarefas.DAO{
    public class TarefaDAO
    {
        private string DataSourceFile => Environment.CurrentDirectory+"TarefasDB.sqlite";
        public SQLiteConnection Connection => new SQLiteConnection ("Datasourse="+DataSourceFile);
    }

    public TarefaDAO()
    {
        if (!File.Exists(DataSourceFile))
        {
            CreateDatabase();
        }
    }

    public void CreateDatabase()
    {
        using (var con = Connection)
        {
        con.Open();
        con.Execute(@"CREATE TABELE Tarefas
                    ( 
                    id intereger primary key autoincrement, 
                    titulo varchar(100), 
                    descricao varchar(100))");
        }            

    }

}