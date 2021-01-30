using ProgramaRegistros.Controller;
using ProgramaRegistros.View;
using System;

namespace ProgramaRegistros
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaView view = new PessoaView();

            view.Menu();
        }
    }
}
