namespace Odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Giriş ekranında Almanya saati yazdırmak için gerekli kod
            var centralEuropeStandartTimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Central Europe Standard Time");
            var centralEuropeStandartTimeAndDate = TimeZoneInfo.ConvertTime(DateTime.Now, centralEuropeStandartTimeZoneInfo);
            var centralEuropeStandartTime = centralEuropeStandartTimeAndDate.TimeOfDay;
            int hour = centralEuropeStandartTime.Hours;
            int minute = centralEuropeStandartTime.Minutes;

            Console.WriteLine("Willkommen bei Germany Bootcamp Company.");
            Console.WriteLine("Zeit: " + hour + ":" + minute);
            Console.WriteLine("Bilgileri Doldurunuz!");

            //Kullanıcıdan bilgilerin alınmaya başlanır.
            Console.Write("Personel Adı:");
            string name = Console.ReadLine();

            //Giriş saati ve çıkış saati bilgisi kullanıcıdan alınır, bu sırada yanlış yazılma ihtimali göz önünde bulundurulur.
            Exception ex = null;
            double startTime = 0;
            double endTime = 0;
            string _startTime;
            string _endTime;
            do
            {
                Console.Write("Giriş Saati (XX:XX):");
                _startTime = Console.ReadLine();
                try
                {
                    startTime = TimeConverter(_startTime);
                    ex = null;
                }
                catch (Exception Ex)
                {
                    Console.WriteLine("HATALI FORMAT!");
                    ex = Ex;
                }
            }
            while (ex != null);

            do
            {
                Console.Write("Çıkış Saati (XX:XX):");
                _endTime = Console.ReadLine();
                try
                {
                    endTime = TimeConverter(_endTime);
                    ex = null;
                }
                catch (Exception Ex)
                {
                    Console.WriteLine("HATALI FORMAT!");
                    ex = Ex;
                }
            }
            while (ex != null);

            //Fazla mesai süresi ve toplam mola süresi saat cinsinden kullanıcıdan alınır.
            Console.Write("Fazla Mesai Süresi (Saat):");
            int overTime = Convert.ToInt32(Console.ReadLine());
            Console.Write("Toplam Mola Süresi (Saat):");
            int breakDuration = Convert.ToInt32(Console.ReadLine());

            //Toplam çalışma süresi hesaplanır ve kesirli saat cinsi yerine, saat ve dakika cinsine dönüştürülür
            double totalWorkTime = (endTime - startTime) - breakDuration;
            double twtMinute = totalWorkTime % 1;
            double twtHour = totalWorkTime - twtMinute;
            twtHour = Convert.ToInt32(twtHour);
            twtMinute = twtMinute * 60;

            //Maaş hesaplanır. Maaş = (Toplam çalışma süresi - Fazla mesai süresi) * (normal mesai ücreti) + (Fazla mesai süresi) * (fazla mesai ücreti)
            double salary = ((totalWorkTime - overTime) * 50) + (overTime * 100);

            //Çalışan nesnesi oluşturulur.
            Employee employee = new Employee(name, _startTime, _endTime, overTime, breakDuration, totalWorkTime, salary);

            //Çalışan bilgileri ve yapılan hesaplama sonuçları ekrana yazdırılır.
            Console.WriteLine("\n\nPersonel Bilgileri");
            Console.WriteLine("Personel Adı: " + employee.name);
            Console.WriteLine("Giriş Saati (XX:XX): " + employee.startTime);
            Console.WriteLine("Çıkış Saati (XX:XX): " + employee.endTime);
            Console.WriteLine("Fazla Mesai Süresi (Saat): " + employee.overTime);
            Console.WriteLine("Toplam Mola Süresi (Saat): " + employee.breakDuration);
            Console.WriteLine("Toplam Çalışma Süresi: {0} saat  {1} dakika",twtHour,twtMinute);
            Console.WriteLine("Günlük Maaş: " + salary);
            Console.WriteLine("Zeit: " + hour + ":" + minute);


        }

        // string cinsinden girilen saati double cinsinden geri döndürür.
        static double TimeConverter(string str)
        {
            int hour = Convert.ToInt32(str.Substring(0, 2));
            double minute = Convert.ToInt32(str.Substring(3, 2));
            double result = hour + (minute / 60);
            return result;
        }



    }

    //Çalışan sınıfı
    class Employee
    {
        public string name { get; }
        public string startTime { get; }
        public string endTime { get; }
        public int overTime { get; }
        public int breakDuration { get; }
        public double totalWorkTime { get; }
        public double salary { get; }

        public Employee
            (string Name, string StartTime, string EndTime,
             int OverTime, int BreakDuration, double TotalWorkTime, double Salary)
        {
            name = Name;
            startTime = StartTime;
            endTime = EndTime;
            overTime = OverTime;
            breakDuration = BreakDuration;
            totalWorkTime = TotalWorkTime;
            salary = Salary;
        }
    }
}