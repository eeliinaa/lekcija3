using System;
using System.Collections.Generic;
using System.Text;

namespace lekcija3._1
{
    public static class Phone
    {
        private static string size;
        private static string brand;
        private static string model;

        public static string Size
        {
            get { return size; }
            set { size = value; }
        }

        public static string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public static string Model
        {
            get { return model; }
            set { model = value; }
        }


        public static void Call()
        {

        }
        public static void SendMessage()
        {

        }
    }
}
