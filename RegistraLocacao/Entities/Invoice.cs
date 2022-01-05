using System.Globalization;
using System.Text;

namespace RegistraLocacao.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Basic payment: {BasicPayment.ToString("F2", CultureInfo.InvariantCulture)}");
            sb.AppendLine($"Tax: {Tax.ToString("F2", CultureInfo.InvariantCulture)}");
            sb.Append($"Total payment: {TotalPayment.ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
