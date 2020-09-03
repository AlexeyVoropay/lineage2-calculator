namespace L2Calc.Common.Models
{
    public class StateCharacteristics
    {
        /// <summary>
        /// Количество специальных боевых очков.
        /// </summary>
        public int CompbatPoints { get; set; }
        /// <summary>
        /// Количество здоровья.
        /// </summary>
        public int HealthPoints { get; set; }
        /// <summary>
        /// Количество маны
        /// </summary>
        public int ManaPoints { get; set; }
        /// <summary>
        /// Сила атаки.
        /// </summary>
        public int PowerAttack { get; set; }

        /*
         PowerAttack.	The power of your character's physical attack.
M. Atk.	The power of your character's magical attack.
P. Def.	The value of defence against physical attacks.
M. Def.	The value of defence against magical attacks.
P. Accuracy	P. Accuracy affects your accuracy for physical attacks
M. Accuracy	M. Accuracy affects your accuracy for magical attacks
P. Evasion	P. Evasion affects your ability to evade from P. attacks.
M. Evasion	M. Evasion affects your ability to evade from M. attacks.
P. Crit. Atk.	Chance to deliver a critical blow for physical attacks.
M. Crit. Atk.	Chance to deliver a critical blow for magical attacks.
Atk Spd.	The speed of P. Atk of your character.
Speed of Magical skills usage.
Speed
          */

        /// <summary>
        /// Скорость бега
        /// </summary>
        public int SpeedRun { get; set; }

        /// <summary>
        /// Скорость хотьбы
        /// </summary>
        public int SpeedWalk { get; set; }
    }
}
