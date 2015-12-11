using System;
using ControlTester.Models;
using Sage.SageOne.SageOneMobile.Controls.Style;
using Sage.SageOne.SageOneMobile.Controls.ViewModels;

namespace ControlTester.ViewModels
{
    public class InvoiceViewModel : SimpleViewModel, IEntityLightViewModel
    {
        private readonly Invoice _entity;

        public InvoiceViewModel(Invoice entity) 
        {  
            PrimaryKey = "1";
            _entity = entity;             
        }

        public string PrimaryKey { get; private set; }
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


        public DisplayEnums InfoStatus
        {
            get
            {
                switch (_entity.InvoiceStatus)
                {
                    case InvoiceStatus.Paid:
                        return DisplayEnums.Info;
                    case InvoiceStatus.Unpaid:
                        return DisplayEnums.BadNews;
                    case InvoiceStatus.Overdue:
                        return DisplayEnums.AwfulNews;
                    default:
                        return DisplayEnums.Info;
                }
            }
        }

        public DateTime MonthAndDay => new DateTime(2015, 9, 24);
    }
}

