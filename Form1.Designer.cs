namespace Houseplant_Suggestions
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
            this.chkSouthFacing = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSuggestion = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.trkTemp = new System.Windows.Forms.TrackBar();
            this.lnkHousePlantInfo = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.trkTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // chkSouthFacing
            // 
            this.chkSouthFacing.AutoSize = true;
            this.chkSouthFacing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSouthFacing.Location = new System.Drawing.Point(74, 32);
            this.chkSouthFacing.Name = "chkSouthFacing";
            this.chkSouthFacing.Size = new System.Drawing.Size(258, 21);
            this.chkSouthFacing.TabIndex = 0;
            this.chkSouthFacing.Text = "Do you have a south-facing window?";
            this.chkSouthFacing.UseVisualStyleBackColor = true;
            this.chkSouthFacing.CheckedChanged += new System.EventHandler(this.HouseConditionsChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "How  warm is your home?";
            // 
            // lblSuggestion
            // 
            this.lblSuggestion.AutoSize = true;
            this.lblSuggestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuggestion.Location = new System.Drawing.Point(207, 178);
            this.lblSuggestion.Name = "lblSuggestion";
            this.lblSuggestion.Size = new System.Drawing.Size(146, 17);
            this.lblSuggestion.TabIndex = 3;
            this.lblSuggestion.Text = "Plant suggestion here";
            this.lblSuggestion.Click += new System.EventHandler(this.lblSuggestion_Click);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(246, 117);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(29, 13);
            this.lblTemp.TabIndex = 4;
            this.lblTemp.Text = "50 °f";
            this.lblTemp.Click += new System.EventHandler(this.label3_Click);
            // 
            // trkTemp
            // 
            this.trkTemp.Location = new System.Drawing.Point(74, 117);
            this.trkTemp.Maximum = 90;
            this.trkTemp.Minimum = 50;
            this.trkTemp.Name = "trkTemp";
            this.trkTemp.Size = new System.Drawing.Size(166, 45);
            this.trkTemp.TabIndex = 5;
            this.trkTemp.Value = 50;
            this.trkTemp.Scroll += new System.EventHandler(this.HouseConditionsChanged);
            // 
            // lnkHousePlantInfo
            // 
            this.lnkHousePlantInfo.AutoSize = true;
            this.lnkHousePlantInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkHousePlantInfo.Location = new System.Drawing.Point(368, 216);
            this.lnkHousePlantInfo.Name = "lnkHousePlantInfo";
            this.lnkHousePlantInfo.Size = new System.Drawing.Size(132, 17);
            this.lnkHousePlantInfo.TabIndex = 6;
            this.lnkHousePlantInfo.TabStop = true;
            this.lnkHousePlantInfo.Text = "houseplant411.com";
            this.lnkHousePlantInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHousePlantInfo_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lnkHousePlantInfo);
            this.Controls.Add(this.trkTemp);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblSuggestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkSouthFacing);
            this.Name = "Form1";
            this.Text = "Houseplant Suggestions";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkSouthFacing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSuggestion;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.TrackBar trkTemp;
        private System.Windows.Forms.LinkLabel lnkHousePlantInfo;
    }
}

