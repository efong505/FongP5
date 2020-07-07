using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
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

namespace FongP5
{
    /// <summary>
    /// Interaction logic for SprocketOrderForm.xaml
    /// </summary>
    public partial class SprocketOrderForm : Window
    {
        private SprocketOrder order = new SprocketOrder();
        public SprocketOrderForm()
        {
            InitializeComponent();

            // list box on sprocket order form
            lBSprOrderForm.ItemsSource = order.Items; // Bind order items to list box
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            
            SprocketForm itemForm = new SprocketForm();
            itemForm.ShowDialog();
            if(itemForm.DialogResult == true)
            {
               order.Add(itemForm.Sprocket); // add item sprocket order to 
               lBSprOrderForm.Items.Refresh(); // display list after item added
            }
        }
        // Yes or no box modal
        /// <summary>
        /// Yes or no modal window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            // if item selected in list box on sprocket order form then ask if sure with modal button
            if(lBSprOrderForm.SelectedItem != null)
            {
                MessageBoxResult result = MessageBox.Show("Are you sure?", "Confirm",MessageBoxButton.YesNo);
                if(result == MessageBoxResult.Yes)
                {
                    // if yes clicked remove selected item in list box on sprocket order form
                    order.Remove((Sprocket)lBSprOrderForm.SelectedItem); 
                    lBSprOrderForm.Items.Refresh(); // display updated list after deleted item
                }
            }
        }

        // Hide Address Group
        /// <summary>
        /// If Checked Hide Address Group
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkBLoclaPickUp_Checked(object sender, RoutedEventArgs e)
        {
            AddressGroup.Visibility = Visibility.Hidden;
        }

        // show adderss group
        /// <summary>
        /// show address Group if checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkBLoclaPickUp_UnChecked(object sender, RoutedEventArgs e)
        {
            AddressGroup.Visibility = Visibility.Visible;
        }

        // Save dialog
        /// <summary>
        /// Open Save Dialog and give user option to save order to file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            order.CustomerName = txtBCustName.Text;
            if(chkBLocalPickUp.IsChecked == true)
            {
                order.Address = null;
            }
            else
            {
                order.Address = new Address();
                order.Address.Street = txtBAddress.Text;
                order.Address.City = txtBCity.Text;
                order.Address.State = txtBState.Text;
                order.Address.ZipCode = txtBZip.Text;
            }
            
            txtBResults.Text = order.ToString(); 

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "Document";
            saveFile.DefaultExt = ".txt";
            saveFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFile.RestoreDirectory = true;
            if(saveFile.ShowDialog() == true)
            {
                using (StreamWriter file = new StreamWriter(saveFile.OpenFile()))
                {
                    file.WriteLine(order.ToString() + "\n\n"+
                        "Order(s):");
                    foreach (var sprocket in order.Items)
                    {
                        file.WriteLine(sprocket.ToString());

                    }
                }
            }
        }
    }
}
