using System;
using MedicalSystem.Interfaces;
using MedicalSystem.Users;

namespace MedicalSystem.Notifications
{
    internal class EmailNotifier : INotifier
    {
        public void Send(Patient patient, string message)
        {
            Console.WriteLine($"Email для {patient.Name}: {message}");
        }
    }
}