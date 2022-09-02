using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juragan99
{
    internal class Taxi : Car
    {
        private int order;
        private decimal orderPerKM;
        private int totalKM;
        private decimal bonus;

        public Taxi(string noPolisi, int tahun, string type, int order, decimal orderPerKM, int totalKM, decimal bonus) : base(noPolisi, tahun, type)
        {
            this.Order = order;
            this.OrderPerKM = orderPerKM;
            this.TotalKM = totalKM;
            this.Bonus = bonus;
            TotalRevenue = (order * bonus) + (orderPerKM * totalKM);
        }

        public int Order { get => order; set => order = value; }
        public decimal OrderPerKM { get => orderPerKM; set => orderPerKM = value; }
        public int TotalKM { get => totalKM; set => totalKM = value; }
        public decimal Bonus { get => bonus; set => bonus = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} | Order : {this.order} | Order PerKM : {this.orderPerKM} | Total KM : {this.totalKM} | Bonus : {this.bonus}";
        }
    }
}
