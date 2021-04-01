namespace MVP_Patterns_Practice.Views
{
    partial class MainView
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
            this.components = new System.ComponentModel.Container();
            this.gasLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.priceLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gasCmbbx = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pricePerLiterTxtb = new Guna.UI2.WinForms.Guna2TextBox();
            this.priceRdbtn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.literRbtn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.literTxtb = new Guna.UI2.WinForms.Guna2TextBox();
            this.priceTxtb = new Guna.UI2.WinForms.Guna2TextBox();
            this.totalPriceGrpbx = new Guna.UI2.WinForms.Guna2GroupBox();
            this.addBtn = new Guna.UI2.WinForms.Guna2Button();
            this.paymentListBox = new System.Windows.Forms.ListBox();
            this.loadBtn = new Guna.UI2.WinForms.Guna2Button();
            this.TotalLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.totalPriceGrpbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // gasLbl
            // 
            this.gasLbl.BackColor = System.Drawing.Color.Transparent;
            this.gasLbl.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gasLbl.Location = new System.Drawing.Point(12, 42);
            this.gasLbl.Name = "gasLbl";
            this.gasLbl.Size = new System.Drawing.Size(37, 35);
            this.gasLbl.TabIndex = 0;
            this.gasLbl.Text = "Gas";
            // 
            // priceLbl
            // 
            this.priceLbl.BackColor = System.Drawing.Color.Transparent;
            this.priceLbl.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLbl.Location = new System.Drawing.Point(12, 107);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(51, 35);
            this.priceLbl.TabIndex = 1;
            this.priceLbl.Text = "Price";
            // 
            // gasCmbbx
            // 
            this.gasCmbbx.BackColor = System.Drawing.Color.Transparent;
            this.gasCmbbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gasCmbbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gasCmbbx.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gasCmbbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gasCmbbx.FocusedState.Parent = this.gasCmbbx;
            this.gasCmbbx.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
            this.gasCmbbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gasCmbbx.HoverState.Parent = this.gasCmbbx;
            this.gasCmbbx.ItemHeight = 30;
            this.gasCmbbx.ItemsAppearance.Parent = this.gasCmbbx;
            this.gasCmbbx.Location = new System.Drawing.Point(89, 42);
            this.gasCmbbx.Name = "gasCmbbx";
            this.gasCmbbx.ShadowDecoration.Parent = this.gasCmbbx;
            this.gasCmbbx.Size = new System.Drawing.Size(179, 36);
            this.gasCmbbx.TabIndex = 2;
            this.gasCmbbx.SelectedIndexChanged += new System.EventHandler(this.gasCmbbx_SelectedIndexChanged);
            // 
            // pricePerLiterTxtb
            // 
            this.pricePerLiterTxtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pricePerLiterTxtb.DefaultText = "";
            this.pricePerLiterTxtb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pricePerLiterTxtb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pricePerLiterTxtb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pricePerLiterTxtb.DisabledState.Parent = this.pricePerLiterTxtb;
            this.pricePerLiterTxtb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pricePerLiterTxtb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pricePerLiterTxtb.FocusedState.Parent = this.pricePerLiterTxtb;
            this.pricePerLiterTxtb.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pricePerLiterTxtb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pricePerLiterTxtb.HoverState.Parent = this.pricePerLiterTxtb;
            this.pricePerLiterTxtb.Location = new System.Drawing.Point(89, 107);
            this.pricePerLiterTxtb.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.pricePerLiterTxtb.Name = "pricePerLiterTxtb";
            this.pricePerLiterTxtb.PasswordChar = '\0';
            this.pricePerLiterTxtb.PlaceholderText = "";
            this.pricePerLiterTxtb.ReadOnly = true;
            this.pricePerLiterTxtb.SelectedText = "";
            this.pricePerLiterTxtb.ShadowDecoration.Parent = this.pricePerLiterTxtb;
            this.pricePerLiterTxtb.Size = new System.Drawing.Size(179, 36);
            this.pricePerLiterTxtb.TabIndex = 3;
            // 
            // priceRdbtn
            // 
            this.priceRdbtn.AutoSize = true;
            this.priceRdbtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceRdbtn.CheckedState.BorderThickness = 0;
            this.priceRdbtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceRdbtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.priceRdbtn.CheckedState.InnerOffset = -4;
            this.priceRdbtn.Enabled = false;
            this.priceRdbtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceRdbtn.Location = new System.Drawing.Point(12, 244);
            this.priceRdbtn.Name = "priceRdbtn";
            this.priceRdbtn.Size = new System.Drawing.Size(70, 32);
            this.priceRdbtn.TabIndex = 4;
            this.priceRdbtn.Text = "Price";
            this.priceRdbtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.priceRdbtn.UncheckedState.BorderThickness = 2;
            this.priceRdbtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.priceRdbtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.priceRdbtn.CheckedChanged += new System.EventHandler(this.priceRdbtn_CheckedChanged);
            // 
            // literRbtn
            // 
            this.literRbtn.AutoSize = true;
            this.literRbtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.literRbtn.CheckedState.BorderThickness = 0;
            this.literRbtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.literRbtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.literRbtn.CheckedState.InnerOffset = -4;
            this.literRbtn.Enabled = false;
            this.literRbtn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.literRbtn.Location = new System.Drawing.Point(12, 185);
            this.literRbtn.Name = "literRbtn";
            this.literRbtn.Size = new System.Drawing.Size(68, 32);
            this.literRbtn.TabIndex = 5;
            this.literRbtn.Text = "Liter";
            this.literRbtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.literRbtn.UncheckedState.BorderThickness = 2;
            this.literRbtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.literRbtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.literRbtn.CheckedChanged += new System.EventHandler(this.literRbtn_CheckedChanged);
            // 
            // literTxtb
            // 
            this.literTxtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.literTxtb.DefaultText = "";
            this.literTxtb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.literTxtb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.literTxtb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.literTxtb.DisabledState.Parent = this.literTxtb;
            this.literTxtb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.literTxtb.Enabled = false;
            this.literTxtb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.literTxtb.FocusedState.Parent = this.literTxtb;
            this.literTxtb.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.literTxtb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.literTxtb.HoverState.Parent = this.literTxtb;
            this.literTxtb.Location = new System.Drawing.Point(87, 179);
            this.literTxtb.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.literTxtb.Name = "literTxtb";
            this.literTxtb.PasswordChar = '\0';
            this.literTxtb.PlaceholderText = "";
            this.literTxtb.SelectedText = "";
            this.literTxtb.ShadowDecoration.Parent = this.literTxtb;
            this.literTxtb.Size = new System.Drawing.Size(181, 38);
            this.literTxtb.TabIndex = 6;
            this.literTxtb.TextChanged += new System.EventHandler(this.literTxtb_TextChanged);
            // 
            // priceTxtb
            // 
            this.priceTxtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceTxtb.DefaultText = "";
            this.priceTxtb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.priceTxtb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.priceTxtb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTxtb.DisabledState.Parent = this.priceTxtb;
            this.priceTxtb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTxtb.Enabled = false;
            this.priceTxtb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTxtb.FocusedState.Parent = this.priceTxtb;
            this.priceTxtb.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTxtb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTxtb.HoverState.Parent = this.priceTxtb;
            this.priceTxtb.Location = new System.Drawing.Point(87, 238);
            this.priceTxtb.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.priceTxtb.Name = "priceTxtb";
            this.priceTxtb.PasswordChar = '\0';
            this.priceTxtb.PlaceholderText = "";
            this.priceTxtb.SelectedText = "";
            this.priceTxtb.ShadowDecoration.Parent = this.priceTxtb;
            this.priceTxtb.Size = new System.Drawing.Size(181, 38);
            this.priceTxtb.TabIndex = 7;
            this.priceTxtb.TextChanged += new System.EventHandler(this.priceTxtb_TextChanged);
            // 
            // totalPriceGrpbx
            // 
            this.totalPriceGrpbx.Controls.Add(this.TotalLbl);
            this.totalPriceGrpbx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.totalPriceGrpbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.totalPriceGrpbx.Location = new System.Drawing.Point(13, 312);
            this.totalPriceGrpbx.Name = "totalPriceGrpbx";
            this.totalPriceGrpbx.ShadowDecoration.Parent = this.totalPriceGrpbx;
            this.totalPriceGrpbx.Size = new System.Drawing.Size(255, 98);
            this.totalPriceGrpbx.TabIndex = 8;
            this.totalPriceGrpbx.Text = "Total";
            // 
            // addBtn
            // 
            this.addBtn.Animated = true;
            this.addBtn.AutoRoundedCorners = true;
            this.addBtn.BorderRadius = 23;
            this.addBtn.CheckedState.Parent = this.addBtn;
            this.addBtn.CustomImages.Parent = this.addBtn;
            this.addBtn.FillColor = System.Drawing.Color.Black;
            this.addBtn.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.HoverState.Parent = this.addBtn;
            this.addBtn.Location = new System.Drawing.Point(13, 436);
            this.addBtn.Name = "addBtn";
            this.addBtn.ShadowDecoration.Parent = this.addBtn;
            this.addBtn.Size = new System.Drawing.Size(255, 48);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "Add";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // paymentListBox
            // 
            this.paymentListBox.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paymentListBox.FormattingEnabled = true;
            this.paymentListBox.ItemHeight = 33;
            this.paymentListBox.Location = new System.Drawing.Point(321, 42);
            this.paymentListBox.Name = "paymentListBox";
            this.paymentListBox.Size = new System.Drawing.Size(272, 367);
            this.paymentListBox.TabIndex = 10;
            // 
            // loadBtn
            // 
            this.loadBtn.Animated = true;
            this.loadBtn.AutoRoundedCorners = true;
            this.loadBtn.BorderRadius = 23;
            this.loadBtn.CheckedState.Parent = this.loadBtn;
            this.loadBtn.CustomImages.Parent = this.loadBtn;
            this.loadBtn.FillColor = System.Drawing.Color.Black;
            this.loadBtn.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
            this.loadBtn.ForeColor = System.Drawing.Color.White;
            this.loadBtn.HoverState.Parent = this.loadBtn;
            this.loadBtn.Location = new System.Drawing.Point(321, 436);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.ShadowDecoration.Parent = this.loadBtn;
            this.loadBtn.Size = new System.Drawing.Size(272, 48);
            this.loadBtn.TabIndex = 11;
            this.loadBtn.Text = "Load";
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // TotalLbl
            // 
            this.TotalLbl.BackColor = System.Drawing.Color.Transparent;
            this.TotalLbl.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalLbl.ForeColor = System.Drawing.Color.Black;
            this.TotalLbl.Location = new System.Drawing.Point(64, 50);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(68, 35);
            this.TotalLbl.TabIndex = 0;
            this.TotalLbl.Text = "[Total]";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 505);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.paymentListBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.totalPriceGrpbx);
            this.Controls.Add(this.priceTxtb);
            this.Controls.Add(this.literTxtb);
            this.Controls.Add(this.literRbtn);
            this.Controls.Add(this.priceRdbtn);
            this.Controls.Add(this.pricePerLiterTxtb);
            this.Controls.Add(this.gasCmbbx);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.gasLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainView";
            this.Text = "MainView";
            this.totalPriceGrpbx.ResumeLayout(false);
            this.totalPriceGrpbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2RadioButton priceRdbtn;
        private Guna.UI2.WinForms.Guna2TextBox pricePerLiterTxtb;
        private Guna.UI2.WinForms.Guna2ComboBox gasCmbbx;
        private Guna.UI2.WinForms.Guna2HtmlLabel priceLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel gasLbl;
        private Guna.UI2.WinForms.Guna2TextBox priceTxtb;
        private Guna.UI2.WinForms.Guna2TextBox literTxtb;
        private Guna.UI2.WinForms.Guna2RadioButton literRbtn;
        private Guna.UI2.WinForms.Guna2Button loadBtn;
        private System.Windows.Forms.ListBox paymentListBox;
        private Guna.UI2.WinForms.Guna2Button addBtn;
        private Guna.UI2.WinForms.Guna2GroupBox totalPriceGrpbx;
        private Guna.UI2.WinForms.Guna2HtmlLabel TotalLbl;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}