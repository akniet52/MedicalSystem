using MedicalSystem.Users;
using MedicalSystem.Spravki;
using MedicalSystem.Interfaces;
using MedicalSystem.Buhgalteria;
using MedicalSystem.Notifications;

Patient patient = new Patient("Aktan", "Asanov", "+996 555 123 456", "A+");
patient.DisplayInfo();

Spravka83 spravka83 = new Spravka83
{
    SpravkaName = "Spravka 83",
    Patient = patient,
    Price = 500
};

Spravka67 spravka67 = new Spravka67(6)
{
    SpravkaName = "Spravka 67",
    Patient = patient,
    Price = 670
};

SpravkaSanknijka spravkaSanknijka = new SpravkaSanknijka
{
    SpravkaName = "Spravka Sanknijka",
    Patient = patient,
    Price = 1000,
    AnalysisCount = 3
};

List<ISpravka> spravkiList = 
    new List<ISpravka> { spravka83, spravka67, spravkaSanknijka };

foreach (ISpravka spravka in spravkiList)
{
    Console.WriteLine(spravka.GetShortInfo() + "\n");
}

foreach (var spravka in spravkiList)
{
    spravka.DisplayInfo();
    Console.WriteLine($"Total Price: {spravka.CalculatePrice()}");
    Console.WriteLine();
}

Kassa kassa = new Kassa();

decimal totalAmount = kassa.Total(spravkiList);

//Console.WriteLine($"Total Amount in Kassa: {totalAmount}");

kassa.PrintCheck(spravkiList);

Console.Write("Как уведомить пациента? 1 - SMS, 2 - Email, 3 - Telegram: ");
string choice = Console.ReadLine();

INotifier notifier;

if (choice == "1")
{
    notifier = new SmsNotifier();
}
else if (choice == "2")
{
    notifier = new EmailNotifier();
}
else
{
    notifier = new TelegramNotifier();
}

notifier.Send(patient, "Ваша справка готова");