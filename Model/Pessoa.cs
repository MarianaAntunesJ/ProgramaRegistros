using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaRegistros.Model
{
    class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Status { get; set; } = true;
    }
}
