using ProgramaRegistros.Model;
using ProgramaRegistros.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaRegistros.Controller
{
    class PessoaController
    {
        public void A()
        {
            /*Pessoa pessoa1 = new Pessoa();

            pessoa1.Id = 1;
            pessoa1.Nome = "mari2";
            pessoa1.DataNascimento = DateTime.Parse("1997/09/20");*/

            PessoaRepository repository = new PessoaRepository();
            //repository.Editar(pessoa1);
            repository.Inativar(1);
        }
    }
}