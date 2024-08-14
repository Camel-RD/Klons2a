using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace KlonsF.ClassesF
{
    [XmlRoot(ElementName = "TP")]
    public partial class EdsTp
    {
        public TPPamatdati pamatdati { get; set; }

        [XmlArrayItem("Transakcija", IsNullable = true)]
        public TPTransakcija[] Transakcijas { get; set; }
    }

    public partial class TPPamatdati
    {
        public string isais_nosauk { get; set; }
        public ulong nmr_kods { get; set; }
        public string periods_no { get; set; }
        public string periods_lidz { get; set; }
        public object dokumenta_nr { get; set; }
        public object uzdevuma_nr { get; set; }
        public DateTime izpildes_laiks { get; set; }
    }

    public partial class TPTransakcija
    {
        public DateTime Datums { get; set; }
        public string SaistibasDokumentaNr { get; set; }
        public string Aprekins { get; set; }
        public string AprekinaPamatojums { get; set; }
        public string SaistibasVeids { get; set; }
        public string IenemumuVeids { get; set; }
        public ushort BudzetaKlasifikacijasKods { get; set; }
        public string SummasVeids { get; set; }
        public decimal Summa { get; set; }
        public string SaistitaDokumentaNr { get; set; }
        public string MaksajumaUzdevumaNr { get; set; }
        public string Info { get; set; }
        public DateTime PeriodsNo { get; set; }
        public DateTime PeriodsLidz { get; set; }
    }


}
