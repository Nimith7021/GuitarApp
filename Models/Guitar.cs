using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAppOOAD.Models
{
    internal class Guitar
    {
        public string SerialNumber {  get; set; }

        public double Price { get; set; }

        public GuitarSpec guitarspec { get; set; }


        public Guitar(string serialNumber, double price, GuitarSpec guitarspec)
        {

            SerialNumber = serialNumber;
            Price = price;
            this.guitarspec = guitarspec;
        }

        public override string ToString()
        {
            return $"========================================================\n" +
                $"Guitar Builder : {guitarspec.Builder}\n" +
                $"Guitar Model : {guitarspec.Model}\n" +
                $"Type : {guitarspec.Type}\n" +
                $"Backwood : {guitarspec.Backwood}\n" +
                $"Topwood : {guitarspec.Topwood}\n" +
                $"Number of strings : {guitarspec.NumStrings}\n" +
                $"You can get this at : {Price}";

        }


    }
}
