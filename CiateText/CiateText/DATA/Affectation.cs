//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CiateText.DATA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Affectation
    {
        public int Matricule { get; set; }
        public int NumeroGroupe { get; set; }
        public int NumeroModule { get; set; }
        public int Annee { get; set; }
    
        public virtual Formateur Formateur { get; set; }
        public virtual Groupe Groupe { get; set; }
        public virtual Module Module { get; set; }
    }
}
