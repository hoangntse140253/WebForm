using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace App_Code
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        UserInfoData data = new UserInfoData();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

                LoadData();
            }
        }
        public void LoadData()
        {
            gvUserInfoList.DataSource = data.GetUserList();
            gvUserInfoList.DataBind();
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            dynamic u = new UserInfo()
            {
                UserName = txtUsername.Text,
                Password = txtPassword.Text,
                Birthdate = DateTime.Parse(txtBirth.Text),
                Address = txtAddress.Text,
                Email = txtEmail.Text
            };
            data.InsertUserInfo(u);
            LoadData();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            dynamic u = new UserInfo()
            {
                UserName = txtUsername.Text,
                Password = txtPassword.Text,
                Birthdate = DateTime.Parse(txtBirth.Text),
                Address = txtAddress.Text,
                Email = txtEmail.Text
            };
            data.UpdateUserInfo(u);
            LoadData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            dynamic u = new UserInfo()
            {
                UserName = txtUsername.Text
            };
            data.DeleteUserInfo(u);
            LoadData();

        }

       

        protected void gvUserInfoList_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow selectedRow = gvUserInfoList.Rows[e.NewSelectedIndex];
            txtUsername.Text = selectedRow.Cells[1].Text;
            txtPassword.Text = selectedRow.Cells[2].Text;
            txtBirth.Text = selectedRow.Cells[3].Text;
            txtAddress.Text = selectedRow.Cells[4].Text;
            txtEmail.Text = selectedRow.Cells[5].Text;
        }
    }
}