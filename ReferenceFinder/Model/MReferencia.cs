using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceFinder.Model
{
    public class MReferencia
    {
        public MVersiculo[] Versiculos { get; set; }
        public MCapitulo Capitulo {get; set;}
        public MLivro Livro { get; set; }
        public String Referencia { get; set; }
        public StringBuilder Texto { get; set; }
    }
}
