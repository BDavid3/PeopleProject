using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PeopleProject
{

    public partial class MainWindow : Window
    {
        People people;
        public MainWindow()
        {
            InitializeComponent();
            people = new People();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtblock.Text != "")
                people.UjSzemely(int.Parse(txtblock.Text));
                txtblock.Text = "";
        }
    }
}