using MauiApp1Maths;
using System.Data;

namespace MauiApp1Maths
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(exprEntry.Text))
            {
                DataTable dt = new DataTable();
                var r = dt.Compute(exprEntry.Text, "80/(12-7)");
                reslabel.Text = $"la solution de l equation est {r}";
            }
        }
    }

}
