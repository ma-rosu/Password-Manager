using System.Windows.Forms;

namespace Password_Manager.Forms
{
    partial class MainMenuForm
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
            this.flowPanelEntries = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.checkView = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelShow = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtGenerated = new System.Windows.Forms.TextBox();
            this.numericInsert = new System.Windows.Forms.NumericUpDown();
            this.checkSpec = new System.Windows.Forms.CheckBox();
            this.checkNum = new System.Windows.Forms.CheckBox();
            this.checkAlpha = new System.Windows.Forms.CheckBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericInsert)).BeginInit();
            this.SuspendLayout();
            // 
            // flowPanelEntries
            // 
            this.flowPanelEntries.AutoScroll = true;
            this.flowPanelEntries.BackColor = System.Drawing.Color.GhostWhite;
            this.flowPanelEntries.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowPanelEntries.Location = new System.Drawing.Point(602, 12);
            this.flowPanelEntries.Name = "flowPanelEntries";
            this.flowPanelEntries.Size = new System.Drawing.Size(598, 747);
            this.flowPanelEntries.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.checkView);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtWebsite);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 365);
            this.panel1.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblID.Location = new System.Drawing.Point(404, 33);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(22, 16);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(407, 52);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(50, 22);
            this.txtID.TabIndex = 13;
            this.txtID.TabStop = false;
            this.txtID.Text = "0";
            // 
            // checkView
            // 
            this.checkView.AutoSize = true;
            this.checkView.Location = new System.Drawing.Point(349, 196);
            this.checkView.Name = "checkView";
            this.checkView.Size = new System.Drawing.Size(121, 20);
            this.checkView.TabIndex = 12;
            this.checkView.TabStop = false;
            this.checkView.Text = "View Password";
            this.checkView.UseVisualStyleBackColor = true;
            this.checkView.CheckedChanged += new System.EventHandler(this.checkView_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(45, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "PASSWORD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(45, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "WEBSITE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(44, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "USERNAME";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(47, 194);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(296, 22);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.TabStop = false;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(48, 122);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(296, 22);
            this.txtWebsite.TabIndex = 7;
            this.txtWebsite.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(48, 52);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(296, 22);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(421, 260);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 45);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(235, 260);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(108, 45);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(48, 260);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 45);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panelShow);
            this.panel2.Controls.Add(this.btnShow);
            this.panel2.Controls.Add(this.txtGenerated);
            this.panel2.Controls.Add(this.numericInsert);
            this.panel2.Controls.Add(this.checkSpec);
            this.panel2.Controls.Add(this.checkNum);
            this.panel2.Controls.Add(this.checkAlpha);
            this.panel2.Controls.Add(this.btnCopy);
            this.panel2.Controls.Add(this.btnGenerate);
            this.panel2.Location = new System.Drawing.Point(12, 383);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 376);
            this.panel2.TabIndex = 2;
            // 
            // panelShow
            // 
            this.panelShow.BackColor = System.Drawing.Color.Indigo;
            this.panelShow.Controls.Add(this.label4);
            this.panelShow.Location = new System.Drawing.Point(38, 77);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(491, 38);
            this.panelShow.TabIndex = 12;
            this.panelShow.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(133, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "The password is not here :)";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(48, 190);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(190, 42);
            this.btnShow.TabIndex = 11;
            this.btnShow.TabStop = false;
            this.btnShow.Text = "Hide Password";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShowHide_Click);
            // 
            // txtGenerated
            // 
            this.txtGenerated.Location = new System.Drawing.Point(38, 77);
            this.txtGenerated.MaximumSize = new System.Drawing.Size(491, 100);
            this.txtGenerated.MaxLength = 250;
            this.txtGenerated.Multiline = true;
            this.txtGenerated.Name = "txtGenerated";
            this.txtGenerated.ReadOnly = true;
            this.txtGenerated.Size = new System.Drawing.Size(491, 38);
            this.txtGenerated.TabIndex = 10;
            this.txtGenerated.TabStop = false;
            this.txtGenerated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericInsert
            // 
            this.numericInsert.Location = new System.Drawing.Point(315, 190);
            this.numericInsert.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericInsert.Name = "numericInsert";
            this.numericInsert.Size = new System.Drawing.Size(147, 22);
            this.numericInsert.TabIndex = 9;
            this.numericInsert.TabStop = false;
            this.numericInsert.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // checkSpec
            // 
            this.checkSpec.AutoSize = true;
            this.checkSpec.Checked = true;
            this.checkSpec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSpec.Location = new System.Drawing.Point(315, 308);
            this.checkSpec.Name = "checkSpec";
            this.checkSpec.Size = new System.Drawing.Size(143, 20);
            this.checkSpec.TabIndex = 8;
            this.checkSpec.TabStop = false;
            this.checkSpec.Text = "Special Characters";
            this.checkSpec.UseVisualStyleBackColor = true;
            // 
            // checkNum
            // 
            this.checkNum.AutoSize = true;
            this.checkNum.Checked = true;
            this.checkNum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkNum.Location = new System.Drawing.Point(315, 270);
            this.checkNum.Name = "checkNum";
            this.checkNum.Size = new System.Drawing.Size(147, 20);
            this.checkNum.TabIndex = 7;
            this.checkNum.TabStop = false;
            this.checkNum.Text = "Numeric Characters";
            this.checkNum.UseVisualStyleBackColor = true;
            // 
            // checkAlpha
            // 
            this.checkAlpha.AutoSize = true;
            this.checkAlpha.Checked = true;
            this.checkAlpha.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAlpha.Location = new System.Drawing.Point(315, 230);
            this.checkAlpha.Name = "checkAlpha";
            this.checkAlpha.Size = new System.Drawing.Size(161, 20);
            this.checkAlpha.TabIndex = 6;
            this.checkAlpha.TabStop = false;
            this.checkAlpha.Text = "Alphabetic Characters";
            this.checkAlpha.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(48, 286);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(190, 42);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.TabStop = false;
            this.btnCopy.Text = "Copy Password";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(48, 238);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(190, 42);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.TabStop = false;
            this.btnGenerate.Text = "Generate Password";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1212, 757);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowPanelEntries);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1234, 808);
            this.MinimumSize = new System.Drawing.Size(1215, 808);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelShow.ResumeLayout(false);
            this.panelShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericInsert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numericInsert;
        private System.Windows.Forms.CheckBox checkSpec;
        private System.Windows.Forms.CheckBox checkNum;
        private System.Windows.Forms.CheckBox checkAlpha;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtGenerated;
        private System.Windows.Forms.CheckBox checkView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.FlowLayoutPanel flowPanelEntries;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
    }
}