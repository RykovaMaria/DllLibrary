using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace DllLibrary
{
    public class Team
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Player> Players = new List<Player>();
        
        public Team(string name, string address)
        {
            Name = name;
            Address = address;
        }

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

    public class Player : IComparable<Player>
    { 
        public string Name { get; set; }
        public string Description { get; set; }

        public Player(string name, string description)
        {
            Name = name;
            Description = description;
        }

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
