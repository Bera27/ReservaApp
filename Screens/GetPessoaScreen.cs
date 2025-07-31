using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReservaApp.Data;

namespace ReservaApp.Screens
{
    public static class GetPessoaScreen
    {
        public static void Load()
        {
            Console.Clear();
            var context = new ReservaDataContext();

            Console.WriteLine("Informe o nome da pessoa");
            string nomePessoa = Console.ReadLine();
            
            var pessoa = context.Equipamentos.FirstOrDefault(x => x.NomePessoa == nomePessoa);

            if (pessoa == null)
            {
                Console.WriteLine("Pessoa não encontrada!");
                Console.ReadKey();
                Program.Load();
            }

            Console.Clear();
            Console.WriteLine("Pessoa encontrada:");
            Console.WriteLine();
            Console.WriteLine($"ID: {pessoa.Id} - Equipamento: {pessoa.NomeEquipamento} | Reservado por: {pessoa.NomePessoa} na data: ({pessoa.DataReservado:D}) devolução em: ({pessoa.DataDevolucao:D})");
            Console.ReadKey();
            Program.Load();
        }
    }
}