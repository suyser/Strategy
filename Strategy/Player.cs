

namespace WeaponGame
{
    public class Player
    {
        private IWeapon _weapon;

        public Player(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public void SetWeapon(IWeapon weapon)
        {
            _weapon = weapon;
            Console.WriteLine("You have switched your weapon.");
        }

        public void Attack()
        {
            if (_weapon != null)
                _weapon.UseWeapon();
            else
                Console.WriteLine("No weapon equipped. Choose a weapon first!");
        }
    }
}
