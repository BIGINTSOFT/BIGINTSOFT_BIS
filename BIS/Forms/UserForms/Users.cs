using BIS.BLL.DTO;
using BIS.BLL.General;
using BIS.Data.Contexts;
using BIS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIS.UI
{
    public partial class Users : Form
	{
		private readonly UserService _userService;
		public Users(UserService userService)
		{
			InitializeComponent();
			_userService = userService;
		}

		private void btnPictureSelect_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
			openFileDialog.Title = "Bir Resim Seçin";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				pictureEdit1.Image = Image.FromFile(openFileDialog.FileName);
			}
		}
		private byte[] ImageToByteArray(Image image)
		{
			using (MemoryStream ms = new MemoryStream())
			{
				image.Save(ms, image.RawFormat);
				return ms.ToArray();
			}
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			byte[]? imageBytes = null;

			if (pictureEdit1.Image != null)
			{
				imageBytes = ImageToByteArray(pictureEdit1.Image);
			}

			var user = new User
			{
				UserName = txtUserName.Text,
				UserSurname = txtUserSurname.Text,
				Password = txtPassword.Text,
				Phone = txtPhone.Text,
				NationalId = txtNationalId.Text,
				EmployeeStatusId = (int)comboBoxEmployeeStatus.SelectedValue,
				Email = txtEmail.Text,
				ProfilePicture = imageBytes,
				CreatedDate = DateTime.Now,
				IsActive = (bool)comboBoxIsActive.SelectedValue
			};

			var (isSuccess, errorMessage) = _userService.CreateUser(user);

			if (isSuccess)
			{
				DevExpress.XtraEditors.XtraMessageBox.Show("Kullanıcı başarıyla kaydedildi.", "Başarılı",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadUsersToGrid();
			}
			else
			{
				DevExpress.XtraEditors.XtraMessageBox.Show($"Kullanıcı kaydedilemedi: {errorMessage}", "Hata",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Users_Load(object sender, EventArgs e)
		{
			toolTipController1.GetActiveObjectInfo += ToolTipController_GetActiveObjectInfo;

			var employeeStatuses = _userService.GetEmployeeStatuses();

			comboBoxEmployeeStatus.DataSource = employeeStatuses;
			comboBoxEmployeeStatus.DisplayMember = "Description";
			comboBoxEmployeeStatus.ValueMember = "Id";

			var statusOptions = new List<KeyValuePair<string, bool>>
			{
				new KeyValuePair<string, bool>("Aktif", true),
				new KeyValuePair<string, bool>("Pasif", false)
			};

			comboBoxIsActive.DataSource = statusOptions;
			comboBoxIsActive.DisplayMember = "Key";
			comboBoxIsActive.ValueMember = "Value";

			LoadUsersToGrid();
		}
		private void LoadUsersToGrid()
		{

			var users = _userService.GetUsers();

			gridControl1.DataSource = users;
			gridView1.Columns["EmployeeStatusId"].Visible = false;
			gridView1.BestFitColumns();
			gridView1.Columns["ProfilePicture"].Width = 20;
		}

		private void ToolTipController_GetActiveObjectInfo(object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e)
		{
			// GridControl içinde mi geziliyor?
			if (e.Info == null && e.SelectedControl == gridControl1)
			{
				// Hücreyi belirleyin
				DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hitInfo = gridView1.CalcHitInfo(e.ControlMousePosition);

				// Eğer hücre ProfilePicture sütununa aitse
				if (hitInfo.InRowCell && hitInfo.Column.FieldName == "ProfilePicture")
				{
					// Hücredeki resmi alalım
					var imageBytes = gridView1.GetRowCellValue(hitInfo.RowHandle, "ProfilePicture") as byte[];
					if (imageBytes != null)
					{
						// Byte dizisinden resmi oluştur
						Image image;
						using (MemoryStream ms = new MemoryStream(imageBytes))
						{
							image = Image.FromStream(ms);
						}

						// Resmi yeniden boyutlandır (örneğin 100x100 piksel)
						Image resizedImage = ResizeImage(image, new Size(300, 300));

						// ToolTip'te daha büyük boyutlu resim göster
						e.Info = new DevExpress.Utils.ToolTipControlInfo();
						e.Info.Object = hitInfo.HitTest.ToString() + hitInfo.RowHandle.ToString();
						e.Info.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;

						// Resim için ToolTip oluştur
						DevExpress.Utils.SuperToolTip superToolTip = new DevExpress.Utils.SuperToolTip();
						DevExpress.Utils.ToolTipTitleItem titleItem = new DevExpress.Utils.ToolTipTitleItem();
						titleItem.Text = "Büyütülmüş Resim";
						DevExpress.Utils.ToolTipItem toolTipItem = new DevExpress.Utils.ToolTipItem();
						toolTipItem.Image = resizedImage;  // Yeniden boyutlandırılmış resmi göster

						// ToolTip'e resim ekleyin
						superToolTip.Items.Add(titleItem);
						superToolTip.Items.Add(toolTipItem);
						e.Info.SuperTip = superToolTip;
					}
				}
			}
		}


		private Image ResizeImage(Image imgToResize, Size size)
		{
			return new Bitmap(imgToResize, size);
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			// Seçili satırdaki veriyi al
			var selectedUser = gridView1.GetFocusedRow() as UserDTO;
			if (selectedUser != null)
			{
				// TextBox'ları doldur
				txtUserName.Text = selectedUser.UserName;
				txtUserSurname.Text = selectedUser.UserSurname;
				txtEmail.Text = selectedUser.Email;
				txtPhone.Text = selectedUser.Phone;
				txtNationalId.Text = selectedUser.NationalId;

				// Combobox'ları doldur
				comboBoxEmployeeStatus.SelectedValue = selectedUser.EmployeeStatusId;  // EmployeeStatusId'yi combobox'a ata
				comboBoxIsActive.SelectedValue = selectedUser.IsActive ?? false;

				if (selectedUser.ProfilePicture != null && selectedUser.ProfilePicture.Length > 0)
				{
					using (MemoryStream ms = new MemoryStream(selectedUser.ProfilePicture))
					{
						pictureEdit1.Image = Image.FromStream(ms);
					}
				}
				else
				{
					pictureEdit1.Image = null;
				}
			}
		}
	}
}
