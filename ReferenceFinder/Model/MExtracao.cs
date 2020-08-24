using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReferenceFinder.Model {
    [Serializable]
    [XmlRoot(ElementName = "book")]
    public class MExtracao {

        [XmlElement(ElementName = "name")]
        String nome { get; set; }
        [XmlElement(ElementName = "abrev")]
        String abrev { get; set; }
        [XmlElement(ElementName = "chapters")]
        String chapters { get; set; }
        [XmlElement(ElementName = "number")]
        String number { get; set; }
        [XmlElement(ElementName = "verse")]
        String verse { get; set; }
        [XmlElement(ElementName = "number2")]
        String numberNew { get; set; }

        
    }
}
