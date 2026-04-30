namespace WinFormsApp12
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            listBoxInventory = new ListBox();
            listBoxCart = new ListBox();
            numericUpDownQty = new NumericUpDown();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQty).BeginInit();
            SuspendLayout();
            // 
            // button1 (Оформити замовлення)
            // 
            button1.Location = new Point(354, 300);
            button1.Name = "button1";
            button1.Size = new Size(133, 77);
            button1.TabIndex = 0;
            button1.Text = "оформити замовлення";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2 (Додати до кошику)
            // 
            button2.Location = new Point(166, 300);
            button2.Name = "button2";
            button2.Size = new Size(97, 51);
            button2.TabIndex = 1;
            button2.Text = "додати до кошику";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnAddToCart_Click;
            // 
            // listBoxInventory (Список товарів)
            // 
            listBoxInventory.FormattingEnabled = true;
            listBoxInventory.ItemHeight = 15;
            listBoxInventory.Location = new Point(12, 12);
            listBoxInventory.Name = "listBoxInventory";
            listBoxInventory.Size = new Size(250, 214);
            listBoxInventory.TabIndex = 2;
            // 
            // listBoxCart (Кошик)
            // 
            listBoxCart.FormattingEnabled = true;
            listBoxCart.ItemHeight = 15;
            listBoxCart.Location = new Point(300, 12);
            listBoxCart.Name = "listBoxCart";
            listBoxCart.Size = new Size(250, 214);
            listBoxCart.TabIndex = 3;
            // 
            // numericUpDownQty (Вибір кількості)
            // 
            numericUpDownQty.Location = new Point(166, 240);
            numericUpDownQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownQty.Name = "numericUpDownQty";
            numericUpDownQty.Size = new Size(97, 23);
            numericUpDownQty.TabIndex = 4;
            numericUpDownQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblTotal (Сума)
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotal.Location = new Point(300, 240);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(101, 21);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Сума: 0 грн";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 400);
            Controls.Add(lblTotal);
            Controls.Add(numericUpDownQty);
            Controls.Add(listBoxCart);
            // Додаємо новий список
            Controls.Add(listBoxInventory);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Мій Магазин";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        // ОСЬ ЦІ ОБ'ЄКТИ МИ ДОДАЛИ:
        private ListBox listBoxInventory;
        private ListBox listBoxCart;
        private NumericUpDown numericUpDownQty;
        private Label lblTotal;
    }
}