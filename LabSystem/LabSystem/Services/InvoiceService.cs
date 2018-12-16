using System.Web.Mvc;

namespace LabSystem.Services
{
    public class InvoiceService
    {

        public FileResult GetInvoice(int InvoiceId)
        {
            return null;
        }

        //dostęp zastrzeżony dla klientów
        public void GenerateInvoice(int InvoiceId)
        {
        }

    }
}