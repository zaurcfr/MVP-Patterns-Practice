using MVP_Patterns_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Patterns_Practice.Views
{
    public interface IMainView
    {
        EventHandler<EventArgs> AddButtonClick { get; set; }
        EventHandler<EventArgs> LoadButtonClick { get; set; }
        List<Payment> payments { set; }
        string NameText { get; set; }
        string LiterText { get; set; }
        string PriceText { get; set; }
        string PricePerLiterText { get; set; }

    }
}
