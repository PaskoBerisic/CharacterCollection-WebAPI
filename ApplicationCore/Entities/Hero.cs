using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ApplicationCore.Entities
{
    public class Hero
    {
        [XmlElement]
        public int Id { get; set; }
        
        [XmlElement]
        public string Name { get; set; }

        [XmlElement]
        public int Power { get; set; }
    
        //public Trait Traits { get; set; }
    }
}
