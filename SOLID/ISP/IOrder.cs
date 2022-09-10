using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISP
{
    public interface IOrder
    {
        void AddToCart();
    }
    
    public interface IOnlinePayment
    {
        void CardPaymentProcess();
    }

    public class OnlineOrder : IOrder, IOnlinePayment
    {
        public void AddToCart()
        {
            //Add to Cart Code
        }

        public void CardPaymentProcess()
        {
            //Card Payment process code
        }
    }

    public class CashOnDeliveryOrder : IOrder
    {
        public void AddToCart()
        {
            //Add to Cart Code
        }
    }
}
