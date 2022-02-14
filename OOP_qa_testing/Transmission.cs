using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_qa_testing
{
    class Transmission
    {
        //тип, количество передач, производитель
        private string TransmissionType;
        private string TransmissionNumber;
        private string TransmissionProducer;

        public Transmission(string transmissinType, string transmissionNumber, string transmissionProducer)
        {
            TransmissionType = transmissinType;
            TransmissionNumber = transmissionNumber;
            TransmissionProducer = transmissionProducer;
        }
        public void PrintTransmission()
        {
            Console.WriteLine($"Type {TransmissionType}\t Number {TransmissionNumber}\t Producer {TransmissionProducer}");
        }
    }
 }
