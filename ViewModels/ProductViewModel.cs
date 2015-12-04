using System;
using ControlTester.Models;
using Sage.SageOne.SageOneMobile.Controls.ViewModels;

namespace ControlTester.ViewModels
{
    public class ProductViewModel : SimpleViewModel, IEntityViewModel
    {
        private readonly Product _entity;

        public ProductViewModel(Product entity) {  _entity = entity; }

        public string Title => _entity.Description;
        public string Subtitle => _entity.TypeOfSale;
        public string Amount => "$" + _entity.Amount.ToString();
        public string Info =>"Product";
    }
}

