using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaratKezeloProject
{
    public class JaratKezelo
    {
        private class Jaratok
        {
            public string JaratSzam { get; }
            public string RepterHonnan { get; }
            public string RepterHova { get; }
            public DateTime Indulas { get; }
            public int Keses { get; set; }

            public Jaratok(string jaratSzam, string repterHonnan, string repterHova, DateTime indulas)
            {
                JaratSzam = jaratSzam;
                RepterHonnan = repterHonnan;
                RepterHova = repterHova;
                Indulas = indulas;
                Keses = 0;
            }
        }


    }
}
