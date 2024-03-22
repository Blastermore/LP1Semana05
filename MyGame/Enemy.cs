using System;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        public Enemy(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
        }

        public string GetName()
        {
            return name;
        }
        
        public void TakeDamage(float damage)
        {
            shield -= damage;
            if(shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health <0) health = 0;
            }
        }
        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }

        public void SetName(string name)
        {
            int length = 8;
            this.name = name.Substring(0,length);
        }

        public void PickupPowerUp( PowerUp power, float x)
        {
            if (power == PowerUp.Health)
            {
                this.health += x;
                this.health = MathF.Floor(100);
            }
            else if(power == PowerUp.Shield)
            {
                this.shield += x;
                this.shield = MathF.Floor(100);
            }
        }

    }
}