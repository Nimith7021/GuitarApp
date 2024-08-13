using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAppOOAD.Models
{
    internal class GuitarSpec
    {
        public Builder Builder { get; set; }

        public string Model { get; set; }

        public int NumStrings { get; set; }

        public TypeOfGuitar Type { get; set; }

        public Wood Backwood { get; set; }

        public Wood Topwood { get; set; }

        public GuitarSpec(Builder builder, string model, 
            TypeOfGuitar type, Wood backwood, Wood topwood, int numStrings)
        {
            Builder = builder;
            Model = model;
            Type = type;
            Backwood = backwood;
            Topwood = topwood;
            NumStrings = numStrings;
        }

        public bool IsGuitarMatching(GuitarSpec spec)
        {
                    if((spec.Model != "" && spec.Model != null 
                      && spec.Model.ToLower() == Model.ToLower()) && (spec.Builder == Builder) &&
                    (spec.Type == Type) && (spec.Backwood == Backwood) && (spec.Topwood == Topwood) &&
                    (spec.NumStrings!=0 && spec.NumStrings == NumStrings))
                    {

                         return true;
                    }
                    return false;
        }

        }


    }

