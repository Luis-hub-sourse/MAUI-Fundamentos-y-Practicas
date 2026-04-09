namespace HelloMAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Se cliequearon {count} veces";
            else
                CounterBtn.Text = $"Se cliequearon {count} veces";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}
