
namespace WindowsForms
{
    partial class CheckInfoForm
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
            this.lNumber = new System.Windows.Forms.Label();
            this.lBuyer = new System.Windows.Forms.Label();
            this.lEmp = new System.Windows.Forms.Label();
            this.lDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lNumber
            // 
            this.lNumber.AutoSize = true;
            this.lNumber.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lNumber.Location = new System.Drawing.Point(12, 9);
            this.lNumber.Name = "lNumber";
            this.lNumber.Size = new System.Drawing.Size(82, 28);
            this.lNumber.TabIndex = 0;
            this.lNumber.Text = "Чек №";
            // 
            // lBuyer
            // 
            this.lBuyer.AutoSize = true;
            this.lBuyer.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lBuyer.Location = new System.Drawing.Point(12, 62);
            this.lBuyer.Name = "lBuyer";
            this.lBuyer.Size = new System.Drawing.Size(111, 21);
            this.lBuyer.TabIndex = 1;
            this.lBuyer.Text = "Покупатель: ";
            // 
            // lEmp
            // 
            this.lEmp.AutoSize = true;
            this.lEmp.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lEmp.Location = new System.Drawing.Point(13, 87);
            this.lEmp.Name = "lEmp";
            this.lEmp.Size = new System.Drawing.Size(104, 21);
            this.lEmp.TabIndex = 2;
            this.lEmp.Text = "Сотрудник: ";
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDate.Location = new System.Drawing.Point(13, 112);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(56, 21);
            this.lDate.TabIndex = 3;
            this.lDate.Text = "Дата: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Корзина: ";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 179);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(613, 241);
            this.dgv.TabIndex = 5;
            // 
            // CheckInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 432);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lDate);
            this.Controls.Add(this.lEmp);
            this.Controls.Add(this.lBuyer);
            this.Controls.Add(this.lNumber);
            this.Name = "CheckInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сведения о заказе";
            this.Load += new System.EventHandler(this.CheckInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNumber;
        private System.Windows.Forms.Label lBuyer;
        private System.Windows.Forms.Label lEmp;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv;
    }
}