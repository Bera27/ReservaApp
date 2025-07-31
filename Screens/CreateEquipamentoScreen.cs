using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReservaApp.Data;
using ReservaApp.Models;

namespace ReservaApp.Screens
{
    public static class CreateEquipamentoScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Reserva de equipamentos");
            Console.WriteLine();
            Console.WriteLine("Nome do Equipamento:");
            string nomeEquipamento = Console.ReadLine();

            Console.WriteLine("Nome da pessoa:");
            string nomePessoa = Console.ReadLine();

            Console.WriteLine("Data da Reserva: dd/MM/yyyy");
            DateTime dataReserva = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Data para devolução:");
            DateTime dataDevolucao = DateTime.Parse(Console.ReadLine());

            ReservarEquipamento(new Equipamento
            {
                NomeEquipamento = nomeEquipamento,
                NomePessoa = nomePessoa,
                DataReservado = dataReserva,
                DataDevolucao = dataDevolucao
            });
            Console.ReadKey();
            Program.Load();
        }

        public static void ReservarEquipamento(Equipamento equipamento)
        {
            try
            {
                var context = new ReservaDataContext();

                context.Add(equipamento);
                context.SaveChanges();
                Console.WriteLine("Equipamento reservado");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel reservar!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}