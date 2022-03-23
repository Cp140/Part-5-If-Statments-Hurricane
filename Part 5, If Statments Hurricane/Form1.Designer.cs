namespace Part_5__If_Statments_Hurricane
{
    partial class mainForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.lblWindSpeedMPH = new System.Windows.Forms.Label();
            this.lblHuricaneCat = new System.Windows.Forms.Label();
            this.lblMPH = new System.Windows.Forms.Label();
            this.lblKNOTS = new System.Windows.Forms.Label();
            this.lblKPH = new System.Windows.Forms.Label();
            this.lblWindSpeedKNOTS = new System.Windows.Forms.Label();
            this.lblWindSpeedKPH = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(60, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(148, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hurricane Status";
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(163, 34);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(100, 20);
            this.txtCat.TabIndex = 1;
            this.txtCat.TextChanged += new System.EventHandler(this.txtWindSpeed_TextChanged);
            // 
            // lblWindSpeedMPH
            // 
            this.lblWindSpeedMPH.AutoSize = true;
            this.lblWindSpeedMPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindSpeedMPH.Location = new System.Drawing.Point(12, 116);
            this.lblWindSpeedMPH.Name = "lblWindSpeedMPH";
            this.lblWindSpeedMPH.Size = new System.Drawing.Size(124, 18);
            this.lblWindSpeedMPH.TabIndex = 2;
            this.lblWindSpeedMPH.Text = "Wind speed MPH";
            // 
            // lblHuricaneCat
            // 
            this.lblHuricaneCat.AutoSize = true;
            this.lblHuricaneCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHuricaneCat.Location = new System.Drawing.Point(12, 36);
            this.lblHuricaneCat.Name = "lblHuricaneCat";
            this.lblHuricaneCat.Size = new System.Drawing.Size(131, 18);
            this.lblHuricaneCat.TabIndex = 3;
            this.lblHuricaneCat.Text = "Huricane Category";
            // 
            // lblMPH
            // 
            this.lblMPH.AutoSize = true;
            this.lblMPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMPH.Location = new System.Drawing.Point(160, 116);
            this.lblMPH.Name = "lblMPH";
            this.lblMPH.Size = new System.Drawing.Size(42, 18);
            this.lblMPH.TabIndex = 4;
            this.lblMPH.Text = "MPH";
            // 
            // lblKNOTS
            // 
            this.lblKNOTS.AutoSize = true;
            this.lblKNOTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKNOTS.Location = new System.Drawing.Point(160, 87);
            this.lblKNOTS.Name = "lblKNOTS";
            this.lblKNOTS.Size = new System.Drawing.Size(60, 18);
            this.lblKNOTS.TabIndex = 6;
            this.lblKNOTS.Text = "KNOTS";
            // 
            // lblKPH
            // 
            this.lblKPH.AutoSize = true;
            this.lblKPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKPH.Location = new System.Drawing.Point(160, 60);
            this.lblKPH.Name = "lblKPH";
            this.lblKPH.Size = new System.Drawing.Size(39, 18);
            this.lblKPH.TabIndex = 7;
            this.lblKPH.Text = "KPH";
            // 
            // lblWindSpeedKNOTS
            // 
            this.lblWindSpeedKNOTS.AutoSize = true;
            this.lblWindSpeedKNOTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindSpeedKNOTS.Location = new System.Drawing.Point(12, 87);
            this.lblWindSpeedKNOTS.Name = "lblWindSpeedKNOTS";
            this.lblWindSpeedKNOTS.Size = new System.Drawing.Size(142, 18);
            this.lblWindSpeedKNOTS.TabIndex = 8;
            this.lblWindSpeedKNOTS.Text = "Wind speed KNOTS";
            // 
            // lblWindSpeedKPH
            // 
            this.lblWindSpeedKPH.AutoSize = true;
            this.lblWindSpeedKPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindSpeedKPH.Location = new System.Drawing.Point(12, 60);
            this.lblWindSpeedKPH.Name = "lblWindSpeedKPH";
            this.lblWindSpeedKPH.Size = new System.Drawing.Size(121, 18);
            this.lblWindSpeedKPH.TabIndex = 9;
            this.lblWindSpeedKPH.Text = "Wind speed KPH";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(103, 137);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(131, 45);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 184);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblWindSpeedKPH);
            this.Controls.Add(this.lblWindSpeedKNOTS);
            this.Controls.Add(this.lblKPH);
            this.Controls.Add(this.lblKNOTS);
            this.Controls.Add(this.lblMPH);
            this.Controls.Add(this.lblHuricaneCat);
            this.Controls.Add(this.lblWindSpeedMPH);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(this.lblTitle);
            this.Name = "mainForm";
            this.Text = "Hurricane Status";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.Label lblWindSpeedMPH;
        private System.Windows.Forms.Label lblHuricaneCat;
        private System.Windows.Forms.Label lblMPH;
        private System.Windows.Forms.Label lblKNOTS;
        private System.Windows.Forms.Label lblKPH;
        private System.Windows.Forms.Label lblWindSpeedKNOTS;
        private System.Windows.Forms.Label lblWindSpeedKPH;
        private System.Windows.Forms.Button btnSubmit;
    }
}

