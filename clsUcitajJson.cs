using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace CityQuizz
{
    class UcitajJson
    {

        public List<Grad> ucitajGradoveiDrzave()
        {

            //"C:\\Users\\Savoo\\source\\repos\\CityQuizzSol\\CityQuizz\\gid.json"
            String path = AppDomain.CurrentDomain.BaseDirectory;         //System.Reflection.Assembly.GetEntryAssembly().Location + "\\gid.json";
            System.Diagnostics.Debug.WriteLine(path);
            StreamReader sr = new StreamReader(path+"\\gid.json");
            String ucitavanje = sr.ReadToEnd();
            var rez = JsonConvert.DeserializeObject<List<Grad>>(ucitavanje);
            List<Grad> lista = rez;
            return lista;
                
        }

    }
}
