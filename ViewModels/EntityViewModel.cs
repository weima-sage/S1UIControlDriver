using System;
using ControlTester.Models;
using System.ComponentModel;

namespace ControlTester.ViewModels
{
    public class EntityViewModel : SimpleViewModel
    {
        private readonly Entity _entity;

        public EntityViewModel(Entity entity) {  _entity = entity; }

        public string Title => _entity.Title;
        public string Subtitle => _entity.Subtitle;
        public string Amount => "$" + _entity.Amount.ToString();
        public string Info 
        {
            get 
            {
                switch (InfoStatus)
                {
                case InfoStatus.Overdue: return "Overdue";
                case InfoStatus.Paid: return "Paid";
                case InfoStatus.Unpaid: return "Unpaid";    
                default: throw new NotSupportedException();
                }
            }
        }
        public InfoStatus InfoStatus => _entity.InfoStatus;

        public DateTime Date => new DateTime(2015, 9, 24);
    }
}

