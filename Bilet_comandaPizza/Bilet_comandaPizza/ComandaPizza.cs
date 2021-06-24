using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilet_comandaPizza
{
    class ComandaPizza : ICustomizabil, ICloneable
    {
        public string nume { get; set; }
        public string blat { get; set; }
        public int durataRealizare { get; set; }
        public List<Toping> listaTopinguri { get; set; }

        public static readonly double costBaza = 10;        //valoare statica si constanta costBaza

        public ComandaPizza(string _nume, string _blat, int _durataRealizare, List<Toping> _lista)
        {
            nume = _nume;
            blat = _blat;
            durataRealizare = _durataRealizare;
            listaTopinguri = _lista;
        }

        public ComandaPizza(string _nume, string _blat, int _durataRealizare)
        {
            nume = _nume;
            blat = _blat;
            durataRealizare = _durataRealizare;
        }

        public double CalculCostPizza()
        {
            double cost = 0.0;
            foreach (Toping top in listaTopinguri)
            {
                cost += (top.Cantitate * top.Pret);
            }
            return cost + costBaza;
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
