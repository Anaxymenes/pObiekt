using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PD_002
{
    class Car
    {
        public string marka;
        public int rok;
        private string model;
        private int iloscDrzwi;
        private double pojemnoscSilnika;
        public double srednieSpalanie;
        private static int iloscSamochodow = 0;
        
        //praca domowa
        private double ObliczSpalanie(double dlugoscTrasy)
        { 
            double spalanie = (srednieSpalanie * dlugoscTrasy)/100;
            return spalanie;
        }
        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double kosztPrzejazdu)
        {
            return ObliczSpalanie(dlugoscTrasy) * kosztPrzejazdu;
        }
    }
}
