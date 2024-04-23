using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using static System.Globalization.Calendar;

namespace GarageConsoleApp
{
    class Program
    {
        static int ViewSelection()
        {
            int viewSelection = int.Parse(Console.ReadLine());
            return viewSelection;
        }
        static void Main()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1 - Просмотр типов машин\n" +
                                  "2 - Просмотр списка водителей\n" +
                                  "3 - Просмотр машин\n" +
                                  "4 - Просмотр маршрутов\n" +
                                  "5 - Просмотр рейсов\n");
                switch (ViewSelection())
                {
                    case 1:
                        Console.WriteLine();
                        DatabaseRequests.GetTypeCarQuery();
                        Console.WriteLine();
                        Console.WriteLine("Выберите действие:\n" +
                                          "1 - Добавить тип машины\n" +
                                          "2 - Вернуться к прошлому действию");
                        bool looped1 = true;
                        while (looped1)
                        {
                            switch (ViewSelection())
                            {
                                case 1:
                                    string name = Console.ReadLine();
                                    DatabaseRequests.AddTypeCarQuery(name);
                                    break;
                                case 2:
                                    looped1 = false;
                                    break;
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine();
                        DatabaseRequests.GetDriverQuery();
                        Console.WriteLine();
                        Console.WriteLine("Выберите действие:\n" +
                                          "1 - Добавить водителя\n" +
                                          "2 - Вернуться к прошлому действию");
                        bool looped2 = true;
                        while (looped2)
                        {
                            switch (ViewSelection())
                            {
                                case 1:
                                    string firstName = Console.ReadLine();
                                    string lastName = Console.ReadLine();
                                    DateTime date = DateTime.Parse(Console.ReadLine());
                                    DatabaseRequests.AddDriverQuery(firstName,lastName,(date));
                                    break;
                                case 2:
                                    looped2 = false;
                                    break;
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine();
                        DatabaseRequests.GetCarQuery();
                        Console.WriteLine();
                        Console.WriteLine("Выберите действие:\n" +
                                          "1 - Добавить машину\n" +
                                          "2 - Вернуться к прошлому действию");
                        bool looped4 = true;
                        while (looped4)
                        {
                            switch (ViewSelection())
                            {
                                case 1:
                                    int idTypeCar = int.Parse(Console.ReadLine());
                                    string name = Console.ReadLine();
                                    string stateNumber = Console.ReadLine();
                                    int numPassengers = int.Parse(Console.ReadLine());
                                    DatabaseRequests.AddCarQuery(idTypeCar, name,  stateNumber,  numPassengers);
                                    break;
                                case 2:
                                    looped4 = false;
                                    break;
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine();
                        DatabaseRequests.GetItineraryQuery();
                        Console.WriteLine();
                        Console.WriteLine("Выберите действие:\n" +
                                          "1 - Добавить маршрут\n" +
                                          "2 - Вернуться к прошлому действию");
                        bool looped5 = true;
                        while (looped5)
                        {
                            switch (ViewSelection())
                            {
                                case 1:
                                    string name = Console.ReadLine();
                                    DatabaseRequests.AddItineraryQuery(name);
                                    break;
                                case 2:
                                    looped5 = false;
                                    break;
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine();
                        DatabaseRequests.GetRouteQuery();
                        Console.WriteLine();
                        Console.WriteLine("Выберите действие:\n" +
                                          "1 - Добавить рейс\n" +
                                          "2 - Вернуться к прошлому действию");
                        bool looped6 = true;
                        while (looped6)
                        {
                            switch (ViewSelection())
                            {
                                case 1:
                                    int driverId = int.Parse(Console.ReadLine());
                                    int carId = int.Parse(Console.ReadLine());
                                    int itineraryId = int.Parse(Console.ReadLine());
                                    int numPassengers = int.Parse(Console.ReadLine());
                                    DatabaseRequests.AddRouteQuery(driverId, carId, itineraryId, numPassengers);
                                    break;
                                case 2:
                                    looped6 = false;
                                    break;
                            }
                        }
                        break;
                }
            }
        }
    }
}