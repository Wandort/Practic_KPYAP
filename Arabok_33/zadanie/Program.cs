using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task
{
    class Program
    {
        static void Main()
        {
            using (var db = new YourDbContext())
            {
                var tourists = db.Tourists.ToList();

                Console.WriteLine("Список туристов:");
                foreach (var tourist in tourists)
                {
                    Console.WriteLine($"ID: {tourist.TouristId}, Фамилия: {tourist.LastName}, Имя: {tourist.FirstName}, Отчество: {tourist.MiddleName}, ID тура: {tourist.TourId}");
                }
            }
        }
    }
}
