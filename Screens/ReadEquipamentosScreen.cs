using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReservaApp.Data;

namespace ReservaApp.Screens
{
    public static class ReadEquipamentosScreen
    {
        public static void Load()
        {
            var context = new ReservaDataContext();
            var equipamentos = context.Equipamentos.AsNoTracking().ToList();

            Console.WriteLine("Lista de Equipamentos reservados:");

            foreach (var e in equipamentos)
            {
                Console.WriteLine($"ID: {e.Id} - Equipamento: {e.NomeEquipamento} | Reservado por: {e.NomePessoa} na data: ({e.DataReservado:D}) devolução em: ({e.DataDevolucao:D})");
                Console.WriteLine("--------------------------------------------------------------------------");
            }
            Console.ReadKey();
            Program.Load();
        }
    }
}