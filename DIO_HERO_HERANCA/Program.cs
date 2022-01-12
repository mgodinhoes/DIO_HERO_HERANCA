using System;

namespace DIO_HERO_HERANCA
{
    class Program
    {
        /// <summary>
        /// Calsse Heói
        /// </summary>
        public class Hero
        {
            public string name { get; set; }
            public int level { get; set; }
            public string heroType { get; set; }

            //Construtor
            public Hero()
            {

            }

            /// <summary>
            /// Construtor personalizado 
            /// </summary>
            /// <param name="name"></param>
            /// <param name="level"></param>
            /// <param name="heroType"></param>
            public Hero(string name, int level, string heroType)
            {
                this.name = name;
                this.level = level;
                this.heroType = heroType;
            }


            //Sobreescreve o método ToString()
            public override string ToString()
            {
                return $"{this.name} {this.level} {this.heroType}.";
            }

            /// <summary>
            /// Método attack
            /// </summary>
            /// <returns></returns>
            public virtual string attack()
            {
                return $"{this.name} atacou com a sua espada.";
            }
        }

        /// <summary>
        /// Classe herdada de heroi
        /// </summary>
        public class Wizard : Hero
        {
            public Wizard(string name, int level, string heroType)
            {
                this.name = name;
                this.level = level;
                this.heroType = heroType;
            }

            /// <summary>
            /// Método attack
            /// </summary>
            /// <returns></returns>
            public override string attack()
            {
                return $"{this.name} atacou com a sua magia.";
            }
        }

        /// <summary>
        /// Método estático da aplicação principal
        /// </summary>
        /// <param name="args"></param>
      
        static void Main(string[] args)
        {
            Hero hero = new Hero("Arus", 2, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");

            Console.WriteLine(hero.attack());
            Console.WriteLine(wizard.attack());
        }
    }
}
