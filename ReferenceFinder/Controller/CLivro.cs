using System;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using ReferenceFinder.Model;

namespace ReferenceFinder.Controller
{
    public class CLivro
    {
        public static MLivro [] ListaLivros;
        public List<MLivro> ArrayLivros;
        public JavaScriptSerializer LivroSerializer = new JavaScriptSerializer();

        public void PopularLivros()
        {
            //String arquivoLivro = File.ReadAllText("C:\\Users\\IEMB\\source\\repos\\ReferenceFinder\\ReferenceFinder\\biblia-master\\json\\Livros.json");
            String arquivoLivro = File.ReadAllText("C:\\Users\\90004477\\source\\repos\\ReferenceFinder\\ReferenceFinder\\biblia-master\\json\\Livros.json");
            ArrayLivros = JsonConvert.DeserializeObject<List<MLivro>>(arquivoLivro);
            ListaLivros = ArrayLivros.ToArray();
        }
    }
}
