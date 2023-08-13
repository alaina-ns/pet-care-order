//Programmer: Alaina Smith
//Date 2/18/2022
// Project: Lab 3-1
// Description: Form for taking a pet care order.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_1
{
    public partial class Form1 : Form
    {
        // Declare class-level constants for later use in program
        private const decimal FLEA_REMOVAL_PRICE = 5.00m;
        private const decimal NAIL_CLIPPING_PRICE = 4.50m;
        private const decimal SHAMPOO_PRICE = 4.00m;
        private const decimal FUR_TRIMMING_PRICE = 9.00m;

        public Form1()
        {
            InitializeComponent();
        }


        // Execute when form loads at program startup
        private void Form1_Load(object sender, EventArgs e)
        {

            // Assign the service price values to lavels on form (currency string)
            fleaRemovalPriceLabel.Text = FLEA_REMOVAL_PRICE.ToString("c");
            nailClippingPriceLabel.Text = NAIL_CLIPPING_PRICE.ToString("c");
            shampooPriceLabel.Text = SHAMPOO_PRICE.ToString("c");
            furTrimmingPriceLabel.Text = FUR_TRIMMING_PRICE.ToString("c");

        }

        // handle other radio button's checked changed event
        private void otherButton_CheckedChanged(object sender, EventArgs e)
        {
            // Manage situtaion when "Other radio button is selected
            if (otherRadioButton.Checked)
            {
                typeIfOtherLabel.Enabled = true;
                typeIfOtherTextBox.Enabled = true;
                typeIfOtherTextBox.Focus();
            }
            else
            {
                typeIfOtherLabel.Enabled = false;
                typeIfOtherTextBox.Enabled = false;
                typeIfOtherTextBox.Text = ""; // Clear contents of this control
            }
        }

        // Handle Total button's click event
        // calculate and display the total fee for the order)
        private void totalButton_Click(object sender, EventArgs e)
        {

            // Declare and intialize local variables used to store total fees
            decimal totalFee = 0.00m;

            // Use if blocks to peform calculations necssary to determine the prices
            // ( Each checked box add service price
            if (fleaRemovalCheckBox.Checked)
            {
                totalFee += FLEA_REMOVAL_PRICE;
            }
            if (nailClippingCheckBox.Checked)
            {
                totalFee += NAIL_CLIPPING_PRICE;
            }
            if (shampooCheckBox.Checked)
            {
                totalFee += SHAMPOO_PRICE;
            }
            if (furTrimmingCheckBox.Checked)
                totalFee += FUR_TRIMMING_PRICE;
         //    //Display the total fee in label, formatted as currency
            totalFeeLabel.Text = totalFee.ToString("c");
            // Send focus to clear button
            //  Handle Clear buttons cick event
            clearButton.Focus();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ownerNameTextBox.Text = "";
            ownerPhoneMaskedTextBox.Text = "";
            petNameTextBox.Text = "";
            petDOBMaskedTextBox.Text = "";
            dogRadioButton.Checked = true;
            catRadioButton.Checked = true;
            fleaRemovalCheckBox.Checked = false;
            nailClippingCheckBox.Checked = false;
            shampooCheckBox.Checked = false;
            furTrimmingCheckBox.Checked = false;
            totalFeeLabel.Text = "";

            // Send focus to first date entry control on form
            ownerNameTextBox.Focus();
        }

            //Handle Quit button's clicked event
            // closes form


        private void quitButton_Click(object sender, EventArgs e)
        {
            //Handle Quit button's clicked event
            // closes form
            this.Close();
            }

        }
    }

