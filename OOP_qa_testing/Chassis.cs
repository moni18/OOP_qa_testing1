using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_qa_testing
{
    class Chassis
    {
        //количество колес, номер, допустимая нагрузка
        private int Wheels;
        private string NumberOfChassis;
        private int Load;

        public Chassis(int wheels, string numberOfChassis, int load)
        {
            Wheels = wheels;
            NumberOfChassis = numberOfChassis;
            Load = load;
        }

        public void PrintChassis()
        {
            Console.WriteLine($"Number of wheels {Wheels}\t Number of chassis {NumberOfChassis}\t Load {Load}");
        }


    }
}
