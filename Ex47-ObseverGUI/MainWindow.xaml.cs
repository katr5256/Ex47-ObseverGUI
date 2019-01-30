using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ex47_ObseverGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window , IPublisher
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CancelPet_Click(object sender, RoutedEventArgs e)
        {
            TextBox PetNameBox = PetName1;
            PetNameBox.Clear();

            TextBox PetTypeBox = PetType1;
            PetTypeBox.Clear();

            TextBox PetDOBBox = PetDOB1;
            PetDOBBox.Clear();

            TextBox PetBreedBox = PetBreed1;
            PetBreedBox.Clear();

            TextBox PetWeightBox = PetWeight1;
            PetWeightBox.Clear();

            TextBox OwnerIdBox = OwnerId1;
            OwnerIdBox.Clear();

        }

        private void InsertPet_Click(object sender, RoutedEventArgs e)
        {
            PetName1.IsEnabled = true;
            PetType1.IsEnabled = true;
            PetBreed1.IsEnabled = true;
            PetDOB1.IsEnabled = true;
            PetWeight1.IsEnabled = true;
            OwnerId1.IsEnabled = true;
        }

        private void SavePet_Click(object sender, RoutedEventArgs e)
        {
            Controller controller = new Controller();
            string PetName = PetName1.Text;
            string PetType = PetType1.Text;
            string PetBreed = PetBreed1.Text;
            string PetDOB = PetDOB1.Text;
            string PetWeight = PetWeight1.Text;
            int OwnerId = Convert.ToInt32(OwnerId1.Text);

            controller.InsertPet(PetName, PetType, PetBreed, PetDOB, PetWeight, OwnerId);

        }
    }
}

