using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Phone
    {
        private String manufacturer;
        private double screenSize;
        private int memory;
        private static Phone me;

        public Phone(double screenSize, String manufacturer)
        {
            this.screenSize = screenSize;
            this.manufacturer = manufacturer;
            this.memory = 17;
            me = null; 
        }

        public Phone(String manufacturer)
        {
            this.manufacturer = manufacturer;
            this.memory = 16;
            me = null;

        }

        public Phone(double screenSize, String manufacturer, int memory)
        {
            this.screenSize = screenSize;
            this.manufacturer = manufacturer;
            this.memory = memory;
            me = null;
        }

        public static Phone NewInstance()
        {
            if (me == null)
            {
                me = new Phone("LL");
            }

            return me;
        }

        public double GetScreenSize()
        {
            return this.screenSize;
        }

        public void SetScreenSize(double screenSize)
        {
            this.screenSize = screenSize;
        }

        public void SetManufacturer(string manufacturer)
        {
            this.manufacturer = manufacturer;
        }

        public String GetManufacturer()
        {
            return this.manufacturer;
        }

        public int GetMemory()
        {
            return this.memory;
        }

        public void SetMemory(int memory)
        {
            this.memory = memory;
        }

        public static bool CanTalk()
        {
            return true;
        }

        public static  void SendSms(String text)
        {
            //dsfjsdlsdflsdlfklsd
        }
    }
}
