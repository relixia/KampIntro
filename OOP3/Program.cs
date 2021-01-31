using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        //interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız. İmzaları aynı.
        //Yapılan işlemler loglamadır. SMS yollama, veritabanına yazma gibi şeyler loglama.
        static void Main(string[] args)
        {
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager housingCreditManager = new HousingCreditManager();
            ICreditManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            RecourseManager recourseManager = new RecourseManager();
            recourseManager.BasvuruYap(esnafKrediManager, new List<ILoggerService> {new DatabaseLoggerService(), new SmsLoggerService() });

            //line 22'de parantez içinde new list oluşturmak yerine aşağıdaki alternatifi de kullanabilirsin:
            //List<ILoggerService> logger = new List<ILoggerService>() {new SmsLoggerService(), new DatabaseLoggerService() };
            //yukarıdaki kodu yazdıktan sonra line 22'deki kod aşağıdaki gibi olacak:
            //recourseManager.BasvuruYap(esnafKrediManager, loggers);

            List<ICreditManager> krediler = new List<ICreditManager>() {personalFinanceCreditManager, vehicleCreditManager };

            //recourseManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
