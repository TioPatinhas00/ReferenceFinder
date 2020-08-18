using System;
using System.Collections;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReferenceFinder.Model;
using System.IO;

namespace ReferenceFinder.Controller
{
    public class CReferencia
    {
        public MReferencia PopularReferencia (String Referencia)
        {
            MReferencia Retorno = new MReferencia();
            String Livro;
            String[] QuebraString;
            int Cap;
            int[] Vers;
            QuebraString = Referencia.Split(' ');
            Livro = QuebraString[0];
            Cap = int.Parse(QuebraString[1].Split(':')[0]);
            Vers = new int[QuebraString[1].Split(':')[1].Split(',').Length];
            for (int i = 0; i < QuebraString[1].Split(':')[1].Split(',').Length; i++)
            {
                Vers[i] = int.Parse(QuebraString[1].Split(':')[1].Split(',')[i]);
            }
            Retorno.Livro = TrazerLivro(Livro);
            Retorno.Versiculos = PopularVersiculos(Livro, Cap, Vers);

            return Retorno;
        }

        public MVersiculo [] PopularVersiculos (String Abrev, int Capitulo, int[] Versiculos)
        {
            List<MVersiculo> Lista = new List<MVersiculo>();
            MVersiculo[] Retorno = new MVersiculo[1];
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            String arquivoLivro = File.ReadAllText("C:\\Users\\IEMB\\source\\repos\\ReferenceFinder\\ReferenceFinder\\biblia-master\\json\\Livros.json");

            return Retorno;
            
            
        }

        public MLivro TrazerLivro (String nomeLivro)
        {
            MLivro Retorno = new MLivro();
            for (int i = 0; i < CLivro.ListaLivros.Length; i++)
            {
                if (CLivro.ListaLivros[i].Livro == nomeLivro)
                {
                    Retorno = CLivro.ListaLivros[i];
                    break;
                }
            }

            return Retorno;
        }
    }
}
