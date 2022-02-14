using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_qa_testing
{
    class Engine
    {
        //мощность, объем, тип, серийный номер
        private int Power_;
        private double Volume_;
        private string EngineType_;
        private string SerialNumber;

        public Engine(int power_, double volume_, string engineType_, string serialNumber)
        {
            Power_ = power_;
            Volume_ = volume_;
            EngineType_ = engineType_;
            SerialNumber = serialNumber;
        }

        public void PrintEngine()
        {
            Console.WriteLine($"Power {Power_}\t Volume {Volume_}\t Engine {EngineType_}\t Serial Nuber {SerialNumber}");
        }
    }
}
