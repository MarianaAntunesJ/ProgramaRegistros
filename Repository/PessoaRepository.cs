using ProgramaRegistros.DataBase;
using ProgramaRegistros.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramaRegistros.Repository
{
    class PessoaRepository
    {
        //ToDo injeção de dependencia

        public void Cadastrar(Pessoa pessoa)
        {
            using BancoContext context = new BancoContext();
            context.Pessoas.Add(pessoa);
            context.SaveChanges();
        }

        public IEnumerable<Pessoa> PesquisarPorNome(string nome)
        {
            using BancoContext context = new BancoContext();
            return context.Pessoas.Where(_ => _.Nome.Contains(nome)).ToList();
        }

        public IEnumerable<Pessoa> PesquisarPorData(string data)
        {
            using BancoContext context = new BancoContext();
            return context.Pessoas.Where(_ => _.DataNascimento.Date.Equals(DateTime.Parse(data).Date)).ToList();
        }

        public void Editar(Pessoa pessoa)
        {
            if (pessoa.Status)
            {
                using BancoContext context = new BancoContext();
                context.Update(pessoa);
                context.SaveChanges();
            }
            else
                throw new Exception(message: "Cliente inativo.");
        }

        public void Ativar(int id)
        {
            AlterarStatus(id, true);
        }

        public void Inativar(int id)
        {
            AlterarStatus(id, false);
        }

        private void AlterarStatus(int id, bool status)
        {
            using BancoContext context = new BancoContext();
            Pessoa pessoa = context.Pessoas.SingleOrDefault(_ => _.Id == id);
            pessoa.Status = status;
            context.Update(pessoa);
            context.SaveChanges();
        }
    }
}
