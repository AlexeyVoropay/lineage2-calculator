using L2Calc.Common.Enums;

namespace L2Calc.Common.Models
{
    public class Item
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public string Id { get; set; }
        public ItemCode Code { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }
        public string EngName { get; set; }
        public string Note { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        /// <summary>
        /// Вес
        /// </summary>
        public long Weight { get; set; }
        /// <summary>
        /// Время существования
        /// </summary>
        public long Lifetime { get; set; }
        /// <summary>
        /// Базовая цена
        /// </summary>
        public long Price { get; set; }
        /// <summary>
        /// Базовая цена
        /// </summary>
        public long RedPrice { get; set; }
        /// <summary>
        /// Базовая цена
        /// </summary>
        public long GreenPrice { get; set; }

        public StatBonus StatBonus { get; set; }
    }
}