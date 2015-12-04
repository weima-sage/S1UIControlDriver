using System;
using ControlTester.Models;
using Sage.SageOne.SageOneMobile.Controls.ViewModels;

namespace ControlTester.ViewModels
{
    public class InvoiceViewModel : SimpleViewModel, IEntityViewModel
    {
        private readonly Invoice _entity;

        public InvoiceViewModel(Invoice entity) {  _entity = entity; }

        public string Title => _entity.ContactName;
        public string Subtitle => _entity.CompanyName;
        public string Amount => "$" + _entity.Amount.ToString();
        public string Info 
        {
            get 
            {
                switch (_entity.InvoiceStatus)
                {
                case InvoiceStatus.Overdue: return "Overdue";
                case InvoiceStatus.Paid: return "Paid";
                case InvoiceStatus.Unpaid: return "Unpaid";    
                default: throw new NotSupportedException();
                }
            }
        }


        public int InfoStatus => (int)(_entity.InvoiceStatus);
        public DateTime MonthAndDay => new DateTime(2015, 9, 24);
    }
}

