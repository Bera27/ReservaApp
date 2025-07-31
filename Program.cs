
using ReservaApp.Screens;

namespace ReservaApp
{
    class Program
    {
        static void Main(String[] args)
        {
            Load();
        }

        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("O deseja");
            Console.WriteLine();
            Console.WriteLine("1 - Reservar equipamento");
            Console.WriteLine("2 - Devolver equipamento");
            Console.WriteLine("3 - Listar equipamentos reservados");
            Console.WriteLine("4 - Buscar pessoa");
            Console.WriteLine("5 - Atualizar cadastro");
            int resp = int.Parse(Console.ReadLine());

            switch (resp)
            {
                case 1:
                    CreateEquipamentoScreen.Load();
                    break;

                case 2:
                    DeleteEquipamentoScreen.Load();
                    break;

                case 3:
                    ReadEquipamentosScreen.Load();
                    break;

                case 4:
                    GetPessoaScreen.Load();
                    break;
                
                case 5:
                    UpdateEquipamentoScreen.Load();
                    break;
                    
                default: break;
            }
        }
    }
}