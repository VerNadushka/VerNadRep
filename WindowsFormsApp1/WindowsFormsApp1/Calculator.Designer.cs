namespace WindowsFormsApp1
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.label1 = new System.Windows.Forms.Label();
            this.screw = new System.Windows.Forms.Label();
            this.shelf = new System.Windows.Forms.Label();
            this.small = new System.Windows.Forms.Label();
            this.big = new System.Windows.Forms.Label();
            this.screwI = new System.Windows.Forms.Label();
            this.bigI = new System.Windows.Forms.Label();
            this.smallI = new System.Windows.Forms.Label();
            this.shelfI = new System.Windows.Forms.Label();
            this.ScrewTextBox = new System.Windows.Forms.TextBox();
            this.BigTextBox = new System.Windows.Forms.TextBox();
            this.SmallTextBox = new System.Windows.Forms.TextBox();
            this.ShelfTextBox = new System.Windows.Forms.TextBox();
            this.UpLoad = new System.Windows.Forms.Button();
            this.ZadanieButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "На скалде имеются:";
            // 
            // screw
            // 
            this.screw.AutoSize = true;
            this.screw.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.screw.Location = new System.Drawing.Point(17, 86);
            this.screw.Name = "screw";
            this.screw.Size = new System.Drawing.Size(111, 30);
            this.screw.TabIndex = 1;
            this.screw.Text = "Саморезы";
            // 
            // shelf
            // 
            this.shelf.AutoSize = true;
            this.shelf.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shelf.Location = new System.Drawing.Point(17, 208);
            this.shelf.Name = "shelf";
            this.shelf.Size = new System.Drawing.Size(73, 30);
            this.shelf.TabIndex = 2;
            this.shelf.Text = "Полки";
            // 
            // small
            // 
            this.small.AutoSize = true;
            this.small.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.small.Location = new System.Drawing.Point(17, 167);
            this.small.Name = "small";
            this.small.Size = new System.Drawing.Size(172, 30);
            this.small.TabIndex = 3;
            this.small.Text = "Двери тумбочки";
            // 
            // big
            // 
            this.big.AutoSize = true;
            this.big.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.big.Location = new System.Drawing.Point(17, 126);
            this.big.Name = "big";
            this.big.Size = new System.Drawing.Size(162, 30);
            this.big.TabIndex = 4;
            this.big.Text = "Большие двери";
            // 
            // screwI
            // 
            this.screwI.AutoSize = true;
            this.screwI.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.screwI.Location = new System.Drawing.Point(134, 86);
            this.screwI.Name = "screwI";
            this.screwI.Size = new System.Drawing.Size(0, 30);
            this.screwI.TabIndex = 5;
            // 
            // bigI
            // 
            this.bigI.AutoSize = true;
            this.bigI.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bigI.Location = new System.Drawing.Point(185, 126);
            this.bigI.Name = "bigI";
            this.bigI.Size = new System.Drawing.Size(0, 30);
            this.bigI.TabIndex = 6;
            // 
            // smallI
            // 
            this.smallI.AutoSize = true;
            this.smallI.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.smallI.Location = new System.Drawing.Point(185, 167);
            this.smallI.Name = "smallI";
            this.smallI.Size = new System.Drawing.Size(0, 30);
            this.smallI.TabIndex = 7;
            // 
            // shelfI
            // 
            this.shelfI.AutoSize = true;
            this.shelfI.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shelfI.Location = new System.Drawing.Point(96, 208);
            this.shelfI.Name = "shelfI";
            this.shelfI.Size = new System.Drawing.Size(0, 30);
            this.shelfI.TabIndex = 8;
            // 
            // ScrewTextBox
            // 
            this.ScrewTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScrewTextBox.Location = new System.Drawing.Point(234, 86);
            this.ScrewTextBox.Name = "ScrewTextBox";
            this.ScrewTextBox.Size = new System.Drawing.Size(100, 35);
            this.ScrewTextBox.TabIndex = 9;
            // 
            // BigTextBox
            // 
            this.BigTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BigTextBox.Location = new System.Drawing.Point(234, 126);
            this.BigTextBox.Name = "BigTextBox";
            this.BigTextBox.Size = new System.Drawing.Size(100, 35);
            this.BigTextBox.TabIndex = 10;
            // 
            // SmallTextBox
            // 
            this.SmallTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SmallTextBox.Location = new System.Drawing.Point(234, 167);
            this.SmallTextBox.Name = "SmallTextBox";
            this.SmallTextBox.Size = new System.Drawing.Size(100, 35);
            this.SmallTextBox.TabIndex = 11;
            // 
            // ShelfTextBox
            // 
            this.ShelfTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShelfTextBox.Location = new System.Drawing.Point(234, 208);
            this.ShelfTextBox.Name = "ShelfTextBox";
            this.ShelfTextBox.Size = new System.Drawing.Size(100, 35);
            this.ShelfTextBox.TabIndex = 12;
            // 
            // UpLoad
            // 
            this.UpLoad.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpLoad.Location = new System.Drawing.Point(22, 286);
            this.UpLoad.Name = "UpLoad";
            this.UpLoad.Size = new System.Drawing.Size(123, 43);
            this.UpLoad.TabIndex = 13;
            this.UpLoad.Text = "Обновить";
            this.UpLoad.UseVisualStyleBackColor = true;
            this.UpLoad.Click += new System.EventHandler(this.UpLoad_Click);
            // 
            // ZadanieButton
            // 
            this.ZadanieButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZadanieButton.Location = new System.Drawing.Point(181, 286);
            this.ZadanieButton.Name = "ZadanieButton";
            this.ZadanieButton.Size = new System.Drawing.Size(378, 43);
            this.ZadanieButton.TabIndex = 14;
            this.ZadanieButton.Text = "Неограниченное кол-во ресурсов";
            this.ZadanieButton.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 381);
            this.Controls.Add(this.ZadanieButton);
            this.Controls.Add(this.UpLoad);
            this.Controls.Add(this.ShelfTextBox);
            this.Controls.Add(this.SmallTextBox);
            this.Controls.Add(this.BigTextBox);
            this.Controls.Add(this.ScrewTextBox);
            this.Controls.Add(this.shelfI);
            this.Controls.Add(this.smallI);
            this.Controls.Add(this.bigI);
            this.Controls.Add(this.screwI);
            this.Controls.Add(this.big);
            this.Controls.Add(this.small);
            this.Controls.Add(this.shelf);
            this.Controls.Add(this.screw);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label screw;
        private System.Windows.Forms.Label shelf;
        private System.Windows.Forms.Label small;
        private System.Windows.Forms.Label big;
        private System.Windows.Forms.Label screwI;
        private System.Windows.Forms.Label bigI;
        private System.Windows.Forms.Label smallI;
        private System.Windows.Forms.Label shelfI;
        private System.Windows.Forms.TextBox ScrewTextBox;
        private System.Windows.Forms.TextBox BigTextBox;
        private System.Windows.Forms.TextBox SmallTextBox;
        private System.Windows.Forms.TextBox ShelfTextBox;
        private System.Windows.Forms.Button UpLoad;
        private System.Windows.Forms.Button ZadanieButton;
    }
}