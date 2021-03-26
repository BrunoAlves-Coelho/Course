using System;
using System.Collections.Generic;
using System.Text;


namespace Course.Entities.Enums
{
    enum OrderStatus : int
    {
        //Pagto. Pendente
        PendingPayment = 0,
        //Processando
        Processing = 1,
        //Enviado
        Shipped = 2,
        //Entregue
        Delivered = 3

    }
}
