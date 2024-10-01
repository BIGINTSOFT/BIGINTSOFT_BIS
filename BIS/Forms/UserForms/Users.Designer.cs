namespace BIS.UI
{
	partial class Users
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
            components = new System.ComponentModel.Container();
            label1 = new System.Windows.Forms.Label();
            txtUserName = new System.Windows.Forms.TextBox();
            txtUserSurname = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            txtPhone = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtCardId = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            txtNationalId = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            btnKaydet = new System.Windows.Forms.Button();
            btnPictureSelect = new System.Windows.Forms.Button();
            comboBoxEmployeeStatus = new System.Windows.Forms.ComboBox();
            comboBoxIsActive = new System.Windows.Forms.ComboBox();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            toolTipController1 = new DevExpress.Utils.ToolTipController(components);
            ((System.ComponentModel.ISupportInitialize)ribbonControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // ribbonControl
            // 
            ribbonControl.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(26);
            ribbonControl.ExpandCollapseItem.Id = 0;
            ribbonControl.OptionsMenuMinWidth = 283;
            ribbonControl.OptionsPageCategories.ShowCaptions = false;
            ribbonControl.Size = new System.Drawing.Size(1089, 135);
            ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(151, 147);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(62, 13);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            // 
            // txtUserName
            // 
            txtUserName.Location = new System.Drawing.Point(239, 139);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new System.Drawing.Size(104, 21);
            txtUserName.TabIndex = 1;
            // 
            // txtUserSurname
            // 
            txtUserSurname.Location = new System.Drawing.Point(239, 164);
            txtUserSurname.Name = "txtUserSurname";
            txtUserSurname.Size = new System.Drawing.Size(104, 21);
            txtUserSurname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(151, 172);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 13);
            label2.TabIndex = 2;
            label2.Text = "Kullanıcı Soyadı";
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(239, 189);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(104, 21);
            txtPassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(150, 191);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(29, 13);
            label3.TabIndex = 4;
            label3.Text = "Şifre";
            // 
            // pictureEdit1
            // 
            pictureEdit1.Location = new System.Drawing.Point(12, 141);
            pictureEdit1.Name = "pictureEdit1";
            pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit1.Size = new System.Drawing.Size(133, 93);
            pictureEdit1.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.Location = new System.Drawing.Point(239, 214);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(104, 21);
            txtPhone.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(150, 217);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(43, 13);
            label4.TabIndex = 7;
            label4.Text = "Telefon";
            // 
            // txtCardId
            // 
            txtCardId.Location = new System.Drawing.Point(239, 239);
            txtCardId.Name = "txtCardId";
            txtCardId.Size = new System.Drawing.Size(104, 21);
            txtCardId.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(150, 242);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(74, 13);
            label5.TabIndex = 9;
            label5.Text = "Kart Numarası";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(150, 267);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(70, 13);
            label6.TabIndex = 11;
            label6.Text = "Çalışan Statü";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(150, 292);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(55, 13);
            label7.TabIndex = 13;
            label7.Text = "Aktif Pasif";
            // 
            // txtNationalId
            // 
            txtNationalId.Location = new System.Drawing.Point(239, 314);
            txtNationalId.Name = "txtNationalId";
            txtNationalId.Size = new System.Drawing.Size(104, 21);
            txtNationalId.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(150, 317);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(79, 13);
            label8.TabIndex = 15;
            label8.Text = "Kimlik Numarası";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(239, 340);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(104, 21);
            txtEmail.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(150, 342);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(68, 13);
            label9.TabIndex = 17;
            label9.Text = "E-Mail Adresi";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new System.Drawing.Point(153, 373);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new System.Drawing.Size(171, 29);
            btnKaydet.TabIndex = 19;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnPictureSelect
            // 
            btnPictureSelect.Location = new System.Drawing.Point(12, 243);
            btnPictureSelect.Name = "btnPictureSelect";
            btnPictureSelect.Size = new System.Drawing.Size(133, 20);
            btnPictureSelect.TabIndex = 20;
            btnPictureSelect.Text = "Resim Seç";
            btnPictureSelect.UseVisualStyleBackColor = true;
            btnPictureSelect.Click += btnPictureSelect_Click;
            // 
            // comboBoxEmployeeStatus
            // 
            comboBoxEmployeeStatus.FormattingEnabled = true;
            comboBoxEmployeeStatus.Location = new System.Drawing.Point(239, 264);
            comboBoxEmployeeStatus.Name = "comboBoxEmployeeStatus";
            comboBoxEmployeeStatus.Size = new System.Drawing.Size(104, 21);
            comboBoxEmployeeStatus.TabIndex = 21;
            // 
            // comboBoxIsActive
            // 
            comboBoxIsActive.FormattingEnabled = true;
            comboBoxIsActive.Location = new System.Drawing.Point(239, 292);
            comboBoxIsActive.Name = "comboBoxIsActive";
            comboBoxIsActive.Size = new System.Drawing.Size(104, 21);
            comboBoxIsActive.TabIndex = 22;
            // 
            // gridControl1
            // 
            gridControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gridControl1.Location = new System.Drawing.Point(10, 440);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(1068, 287);
            gridControl1.TabIndex = 23;
            gridControl1.ToolTipController = toolTipController1;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.DetailHeight = 303;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsEditForm.PopupEditFormWidth = 686;
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
            // 
            // Users
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(1089, 738);
            Controls.Add(gridControl1);
            Controls.Add(comboBoxIsActive);
            Controls.Add(comboBoxEmployeeStatus);
            Controls.Add(btnPictureSelect);
            Controls.Add(btnKaydet);
            Controls.Add(txtEmail);
            Controls.Add(label9);
            Controls.Add(txtNationalId);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtCardId);
            Controls.Add(label5);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(pictureEdit1);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUserSurname);
            Controls.Add(label2);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            IconOptions.ShowIcon = false;
            Name = "Users";
            Text = "Users";
            Load += Users_Load;
            Controls.SetChildIndex(ribbonControl, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtUserName, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtUserSurname, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtPassword, 0);
            Controls.SetChildIndex(pictureEdit1, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(txtPhone, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(txtCardId, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(txtNationalId, 0);
            Controls.SetChildIndex(label9, 0);
            Controls.SetChildIndex(txtEmail, 0);
            Controls.SetChildIndex(btnKaydet, 0);
            Controls.SetChildIndex(btnPictureSelect, 0);
            Controls.SetChildIndex(comboBoxEmployeeStatus, 0);
            Controls.SetChildIndex(comboBoxIsActive, 0);
            Controls.SetChildIndex(gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)ribbonControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUserName;
		private DevExpress.XtraEditors.TextEdit textEdit1;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private System.Windows.Forms.TextBox txtUserSurname;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label3;
		private DevExpress.XtraEditors.PictureEdit pictureEdit1;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCardId;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtNationalId;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnKaydet;
		private System.Windows.Forms.Button btnPictureSelect;
		private System.Windows.Forms.ComboBox comboBoxEmployeeStatus;
		private System.Windows.Forms.ComboBox comboBoxIsActive;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.Utils.ToolTipController toolTipController1;
		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
		private DevExpress.XtraBars.BarButtonItem barButtonItem1;
	}
}