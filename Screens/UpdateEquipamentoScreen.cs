using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReservaApp.Data;

namespace ReservaApp.Screens
{
    public static class UpdateEquipamentoScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizar Cadastro:");
            Console.WriteLine();
            UpdateEquipamento();
        }

        public static void UpdateEquipamento()
        {
            var context = new ReservaDataContext();

            Console.WriteLine("Informe o nome da pessoa");
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
                Console.Clear();
                Console.WriteLine("Informe os novos dados:");
                Console.WriteLine();
                Console.WriteLine("Nome do equipamento:");
                string nomeEquipamento = Console.ReadLine();

                Console.WriteLine("Nome da Pessoa:");
                string nomePessoa = Console.ReadLine();

                Console.WriteLine("Data da Reserva: dd/MM/yyyy");
                DateTime dataReservado = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Data da Devolução: dd/MM/yyyy");
                DateTime dataDevolucao = DateTime.Parse(Console.ReadLine());

                pessoa.NomeEquipamento = nomeEquipamento;
                pessoa.NomePessoa = nomePessoa;
                pessoa.DataReservado = dataReservado;
                pessoa.DataDevolucao = dataDevolucao;

                context.Update(pessoa);
                context.SaveChanges();

                Console.WriteLine("Cadastro atualizado!");
                Console.ReadKey();
            }

            Console.WriteLine("Voltando...");
            Program.Load();
        }
    }
}