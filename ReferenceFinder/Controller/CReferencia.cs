using System;
using System.Collections;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Linq;
using System.Xml;
using System.Threading.Tasks;
using ReferenceFinder.Model;
using System.IO;
using System.Data;
using System.Xml.Linq;
using System.Xml.Serialization;

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
            //String arquivoLivro = File.ReadAllText("C:\\Users\\IEMB\\source\\repos\\ReferenceFinder\\ReferenceFinder\\biblia-master\\json\\Livros.json");
            String arquivoLivro = "C:\\Users\\90004477\\source\\repos\\ReferenceFinder\\ReferenceFinder\\biblia-master\\xml\\aa\\aa-gn.xml";
            String verso;
            try {
                DataSet dsResultado = new DataSet();
                dsResultado.ReadXml(arquivoLivro);
                
                if (dsResultado.Tables.Count != 0) {
                    for (int i = 0; i < dsResultado.Tables.Count; i++) {
                        if (dsResultado.Tables[0].Rows[i][0].ToString() == "Gênesis" && dsResultado.Tables[0].Rows[i][3].ToString() == "1" && dsResultado.Tables[0].Rows[i][5].ToString() == "10") {
                            verso = dsResultado.Tables[0].Rows[i][4].ToString();
                            break;
                        }
                    }
                }
            } catch { }
            XmlDocument DocXml = new XmlDocument();
            XmlElement ListXml = DocXml.DocumentElement;
            DocXml.LoadXml(arquivoLivro);
            String Verso = ListXml.Attributes["book = Apocalipse"].Value;

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
