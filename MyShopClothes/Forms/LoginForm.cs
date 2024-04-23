using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShopClothes.App.Forms
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private bool CheckLogin(string user, string pass)
		{
			if(user == "admin" && pass == "123456")
				return true;
			return false;
		}

		private void ShowMess (bool result)
		{
			MessageBox.Show("Known", "Info");
		}
	}
}
