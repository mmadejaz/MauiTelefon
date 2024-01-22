namespace MauiTelefon
{
    public partial class MainPage : ContentPage
    {
        string numer = "";

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnClicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            numer = numer + btn.Text;
            entNumer.Text = numer;
            if(numer.Length > 10 )
                entNumer.FontSize = 30;

        }
        private void btnCallClicked(object sender, EventArgs e)
        {
            lblTest.Text = "dzwonię pod numer: " + entNumer.Text;
        }
    }

}
