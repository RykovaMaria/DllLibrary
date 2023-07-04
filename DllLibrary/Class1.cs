using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

//Рыкова Мария 22ИС
namespace DllLibrary
{
    //Реализован класс Команда
    public class Team
    {
        //Свойства класса Команда
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Player> Players = new List<Player>();
        
        //Конструктор
        public Team(string name, string address)
        {
            Name = name;
            Address = address;
        }

        //Метод, позволяющий вывести информацию о команде и игроках
        public void ShowAll()
        {
            Console.WriteLine($"Информация о команде:\n" + 
                $"Название: {Name}\n" +
                $"Адрес: {Address}\n\n" +
                "Состав команды:");

            Players.Sort();
            foreach (Player p in Players)
            {
                p.Show();
            }
        }
    }

    //Реализован класс Игрок
    public class Player : IComparable<Player>
    { 
        //Свойства класса Игрок
        public string Name { get; set; }
        public string Description { get; set; }

        //Конструктор
        public Player(string name, string description)
        {
            Name = name;
            Description = description;
        }

        //Методы выода и сравнения класса Игрок
        public void Show()
        {
            Console.WriteLine($"- Имя игрока: {Name}\n"+ $"- Описание: {Description}\n");
        }

        public int CompareTo(Player other)
        {
            return Name.CompareTo(other.Name);
        }

    }
}
