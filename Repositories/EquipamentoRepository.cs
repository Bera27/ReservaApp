using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReservaApp.Data;
using ReservaApp.Models;

namespace ReservaApp.Repositories
{
    public class EquipamentoRepository
    {
        public void Create(Equipamento equipamento)
        {
            var context = new ReservaDataContext();

            context.Add(equipamento);
            context.SaveChanges();
        }

        public void GetPessoa(string nomePessoa)
        {
            var context = new ReservaDataContext();
            var pessoa = context.Equipamentos.FirstOrDefault(x => x.NomePessoa == nomePessoa);

            if (pessoa == null)
            {
                Console.WriteLine("Pessoa não encontrada!");
                Console.ReadKey();
                Program.Load();
            }

            Console.WriteLine("Pessoa encontrada:");
            Console.WriteLine();
            Console.WriteLine($"ID: {pessoa.Id} - Equipamento: {pessoa.NomeEquipamento} | Reservado por: {pessoa.NomePessoa} na data: ({pessoa.DataReservado:D}) devolução em: ({pessoa.DataDevolucao:D})");
            Console.ReadKey();
            Program.Load();

        }
    }
}