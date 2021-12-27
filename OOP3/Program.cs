// See https://aka.ms/new-console-template for more information
using OOP3;

Console.WriteLine("Hello, World!");


IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();
IKrediManager esnafKrediManager = new EsnafKrediManager();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();
ILoggerService smsLoggerService = new SmsLoggerService();

List<ILoggerService> loggerServices = new List<ILoggerService>() { databaseLoggerService, fileLoggerService, smsLoggerService };


BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(ihtiyacKrediManager, new List<ILoggerService> { new DatabaseLoggerService(), fileLoggerService });
basvuruManager.BasvuruYap(tasitKrediManager, loggerServices);
basvuruManager.BasvuruYap(konutKrediManager, new List<ILoggerService> { databaseLoggerService });
basvuruManager.BasvuruYap(new EsnafKrediManager(), new List<ILoggerService> { new SmsLoggerService() });
basvuruManager.BasvuruYap(esnafKrediManager, new List<ILoggerService> { smsLoggerService });





List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager, konutKrediManager, esnafKrediManager };
basvuruManager.KrediOnBilgilendirmesiYap(krediler);
