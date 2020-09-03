namespace L2Calc.Common.Models
{
    public class StateCharacteristics
    {
        /// <summary>
        /// Количество специальных боевых очков.
        /// </summary>
        public int CombatPoints { get; set; }
        /// <summary>
        /// Количество здоровья.
        /// </summary>
        public int HealthPoints { get; set; }
        /// <summary>
        /// Количество маны
        /// </summary>
        public int ManaPoints { get; set; }
        /// <summary>
        /// Сила физической атаки.
        /// </summary>
        public int PhysicalAttack { get; set; }
        /// <summary>
        /// Сила магической атаки.
        /// </summary>
        public int MagicalAttack { get; set; }
        /// <summary>
        /// Показатель защиты от физических атак.
        /// </summary>
        public int PhysicalDefence { get; set; }
        /// <summary>
        /// Показатель защиты от магических атак.
        /// </summary>
        public int MagicalDefence { get; set; }
        /// <summary>
        /// Показатель физической точности.
        /// </summary>
        public int PhysicalAccuracy { get; set; }
        /// <summary>
        /// Показатель точности физической атаки.
        /// </summary>
        public int MagicalAccuracy { get; set; }
        /// <summary>
        /// Показатель уклонения от физических атак.
        /// </summary>
        public int PhysicalEvasion { get; set; }
        /// <summary>
        /// Показатель уклонения от магических атак.
        /// </summary>
        public int MagicalEvasion { get; set; }
        /// <summary>
        /// Показатель вероятности нанесения критической физической атаки.
        /// </summary>
        public int CriticalPhysicalAttack { get; set; }
        /// <summary>
        /// Показатель вероятности нанесения критической магической атаки.
        /// </summary>
        public int CriticalMagicalAttack { get; set; }
        /// <summary>
        /// Показатель скорости физической аттаки.
        /// </summary>
        public int SpeedPhysicalAttack { get; set; }
        /// <summary>
        /// Показатель скорости магической атаки.
        /// </summary>
        public int SpeedMagicalAttack { get; set; }
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
