using System;
using System.Web.UI;

public partial class LoadWebUserControl: System.Web.UI.Page {
    protected void Page_Init(object sender, EventArgs e) {
        if (Session["Name"] != null)
            LoadUserControl(Session["Name"].ToString());
    }

    protected void ASPxComboBox1_SelectedIndexChanged(object sender, EventArgs e) {
        string ucName = ASPxComboBox1.SelectedItem.Text;
        LoadUserControl(ucName);
        Session["Name"] = ucName;
    }

    private void LoadUserControl(string ucName) {
        Control control = LoadControl(ucName);
        control.ID = ucName.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries)[0];
		control.EnableViewState = false;
        ASPxRoundPanel1.Controls.Clear();
        ASPxRoundPanel1.Controls.Add(control);
    }
}
