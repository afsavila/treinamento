using Dapper;
using System;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using Tarefas.DTO;


namespace Tarefas.DAO{
    public class TarefaDAO
    {
        public string DataSourceFile => Evironment.CurrentDirectory+"TarefasDB.sqlite";
        public SQLiteConnection Connection = new SQLiteConnection ("Datasourse="+DataSourceFile);
    }

    public TarefaDAO()
    {
        if (!file.Exists(DatasourceFile))
        {
            CreateDatabase();
        }
    }

    public void CreateDatabase()
    {
        using (var con = Connection());
        con.Open();
        con.Execute(@"create table Tarefas 
                    id intereger primary key autoincrement, 
                    titulo varchar(100), 
                    descricao varchar(100)")

    }

}