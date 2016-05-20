using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCIntroduction.Models
{
    public class Dog
    {
        //Dog attributes
        public string BreedName { get; set; }
        public string DisplayName { get; set; }
        public string ImageName { get; set; }
        public EScale ActivityLevel { get; set; }
        public EScale SheddingLevel { get; set; }
        public EScale GroomingLevel { get; set; }
        public EScale IntelligenceLevel { get; set; }
        public bool GoodWithChildren { get; set; }
        public bool Drools { get; set; }
        public ELength Coatlength;
        public ESize Size;
    }
}