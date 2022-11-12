using Bogus;
using CommunityToolkit.Mvvm.ComponentModel;
using MiniBank.MVVM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBank.MVVM.ViewModels
{
    public class ConversionsViewModel : ObservableObject
    {
        public Conversion Conversion { get; set; } = new Conversion();

        public decimal Convert()
        {
            return Conversion.Amount * 100;
        }

        public string SaveConversion()
        {
            App.ConversionsRepo.SaveItem(Conversion);
            return App.ConversionsRepo.StatusMessage;
        }
    }
}
