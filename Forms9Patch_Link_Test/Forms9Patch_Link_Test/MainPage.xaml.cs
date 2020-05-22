using System.ComponentModel;
using Xamarin.Forms;

namespace Forms9Patch_Link_Test
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            const string text = "Click here!";
            const string href = "https://baskren.github.io/Forms9Patch/";
            const string id = "id";

            HtmlText = $@"<a id=""{id}"" href=""{href}"">{text}</a>";
            F9PLabel.ActionTagTapped += URLTagged;
        }

        private void URLTagged(object sender, Forms9Patch.ActionTagEventArgs e)
        {
            throw new System.NotImplementedException($"Id {e.Id}, Href: {e.Href}");
        }

        public string HtmlText
        {
            get => F9PLabel.HtmlText;
            set => F9PLabel.HtmlText = value;
        }
    }
}
