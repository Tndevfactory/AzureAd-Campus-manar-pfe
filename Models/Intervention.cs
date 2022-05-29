namespace tracerapi.Models
{
    public class Intervention
    {
        public int Id { get; set; }
        public string Sujet { get; set; } = string.Empty;
        public string Compte { get; set; } = string.Empty;
        public string DateEcheance { get; set; } = string.Empty;
        public string DateProchaineEcheance { get; set; } = string.Empty;
        public string DateContrat { get; set; } = string.Empty;
        public string CodeContrat { get; set; } = string.Empty;
        public string ContratMaintenance { get; set; } = string.Empty;
        public string DateAppel { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;
        public string Owner { get; set; } = string.Empty;
       
        public string File { get; set; } = string.Empty;
        public DateTime DateIntervention { get; set; } = DateTime.Now;
    }
}
