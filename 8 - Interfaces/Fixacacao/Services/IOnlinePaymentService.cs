using System;
using System.Collections.Generic;
using Fixacacao.Entities;

namespace Fixacacao.Services
{
    interface IOnlinePaymentService
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
