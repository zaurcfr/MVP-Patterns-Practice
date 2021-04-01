using MVP_Patterns_Practice.Data;
using MVP_Patterns_Practice.Models;
using MVP_Patterns_Practice.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Patterns_Practice.Presenters
{
    class MainViewPresenter
    {
        private readonly PaymentContext _db;
        private IMainView _view;

        public MainViewPresenter(IMainView view)
        {
            _view = view;
            _view.AddButtonClick += ViewAddButtonClick;
            _view.LoadButtonClick += ViewLoadButtonClick;
            _db = new PaymentContext();
            
        }

        private void ViewAddButtonClick(object sender, EventArgs e)
        {
            Payment payment = new Payment
            {
                Name = _view.NameText,
                Liter = _view.LiterText,
                PricePerLiter = _view.PricePerLiterText,
                Price = _view.PriceText,
                DateTime = DateTime.Now
            };
            _db.payments.Add(payment);
            _db.SaveChanges();
        }

        private void ViewLoadButtonClick(object sender, EventArgs e)
        {
            var list = _db.payments.ToList();
            _view.payments = list;
        }

    }
}
