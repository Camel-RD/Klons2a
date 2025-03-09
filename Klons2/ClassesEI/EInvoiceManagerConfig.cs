using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlonsM.Classes;

public class EInvoiceManagerConfig
{
    public List<EInvoiceManagerConfig_EMailTemplate> Templates { get; set; } = new();

}

public class EInvoiceManagerConfig_EMailTemplate
{
    public string Name { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
}
