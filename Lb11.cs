/*
 Описать класс с именем «Поезд», содержащий поля:
-название пункта назначения;
-номер поезда;
-время отправления.
Описать класс с именем «Станция», содержащий поля:
-название станции;
-список поездов, проходящих через станцию (список объектов класса «Поезд»).
Написать программу, выполняющую следующие действия:
-ввод с клавиатуры данных класса типа «Поезд»;
-вывод на экран информации о поездах, отправляющихся после введенного с клавиатуры времени, если таких поездов нет, вывести соответствующее сообщение;
(Реализовать меню, как в первом задание)
*/
using System;
using System.Collections.Generic;
using System.Linq;

class Train
{
    public string Destination { get; set; }
    public int TrainNumber { get; set; }
    public TimeSpan DepartureTime { get; set; }

    public Train(string destination, int trainNumber, TimeSpan departureTime)
    {
        Destination = destination;
        TrainNumber = trainNumber;
        DepartureTime = departureTime;
    }

    public override string ToString()
    {
        return $"Ïîåçä {TrainNumber} äî {Destination} îòïðàâëÿåòñÿ â {DepartureTime}";
    }
}

class Station
{
    public string StationName { get; set; }
    public List<Train> Trains { get; set; }

    public Station(string stationName)
    {
        StationName = stationName;
        Trains = new List<Train>();
    }

    public void AddTrain(Train train)
    {
        Trains.Add(train);
    }

    public void DisplayTrainsAfter(TimeSpan time)
    {
        var trainsAfter = Trains.Where(t => t.DepartureTime > time).OrderBy(t => t.DepartureTime);

        if (trainsAfter.Any())
        {
            Console.WriteLine($"Ïîåçäà, îòïðàâëÿþùèåñÿ ïîñëå {time}:");
            foreach (var train in trainsAfter)
            {
                Console.WriteLine(train);
            }
        }
        else
        {
            Console.WriteLine($"Íåò ïîåçäîâ, îòïðàâëÿþùèõñÿ ïîñëå {time}.");
        }
    }
}

class Program
{
    static List<Train> students = new List<Train>();
    static Station station = new Station("First Station");
    static void Main()
    {
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Ìåíþ:");
            Console.WriteLine("1. Çàïîëíåíèå èíôîðìàöèè î ïîåçäàõ");
            Console.WriteLine("2. Âûâîä íà ýêðàí èíôîðìàöèè î ïîåçäàõ, îòïðàâëÿþùèõñÿ ïîñëå ââåäåííîãî ñ êëàâèàòóðû âðåìåíè");
            Console.WriteLine("3. Âûõîä");
            Console.Write("Âûáåðèòå ïóíêò ìåíþ: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    FillTrains();
                    break;
                case "2":
                    ModifyByFullName();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Íåâåðíûé âûáîð! Ïîïðîáóéòå ñíîâà.");
                    break;
            }

            Console.WriteLine("Íàæìèòå ëþáóþ êëàâèøó äëÿ ïðîäîëæåíèÿ...");
            Console.ReadKey();
        }
    }
    static void FillTrains()
    {
        Console.Write("Ââåäèòå êîëè÷åñòâî ïîåçäîâ: ");
        int trainCount;
        if (int.TryParse(Console.ReadLine(), out trainCount) && trainCount > 0)
        {

            for (int i = 0; i < trainCount; i++)
            {

                Console.WriteLine($"Ââåäèòå äàííûå äëÿ ïîåçäà {i + 1}:");

                Console.Write("Ìåñòî íàçíà÷åíèÿ: ");
                string destination = Console.ReadLine();

                Console.Write("Íîìåð ïîåçäà: ");
                int trainNumber = int.Parse(Console.ReadLine());

                Console.Write("Âðåìÿ îòïðàâëåíèÿ (HH:mm): ");
                TimeSpan departureTime = TimeSpan.Parse(Console.ReadLine());

                station.AddTrain(new Train(destination, trainNumber, departureTime));
            }
        }
        else
        {
            Console.WriteLine("Îøèáêà! Ââåäèòå ïîëîæèòåëüíîå öåëîå ÷èñëî.");
        }
    }
    static void ModifyByFullName()
    {
        Console.Write("Ââåäèòå âðåìÿ äëÿ ïðîâåðêè äâèæåíèÿ ïîåçäîâ ïîñëå (HH:mm): ");
        TimeSpan timeToCheck = TimeSpan.Parse(Console.ReadLine());

        station.DisplayTrainsAfter(timeToCheck);
    }
}




