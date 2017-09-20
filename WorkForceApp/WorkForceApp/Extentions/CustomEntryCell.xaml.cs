using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkForceApp.Extentions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomEntryCell : ContentPage
    {
        public static readonly BindableProperty LabelProperty = BindableProperty.Create("Label", typeof(string), typeof(CustomEntryCell));
        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        public CustomEntryCell()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}
