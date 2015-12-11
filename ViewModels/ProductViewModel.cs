using System;
using ControlTester.Models;
using Sage.SageOne.SageOneMobile.Controls.Style;
using Sage.SageOne.SageOneMobile.Controls.ViewModels;

namespace ControlTester.ViewModels
{
    public class ProductViewModel : SimpleViewModel, IEntityLightViewModel
    {
        private readonly Product _entity;

        public ProductViewModel(Product entity)
        {  
            PrimaryKey = "1";
            _entity = entity; 
        }

        public string PrimaryKey { get; private set; }

        public string Title => _entity.Description;
        public string Subtitle => _entity.TypeOfSale;
        public string Amount => "$" + _entity.Amount.ToString();
        public string Info =>"Product";
        public DisplayEnums InfoStatus => DisplayEnums.Info;
    }
}

