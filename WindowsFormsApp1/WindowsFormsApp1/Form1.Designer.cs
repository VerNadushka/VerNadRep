namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ConnectButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Screw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BigDoor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BedsidetableDoor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shelf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenForm2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConnectButton.Location = new System.Drawing.Point(588, 79);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(183, 43);
            this.ConnectButton.TabIndex = 1;
            this.ConnectButton.Text = "Подключиться";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Screw,
            this.BigDoor,
            this.BedsidetableDoor,
            this.Shelf});
            this.dataGridView1.Location = new System.Drawing.Point(330, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 108);
            this.dataGridView1.TabIndex = 0;
            // 
            // Screw
            // 
            this.Screw.HeaderText = "Screw";
            this.Screw.Name = "Screw";
            // 
            // BigDoor
            // 
            this.BigDoor.HeaderText = "Big Door";
            this.BigDoor.Name = "BigDoor";
            // 
            // BedsidetableDoor
            // 
            this.BedsidetableDoor.HeaderText = "Bedside Table Door";
            this.BedsidetableDoor.Name = "BedsidetableDoor";
            // 
            // Shelf
            // 
            this.Shelf.HeaderText = "Shelf";
            this.Shelf.Name = "Shelf";
            // 
            // OpenForm2
            // 
            this.OpenForm2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenForm2.Location = new System.Drawing.Point(56, 171);
            this.OpenForm2.Name = "OpenForm2";
            this.OpenForm2.Size = new System.Drawing.Size(172, 113);
            this.OpenForm2.TabIndex = 2;
            this.OpenForm2.Text = "Открыть Калькулятор";
            this.OpenForm2.UseVisualStyleBackColor = true;
            this.OpenForm2.Click += new System.EventHandler(this.OpenForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OpenForm2);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ZXCPLATFORMA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Screw;
        private System.Windows.Forms.DataGridViewTextBoxColumn BigDoor;
        private System.Windows.Forms.DataGridViewTextBoxColumn BedsidetableDoor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shelf;
        private System.Windows.Forms.Button OpenForm2;
    }
}

