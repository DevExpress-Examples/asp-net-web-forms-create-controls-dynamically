using System;
using System.Web.UI;
using DevExpress.Web.ASPxEditors;

public partial class LoadSingleWebControl: System.Web.UI.Page {
    protected void Page_Init(object sender, EventArgs e) {
        if (Session["WasButtonCreated"] != null) {
            CreateControlProcedure(pnlContainer);
        }
    }

    protected void btnCreateControl_Click(object sender, EventArgs e) {
        if (Session["WasButtonCreated"] == null) {
            CreateControlProcedure(pnlContainer);
            Session["WasButtonCreated"] = true;
        }
    }
    private void CreateControlProcedure(Control container) {
        ASPxButton btn = new ASPxButton();
        btn.ID = "btnRunTime";
        container.Controls.Add(btn);

        btn.Text = string.Format("This ASPxButton is created at RunTime once. ID = {0}", btn.ID);
    }
}