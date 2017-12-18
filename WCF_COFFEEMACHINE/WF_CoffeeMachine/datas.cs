using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WF_CoffeeMachine.ServiceReference1;

namespace WF_CoffeeMachine
{
    public class datas
    {

        //public string[] type_drink ={ 
        //  "CAFE NOIR",
        //  "CAFE AU LAIT",
        //  "THE NATURE",
        //  "CHOCOLAT AU LAIT"
        //};

        public struct type_drink 
        {
            public const int maxqtSucre = 5;
           public const string blackcoffee = "CAFE NOIR";
           public const string coffeewithmilk = "CAFE AU LAIT";
           public const string naturetea = "THE NATURE";
           public const string milkchocolate = "CHOCOLAT AU LAIT";
     
        };

        public struct _Customer
        {
            
            public int id_customer;
            public string type_drink;
            public int qtsucre;
            public byte mug;
        }

        public static _Customer _customer;
       
        //SINGLETON PATTERN
        static datas singleton = null;
        public static datas instance()
        {
            if (singleton == null)
                singleton = new datas();
            return singleton;
        }

        public _Customer  seachCustomer()
        {
            _Customer cst =new _Customer();
            Customer customer = new Customer();
            Service1Client serviceClient = new Service1Client();
            if (serviceClient.searchCustomer(_customer.id_customer) != null)
            {
                customer = serviceClient.searchCustomer(_customer.id_customer);
                cst.id_customer = customer.id_customer;
                cst.type_drink = customer.type_drink;
                cst.qtsucre = customer.qtSucre;
                cst.mug = customer.mug;
            }
            return cst;
        }
        public int insertCustomer()
        {
            Customer customer = new Customer();
            customer.id_customer = Convert.ToInt32( _customer.id_customer);
            customer.type_drink = _customer.type_drink;
            customer.qtSucre = _customer.qtsucre;
            customer.mug = _customer.mug;
            Service1Client serviceClient = new Service1Client();
            if (serviceClient.insertCustomer(customer) == 1)
                return 1;
            else
            return 0;
        }
        public bool save()
        {
            return true;  
        }

        public bool read()
        {
            return true;
        }
    }
}
