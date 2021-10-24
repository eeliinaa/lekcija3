using System;
using System.Collections.Generic;
using System.Text;

namespace lekcija3._1
{
    public class Car
    {
        private decimal speed;
        private string brand;
        private string number;

        public decimal Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Number
        {
            get { return number; }
            set { number = value; }
        }


        public void PlaySound()
        {
            Console.WriteLine("Beep Beep!");
        }
        public void StartMovement()
        {
            speed = 10;
        }
        public void StopMovement()
        {
            speed = 0;
        }
        public void IncreaseSpeed(decimal speedToAdd)
        {
            speed += speedToAdd;
        }
        public void ReduceSpeed(decimal speedToRecude)
        {
            var resultSpeed = speed - speedToRecude;
            speed = resultSpeed < 0 ? 0 : resultSpeed;
        }
    }
}
