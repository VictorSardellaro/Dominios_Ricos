using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{

    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(
            string cardHolderName,
            string cardNumber,
            string lastTransactionNumber,
            DateTime paidDate,
            DateTime expireDate,
            decimal total,
            decimal totalPaid,
            string payer,
            Document document,
            Address address,
            Email email) : base(
                 paidDate,
                 expireDate,
                 total,
                 totalPaid,
                 payer,
                 document,
                 address,
                 email)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHolderName { get; private set; }
        public string CardNumber { get; private set; }
        //ultimos 4 digitos do cartão, não pode armazenar informações de cartão de credito como data e os numeros de segurança PCI
        public string LastTransactionNumber { get; private set; }

    }

}