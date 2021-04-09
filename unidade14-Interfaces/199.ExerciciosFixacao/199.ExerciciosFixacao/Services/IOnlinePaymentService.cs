using System;
using System.Collections.Generic;
using System.Text;

namespace _199.ExerciciosFixacao.Services
{
    interface IOnlinePaymentService
    {
        double Interest(double amount, int month);
        double PaymentFee(double amount);


    }
}
