using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp12
{
    public partial class Form1 : Form
    {
        List<string> names = new List<string> { "Хліб", "Молоко", "Печиво" };
        List<double> prices = new List<double> { 25.50, 40.00, 30.00 };
        List<int> stock = new List<int> { 10, 5, 15 };

        List<string> cartNames = new List<string>();
        List<int> cartQty = new List<int>();
        List<double> cartPrices = new List<double>();

        public Form1()
        {
            InitializeComponent();
            UpdateInventoryList();
        }

        void UpdateInventoryList()
        {
            listBoxInventory.Items.Clear();
            for (int i = 0; i < names.Count; i++)
            {
                string status = stock[i] > 0 ? $"{stock[i]} шт." : "НЕМАЄ В НАЯВНОСТІ";
                listBoxInventory.Items.Add($"{names[i]} - {prices[i]} грн ({status})");
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            int index = listBoxInventory.SelectedIndex;
            int count = (int)numericUpDownQty.Value;

            if (index != -1)
            {
                if (stock[index] <= 0)
                {
                    MessageBox.Show("цей товар закінчився!");
                    return;
                }

                if (count <= stock[index] && count > 0)
                {
                    cartNames.Add(names[index]);
                    cartQty.Add(count);
                    cartPrices.Add(prices[index]);

                    stock[index] -= count;

                    listBoxCart.Items.Add($"{names[index]} x {count}");
                    UpdateInventoryList(); 
                    CalculateTotal();
                }
                else
                {
                    MessageBox.Show($"недостатньо товару! на складі залишилося: {stock[index]} шт.");
                }
            }
            else
            {
                MessageBox.Show("виберіть товар!");
            }
        }

        void CalculateTotal()
        {
            double total = 0;
            for (int i = 0; i < cartPrices.Count; i++)
            {
                total += cartPrices[i] * cartQty[i];
            }
            lblTotal.Text = "сума: " + total + " грн";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cartNames.Count == 0)
            {
                MessageBox.Show("кошик порожній!");
                return;
            }

            string finalReceipt = "--- ЧЕК ---\n" + DateTime.Now.ToString() + "\n\n";
            double totalSum = 0;

            for (int i = 0; i < cartNames.Count; i++)
            {
                double lineSum = cartQty[i] * cartPrices[i];
                finalReceipt += $"{cartNames[i]} x {cartQty[i]} = {lineSum} грн\n";
                totalSum += lineSum;
            }

            finalReceipt += "\nРАЗОМ: " + totalSum + " грн";

            File.WriteAllText("receipt.txt", finalReceipt);
            MessageBox.Show("Замовлення успішно оформлено!");

            cartNames.Clear();
            cartQty.Clear();
            cartPrices.Clear();
            listBoxCart.Items.Clear();
            lblTotal.Text = "Сума: 0 грн";
        }
    }
}