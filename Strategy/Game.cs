
using System;

namespace WeaponGame
{
    public class Game
    {
        private Player _player;

        public Game()
        {
            _player = new Player(null);
        }

        public void Start()
        {
            Console.WriteLine("Welcome to the Weapon Game!");
            Console.WriteLine("Choose your weapon: 1 - Sword, 2 - Bow, 3 - Axe, 0 - Quit");

            bool playing = true;

            while (playing)
            {
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        _player.SetWeapon(new Sword());
                        Console.WriteLine("You equipped the Sword.");
                        break;
                    case "2":
                        _player.SetWeapon(new Bow());
                        Console.WriteLine("You equipped the Bow.");
                        break;
                    case "3":
                        _player.SetWeapon(new Axe());
                        Console.WriteLine("You equipped the Axe.");
                        break;
                    case "0":
                        Console.WriteLine("Exiting game. Goodbye!");
                        playing = false;
                        continue;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        continue;
                }

                _player.Attack();
            }
        }
    }
}
