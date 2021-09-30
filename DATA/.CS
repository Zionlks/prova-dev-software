using API.models;
using Microsoft.entityFrameworkCore;

namespace Api.DATA

{
    public class DataContext : dbcontext
    {


        public DataContext(dbcontextoptions<DataContext> option) : base(option) {}

        public dbset<aluno> Alunos { get; set;}       

    }



}

