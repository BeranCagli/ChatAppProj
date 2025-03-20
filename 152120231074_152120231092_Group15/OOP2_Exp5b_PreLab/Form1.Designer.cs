namespace OOP2_Exp5b_PreLab
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.listBox_city = new System.Windows.Forms.ListBox();
            this.listBox_district = new System.Windows.Forms.ListBox();
            this.label_city = new System.Windows.Forms.Label();
            this.listBox_orders = new System.Windows.Forms.ListBox();
            this.label_district = new System.Windows.Forms.Label();
            this.label_food_orderin_system = new System.Windows.Forms.Label();
            this.maskedTextBox_phone = new System.Windows.Forms.MaskedTextBox();
            this.btn_delete_order = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox_dishes = new System.Windows.Forms.ListBox();
            this.numericUpDown_quantity = new System.Windows.Forms.NumericUpDown();
            this.label_dishes = new System.Windows.Forms.Label();
            this.label_quantity = new System.Windows.Forms.Label();
            this.btn_create_order = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_name.Location = new System.Drawing.Point(6, 83);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(225, 34);
            this.textBox_name.TabIndex = 0;
            this.textBox_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_name_KeyPress);
            // 
            // listBox_city
            // 
            this.listBox_city.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBox_city.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox_city.FormattingEnabled = true;
            this.listBox_city.ItemHeight = 28;
            this.listBox_city.Items.AddRange(new object[] {
            "Bursa",
            "Eskişehir"});
            this.listBox_city.Location = new System.Drawing.Point(6, 235);
            this.listBox_city.Name = "listBox_city";
            this.listBox_city.Size = new System.Drawing.Size(225, 60);
            this.listBox_city.TabIndex = 7;
            this.listBox_city.SelectedIndexChanged += new System.EventHandler(this.listBox_city_SelectedIndexChanged);
            // 
            // listBox_district
            // 
            this.listBox_district.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBox_district.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox_district.FormattingEnabled = true;
            this.listBox_district.ItemHeight = 28;
            this.listBox_district.Location = new System.Drawing.Point(6, 334);
            this.listBox_district.Name = "listBox_district";
            this.listBox_district.Size = new System.Drawing.Size(225, 88);
            this.listBox_district.TabIndex = 9;
            this.listBox_district.SelectedIndexChanged += new System.EventHandler(this.listBox_district_SelectedIndexChanged);
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.BackColor = System.Drawing.Color.Transparent;
            this.label_city.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_city.Location = new System.Drawing.Point(1, 203);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(67, 23);
            this.label_city.TabIndex = 10;
            this.label_city.Text = "Adres İl";
            // 
            // listBox_orders
            // 
            this.listBox_orders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listBox_orders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox_orders.FormattingEnabled = true;
            this.listBox_orders.ItemHeight = 28;
            this.listBox_orders.Location = new System.Drawing.Point(616, 129);
            this.listBox_orders.Name = "listBox_orders";
            this.listBox_orders.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_orders.Size = new System.Drawing.Size(300, 256);
            this.listBox_orders.TabIndex = 12;
            this.listBox_orders.SelectedIndexChanged += new System.EventHandler(this.listBox_orders_SelectedIndexChanged);
            // 
            // label_district
            // 
            this.label_district.AutoSize = true;
            this.label_district.BackColor = System.Drawing.Color.Transparent;
            this.label_district.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_district.Location = new System.Drawing.Point(3, 304);
            this.label_district.Name = "label_district";
            this.label_district.Size = new System.Drawing.Size(84, 23);
            this.label_district.TabIndex = 13;
            this.label_district.Text = "Adres İlçe";
            // 
            // label_food_orderin_system
            // 
            this.label_food_orderin_system.AutoSize = true;
            this.label_food_orderin_system.BackColor = System.Drawing.Color.Transparent;
            this.label_food_orderin_system.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_food_orderin_system.Location = new System.Drawing.Point(313, 9);
            this.label_food_orderin_system.Name = "label_food_orderin_system";
            this.label_food_orderin_system.Size = new System.Drawing.Size(336, 38);
            this.label_food_orderin_system.TabIndex = 15;
            this.label_food_orderin_system.Text = "YEMEK SİPARİŞ SİSTEMİ";
            // 
            // maskedTextBox_phone
            // 
            this.maskedTextBox_phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.maskedTextBox_phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBox_phone.Location = new System.Drawing.Point(5, 156);
            this.maskedTextBox_phone.Mask = "9999 000 00 00";
            this.maskedTextBox_phone.Name = "maskedTextBox_phone";
            this.maskedTextBox_phone.Size = new System.Drawing.Size(226, 34);
            this.maskedTextBox_phone.TabIndex = 16;
            // 
            // btn_delete_order
            // 
            this.btn_delete_order.BackColor = System.Drawing.Color.Crimson;
            this.btn_delete_order.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_delete_order.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete_order.Location = new System.Drawing.Point(654, 391);
            this.btn_delete_order.Name = "btn_delete_order";
            this.btn_delete_order.Size = new System.Drawing.Size(225, 50);
            this.btn_delete_order.TabIndex = 17;
            this.btn_delete_order.Text = "SEÇİLİ SİPARİŞİ SİL";
            this.btn_delete_order.UseVisualStyleBackColor = false;
            this.btn_delete_order.Click += new System.EventHandler(this.btn_delete_order_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.Transparent;
            this.label_name.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_name.Location = new System.Drawing.Point(3, 57);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(146, 23);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Müşteri Ad-Soyad";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.BackColor = System.Drawing.Color.Transparent;
            this.label_phone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_phone.Location = new System.Drawing.Point(3, 130);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(126, 23);
            this.label_phone.TabIndex = 2;
            this.label_phone.Text = "Müşteri Telefon";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox_phone);
            this.groupBox1.Controls.Add(this.label_district);
            this.groupBox1.Controls.Add(this.label_city);
            this.groupBox1.Controls.Add(this.listBox_district);
            this.groupBox1.Controls.Add(this.listBox_city);
            this.groupBox1.Controls.Add(this.label_phone);
            this.groupBox1.Controls.Add(this.label_name);
            this.groupBox1.Controls.Add(this.textBox_name);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(45, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 426);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // listBox_dishes
            // 
            this.listBox_dishes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listBox_dishes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox_dishes.FormattingEnabled = true;
            this.listBox_dishes.ItemHeight = 28;
            this.listBox_dishes.Items.AddRange(new object[] {
            "Hamburger",
            "Pizza",
            "Döner"});
            this.listBox_dishes.Location = new System.Drawing.Point(7, 83);
            this.listBox_dishes.Name = "listBox_dishes";
            this.listBox_dishes.Size = new System.Drawing.Size(225, 88);
            this.listBox_dishes.TabIndex = 4;
            this.listBox_dishes.SelectedIndexChanged += new System.EventHandler(this.listBox_dishes_SelectedIndexChanged);
            // 
            // numericUpDown_quantity
            // 
            this.numericUpDown_quantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.numericUpDown_quantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown_quantity.Location = new System.Drawing.Point(6, 215);
            this.numericUpDown_quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_quantity.Name = "numericUpDown_quantity";
            this.numericUpDown_quantity.Size = new System.Drawing.Size(225, 34);
            this.numericUpDown_quantity.TabIndex = 5;
            this.numericUpDown_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_dishes
            // 
            this.label_dishes.AutoSize = true;
            this.label_dishes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_dishes.ForeColor = System.Drawing.Color.Black;
            this.label_dishes.Location = new System.Drawing.Point(2, 57);
            this.label_dishes.Name = "label_dishes";
            this.label_dishes.Size = new System.Drawing.Size(78, 23);
            this.label_dishes.TabIndex = 6;
            this.label_dishes.Text = "Yemekler";
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_quantity.Location = new System.Drawing.Point(3, 189);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(46, 23);
            this.label_quantity.TabIndex = 8;
            this.label_quantity.Text = "Adet";
            // 
            // btn_create_order
            // 
            this.btn_create_order.BackColor = System.Drawing.Color.Green;
            this.btn_create_order.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_create_order.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_create_order.Location = new System.Drawing.Point(329, 389);
            this.btn_create_order.Name = "btn_create_order";
            this.btn_create_order.Size = new System.Drawing.Size(225, 50);
            this.btn_create_order.TabIndex = 11;
            this.btn_create_order.Text = "SİPARİŞ OLUŞTUR";
            this.btn_create_order.UseVisualStyleBackColor = false;
            this.btn_create_order.Click += new System.EventHandler(this.btn_create_order_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_quantity);
            this.groupBox2.Controls.Add(this.label_dishes);
            this.groupBox2.Controls.Add(this.numericUpDown_quantity);
            this.groupBox2.Controls.Add(this.listBox_dishes);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(329, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 254);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yemek Seçimi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(611, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Siparişlerim";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(967, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_orders);
            this.Controls.Add(this.btn_create_order);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_delete_order);
            this.Controls.Add(this.label_food_orderin_system);
            this.Name = "Form1";
            this.Text = "Yemek Sipariş Sistemi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.ListBox listBox_city;
        private System.Windows.Forms.ListBox listBox_district;
        private System.Windows.Forms.Label label_city;
        private System.Windows.Forms.ListBox listBox_orders;
        private System.Windows.Forms.Label label_district;
        private System.Windows.Forms.Label label_food_orderin_system;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_phone;
        private System.Windows.Forms.Button btn_delete_order;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox_dishes;
        private System.Windows.Forms.NumericUpDown numericUpDown_quantity;
        private System.Windows.Forms.Label label_dishes;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.Button btn_create_order;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}

