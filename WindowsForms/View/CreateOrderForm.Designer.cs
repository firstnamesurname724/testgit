
namespace WindowsForms
{
    partial class CreateOrderForm
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
            this.lDate = new System.Windows.Forms.Label();
            this.lEmp = new System.Windows.Forms.Label();
            this.lBuyer = new System.Windows.Forms.Label();
            this.cbBuyer = new System.Windows.Forms.ComboBox();
            this.cbEmp = new System.Windows.Forms.ComboBox();
            this.saleDate = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDate.Location = new System.Drawing.Point(12, 96);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(56, 21);
            this.lDate.TabIndex = 6;
            this.lDate.Text = "Дата: ";
            // 
            // lEmp
            // 
            this.lEmp.AutoSize = true;
            this.lEmp.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lEmp.Location = new System.Drawing.Point(12, 54);
            this.lEmp.Name = "lEmp";
            this.lEmp.Size = new System.Drawing.Size(104, 21);
            this.lEmp.TabIndex = 5;
            this.lEmp.Text = "Сотрудник: ";
            // 
            // lBuyer
            // 
            this.lBuyer.AutoSize = true;
            this.lBuyer.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lBuyer.Location = new System.Drawing.Point(12, 12);
            this.lBuyer.Name = "lBuyer";
            this.lBuyer.Size = new System.Drawing.Size(111, 21);
            this.lBuyer.TabIndex = 4;
            this.lBuyer.Text = "Покупатель: ";
            // 
            // cbBuyer
            // 
            this.cbBuyer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBuyer.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbBuyer.FormattingEnabled = true;
            this.cbBuyer.Location = new System.Drawing.Point(129, 9);
            this.cbBuyer.Name = "cbBuyer";
            this.cbBuyer.Size = new System.Drawing.Size(400, 27);
            this.cbBuyer.TabIndex = 7;
            // 
            // cbEmp
            // 
            this.cbEmp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEmp.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbEmp.FormattingEnabled = true;
            this.cbEmp.Location = new System.Drawing.Point(129, 51);
            this.cbEmp.Name = "cbEmp";
            this.cbEmp.Size = new System.Drawing.Size(400, 27);
            this.cbEmp.TabIndex = 8;
            // 
            // saleDate
            // 
            this.saleDate.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saleDate.Location = new System.Drawing.Point(129, 94);
            this.saleDate.Name = "saleDate";
            this.saleDate.Size = new System.Drawing.Size(244, 25);
            this.saleDate.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(427, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 34);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.Location = new System.Drawing.Point(319, 287);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(102, 34);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Корзина: ";
            // 
            // btnCart
            // 
            this.btnCart.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCart.Location = new System.Drawing.Point(14, 175);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(207, 27);
            this.btnCart.TabIndex = 13;
            this.btnCart.Text = "Редактировать";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // CreateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 333);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.saleDate);
            this.Controls.Add(this.cbEmp);
            this.Controls.Add(this.cbBuyer);
            this.Controls.Add(this.lDate);
            this.Controls.Add(this.lEmp);
            this.Controls.Add(this.lBuyer);
            this.Name = "CreateOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание заказа";
            this.Load += new System.EventHandler(this.CreateOrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.Label lEmp;
        private System.Windows.Forms.Label lBuyer;
        private System.Windows.Forms.ComboBox cbBuyer;
        private System.Windows.Forms.ComboBox cbEmp;
        private System.Windows.Forms.DateTimePicker saleDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCart;
    }
}