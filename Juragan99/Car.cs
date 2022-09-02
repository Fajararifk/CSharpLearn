using System.Globalization;


namespace Juragan99
{
    internal class Car
    {
        private string noPolisi;
        private int tahun;
        private string type;
        private decimal totalRevenue;
        public Car(string noPolisi, int tahun, string type)
        {
            this.noPolisi = noPolisi;
            this.tahun = tahun;
            this.type = type;
        }
        public string NoPolisi { get => noPolisi; set => noPolisi = value; }
        public int Tahun { get => tahun; set => tahun = value; }
        public string Type { get => type; set => type = value; }
        public decimal TotalRevenue { get => totalRevenue; set => totalRevenue = value; }

        public override string? ToString()
        {
            return $"No Polisi : {this.noPolisi} | Tahun : {this.tahun} | Type : {this.Type} | Total Revenue : {this.totalRevenue.ToString("C", new CultureInfo("id-ID"))}";
        }
    }


}