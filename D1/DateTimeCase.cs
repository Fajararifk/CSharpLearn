namespace D1
{
    internal class DateTimeCase
    {
        public static void DateTimeCases()
        {
            DateTime now = DateTime.Now;

            int day = now.Day;
            int month = now.Month;
            int year = now.Year;
            int hour = now.Hour;
            int minute = now.Minute;
            int second = now.Second;

            // only date
            DateTime onlyDate = now.Date;
            Console.WriteLine($"Only Date : {onlyDate}");

            // dayOfWeek
            DayOfWeek dayOfWeek = now.DayOfWeek;
            Console.WriteLine($"{ dayOfWeek}");
            // Kamis
            DayOfWeek kamis = DayOfWeek.Thursday;
            Console.WriteLine($"{kamis}");

            // addDays
            DateTime tomorrow = now.AddDays(2);

            // selisih hari
            TimeSpan dateDifference = tomorrow - now;
            Console.WriteLine(dateDifference);
            int daysRemaining = dateDifference.Days;
            Console.WriteLine($"{now} - {tomorrow}, selisih : {daysRemaining}");


            // menyimpan store spesifik date
            DateTime birtday = new DateTime(1998, 07, 28);
            Console.WriteLine(birtday);
        }
    }
}