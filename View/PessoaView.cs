using ProgramaRegistros.Controller;
using System;
using System.Collections.Generic;
using System.Text;


namespace ProgramaRegistros.View
{
    class PessoaView
    {
        PessoaController controller = new PessoaController();

        public void Menu()
        {
            int opcao = -1;
            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Pesquisar");
                Console.WriteLine("3 - Alterar");
                Console.WriteLine("4 - Inativar");
                Console.WriteLine("5 - Ativar");
                Console.WriteLine("0 - Sair");
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Opção inválida, digite novamente.");
                    continue;
                }
                switch (opcao)
                {
                    case 1:

                }
                
            } while (opcao != 0);
        }
        

    }
}
