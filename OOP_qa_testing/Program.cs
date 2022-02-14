using System;

namespace OOP_qa_testing
{
    class Program
    {
        static void Main(string[] args)
        {
            /*С использованием этих классов реализовать сущности "Легковой автомобиль", "Грузовик", "Автобус", "Скутер" 
             * (отличающиеся уникальными полями), и обеспечить вывод полной информации об объектах этих типов.*/
            Engine car = new Engine(2000, 1.6, "Two-tire", "CAR152634");
            Engine track = new Engine(3000, 5.6, "Three-tire", "TRACK152634");
            Engine bus = new Engine(2500, 4.6, "Three-tire", "BUS152634");
            Engine scooter = new Engine(500, 1.2, "One-tire", "SCTR152634");
            car.PrintEngine();
            track.PrintEngine();
            bus.PrintEngine();
            scooter.PrintEngine();

            Transmission carTr = new Transmission("Automatic", "42RE", "Aisin");
            Transmission trackTr = new Transmission("Mechanical", "46RH", "Aisin");
            Transmission busTr = new Transmission("Mechanical", "AW4", "Jatco");
            Transmission scooterTr = new Transmission("Automatic", "XX8", "ZF");
            carTr.PrintTransmission();
            trackTr.PrintTransmission();
            busTr.PrintTransmission();
            scooterTr.PrintTransmission();

            Chassis carCh = new Chassis(4, "CR12456789", 200);
            Chassis trackCh = new Chassis(4, "TRCK12345678", 5000);
            Chassis busCh = new Chassis(4, "BSK12345678", 1000);
            Chassis scooterCh = new Chassis(2, "SCTR12345678", 100);
            carCh.PrintChassis();
            trackCh.PrintChassis();
            busCh.PrintChassis();
            scooterCh.PrintChassis();
        }
    }
}
