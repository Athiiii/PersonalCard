using System.Windows.Controls;
using Image = System.Windows.Controls.Image;

namespace PersonalCardFinished
{
    /// <summary>
    /// Interaction logic for PersonalCard.xaml
    /// </summary>
    public partial class PersonalCard : UserControl
    {
        public PersonalCard()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public string FullName { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public string Adress { get; set; }
        public Image ImageUrl { get; set; }

    }
}
