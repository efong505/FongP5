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
using System.Windows.Shapes;

namespace FongP5
{
    /// <summary>
    /// Interaction logic for SprocketForm.xaml
    /// </summary>
    public partial class SprocketForm : Window
    {
        // Sproket Property
        /// <summary>
        /// Sprocket property
        /// </summary>
        public Sprocket Sprocket { get; set; }
        /// <summary>
        /// Sprocket Form constructor
        /// </summary>
        public SprocketForm()
        {
            InitializeComponent();
            ClearForm();
            
        }

        // Clear the form
        /// <summary>
        /// Clears the form
        /// </summary>
        private void ClearForm()
        {
            txtBItemID.Text = "";
            txtBNumTeeth.Text = "";
            txtBNumItems.Text = "";
            
        }

        

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            int itemID = int.Parse(txtBItemID.Text);
            int numTeeth = int.Parse(txtBNumTeeth.Text);
            int numItems = int.Parse(txtBNumItems.Text);
            

            try
            {
                if (cmbBxItemType.Text == "steel")
                {
                    Sprocket = new SteelSprocket(itemID, numTeeth, numItems);
                }
                else if(cmbBxItemType.Text == "aluminum")
                {
                    Sprocket = new AluminumSprocket(itemID, numTeeth, numItems);
                }
                else if(cmbBxItemType.Text == "plastic")
                {
                    Sprocket = new PlasticSprocket(itemID, numTeeth, numItems);
                }
                DialogResult = true;
                Close();
            }
            catch(Exception)
            {
                DialogResult = false;
                Close();
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
