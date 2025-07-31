using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReservaApp.Data;

namespace ReservaApp.Screens
{
    public static class DeleteEquipamentoScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Dovolução de equipamento");
            DeleteEquipamento();
        }

        public static void DeleteEquipamento()
        {
            var context = new ReservaDataContext();

            Console.WriteLine("Informe o nome da pessoa:");
            string buscaPessoa = Console.ReadLine();

            var pessoa = context.Equipamentos.FirstOrDefault(x => x.NomePessoa == buscaPessoa);

            if (pessoa == null)
            {
                Console.WriteLine("Pessoa não encontrada!");
                Console.ReadKey();
                Program.Load();
            }

            Console.Clear();
            Console.WriteLine("Essa é a pessoa desejada? S/N:");
            Console.WriteLine();
            Console.WriteLine($"ID: {pessoa.Id} - Equipamento: {pessoa.NomeEquipamento} | Reservado por: {pessoa.NomePessoa} na data: ({pessoa.DataReservado:D}) devolução em: ({pessoa.DataDevolucao:D})");
            string resp = Console.ReadLine().Substring(0, 1).ToUpper();

            if (resp == "S")
            {
                context.Remove(pessoa);
                context.SaveChanges();
                Console.WriteLine("Equipamento devolvido!");
                Console.ReadKey();
            }

            Program.Load();
        }
    }
}