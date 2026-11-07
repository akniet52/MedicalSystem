using System;
using MedicalSystem.Interfaces;
using MedicalSystem.Users;

namespace MedicalSystem.Notifications
{
    internal class SmsNotifier : INotifier
    {
        public void Send(Patient patient, string message)
        {
            Console.WriteLine($"SMS для {patient.Name}: {message}");
        }
    }
}