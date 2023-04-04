<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128566398/13.1.12%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1238)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# How to create ASP.NET Web Forms controls dynamically
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e1238/)**
<!-- run online end -->

This example shows how to create a DevExpress control or a user control dynamically at runtime.

Follow the steps below to create a control in code.

1. To create a new DevExpress control, call the control type constructor. To create a user control, call the [LoadControl](https://learn.microsoft.com/en-us/dotnet/api/system.web.ui.templatecontrol.loadcontrol) method.

1. Specify the control's `ID` property.
1. Attach event handlers.
1. Insert the control into the entire controls hierarchy.
1. Specify the control's properties.
1. Bind the control (for data-aware controls).

```cs
// Creates the DevExpress ASPxButton control
private void CreateControlProcedure(Control container) {
    ASPxButton btn = new ASPxButton();
    btn.ID = "btnRunTime";
    container.Controls.Add(btn);
    btn.Text = string.Format("This ASPxButton is created at RunTime once. ID = {0}", btn.ID);
}

// Creates a user control
private void LoadUserControl(string ucName) {
    Control control = LoadControl(ucName);
    control.ID = ucName.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries)[0];
    control.EnableViewState = false;
    ASPxRoundPanel1.Controls.Clear();
    ASPxRoundPanel1.Controls.Add(control);
}
```

Note once you have modified the entire controls hierarchy (for instance, added the control into the control collection), it is necessary to restore this control with the same settings during the Page_Init stage.


## Files to Review

* [LoadSingleWebControl.aspx.cs](./CS/LoadSingleWebControl.aspx.cs#L18-L24) (VB: [LoadSingleWebControl.aspx.vb](./VB/LoadSingleWebControl.aspx.vb))
* [LoadWebUserControl.aspx.cs](./CS/LoadWebUserControl.aspx.cs#L16-L22) (VB: [LoadWebUserControl.aspx.vb](./VB/LoadWebUserControl.aspx.vb))


## More Examples

* [Grid View for ASP.NET Web Forms - How to create the control at runtime](https://github.com/DevExpress-Examples/asp-net-web-forms-grid-create-at-runtime)

