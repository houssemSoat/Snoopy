//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Snoopy.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SAnimal
    {
        public int AnimalId { get; set; }
        public int PublisherId { get; set; }
        public int AnimalTypeId { get; set; }
        public string Price { get; set; }
        public string Name { get; set; }
        public string PictureUrl { get; set; }
        public Nullable<int> Sexe { get; set; }
        public string Adresse { get; set; }
        public Nullable<System.DateTime> NaissanceDate { get; set; }
        public string Race { get; set; }
        public string Age { get; set; }
    
        public virtual SPublisher SPublisher { get; set; }
    }
}
