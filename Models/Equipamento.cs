using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservaApp.Models
{
    public class Equipamento
    {
        public int Id { get; set; }
        public string NomeEquipamento { get; set; }
        public string NomePessoa { get; set; }
        public DateTime DataReservado { get; set; }
        public DateTime DataDevolucao { get; set; }
    }
}