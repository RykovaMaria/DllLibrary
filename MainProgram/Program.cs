using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DllLibrary;

namespace MainProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team("Крыски", "м. Бабушкинская");

            team.Players.Add(new Player("Алина Пономарева", "Превосходный лидер команды"));
            team.Players.Add(new Player("Светлана Стаханова", "Отменно играет"));
            team.Players.Add(new Player("Захар Черниченко", "Ему нужен связующий"));
            team.Players.Add(new Player("Андрей Сахаров", "Связующий"));
            team.Players.Add(new Player("Мария Рыкова", "Боится мяча"));

            team.ShowAll();

            Console.ReadLine();
        }
    }
}
