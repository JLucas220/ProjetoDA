//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetoDA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Evento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Evento()
        {
            this.Participacoes = new HashSet<Participacao>();
            this.Colaboracoes = new HashSet<Colaboracao>();
            this.Inscricoes = new HashSet<Inscricao>();
        }
    
        public int NrEvento { get; set; }
        public string Descricao { get; set; }
        public string Local { get; set; }
        public string DataHora { get; set; }
        public string LimiteParticipacao { get; set; }
        public string IdadeInferior { get; set; }
        public string IdadeSuperior { get; set; }
        public string TipoEvento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Participacao> Participacoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Colaboracao> Colaboracoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inscricao> Inscricoes { get; set; }
    }
}
