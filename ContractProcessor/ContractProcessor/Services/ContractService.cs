using ContractProcessor.Entitites;
using System;

namespace ContractProcessor.Services
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService paypal)
        {
            _onlinePaymentService = paypal;
        }

        public void ProcessContract(Contract contract, int Months)
        {
            double monthlyInstallmentWithOutTaxes = contract.totalValue / Months;
            for(int i = 1; i <= Months; i++)
            {
                DateTime dateTime = contract.date.AddMonths(i);
                double paymentTax = monthlyInstallmentWithOutTaxes + _onlinePaymentService.PaymentFee(monthlyInstallmentWithOutTaxes);
                double InterestTax = _onlinePaymentService.Interest(paymentTax, i);
                double installmentValue = paymentTax + InterestTax;
                Installment installment = new Installment(dateTime, installmentValue);
                contract.AddInstallment(installment);
            }
        }
    }
}
