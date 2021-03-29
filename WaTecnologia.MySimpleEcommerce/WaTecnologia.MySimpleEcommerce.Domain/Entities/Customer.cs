using System;
using System.Collections.Generic;
using WaTecnologia.MySimpleEcommerce.Domain.Services;

namespace WaTecnologia.MySimpleEcommerce.Domain.Entities
{
    public class Customer : EntityBase
    {
        public string FullName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string CPF { get; private set; }
        public virtual List<Order> Orders { get; set; }

        public Customer(string fullName, DateTime birthDate, string cpf)
        {
            FullName = fullName;
            BirthDate = birthDate;
            CPF = CPFServices.FormatCPF(cpf);
        }

        protected Customer()
        {

        }
    }
}
