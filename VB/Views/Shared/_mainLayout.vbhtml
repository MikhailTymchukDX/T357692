@Code 
    Layout = "~/Views/Shared/_rootLayout.vbhtml"
End Code

@Html.DevExpress().Splitter( _
    Sub(settings)
            settings.Name = "ContentSplitter"
            settings.Width = System.Web.UI.WebControls.Unit.Percentage(100)
            settings.Height = System.Web.UI.WebControls.Unit.Percentage(100)
            settings.Styles.Pane.Paddings.Padding = System.Web.UI.WebControls.Unit.Pixel(0)
            settings.Styles.Pane.Border.BorderWidth = System.Web.UI.WebControls.Unit.Pixel(0)
        
            settings.Panes.Add(Sub(subpane)
                                       subpane.Name = "ContentLeft"
                                       subpane.PaneStyle.CssClass = "leftPane"
                                       subpane.ShowCollapseBackwardButton = DefaultBoolean.False
                                       subpane.Size = System.Web.UI.WebControls.Unit.Pixel(200)
                                       subpane.MinSize = System.Web.UI.WebControls.Unit.Pixel(150)
                                       subpane.PaneStyle.Paddings.Padding = System.Web.UI.WebControls.Unit.Pixel(1)
                                       subpane.SetContent(Sub()
                                                                  Html.RenderPartial("ContentLeftPartialView")
                                                          End Sub)
                               End Sub)

            settings.Panes.Add(Sub(subpane)
                                       subpane.Name = "ContentCenter"
                                       subpane.PaneStyle.CssClass = "contentPane"
                                       subpane.ScrollBars = System.Web.UI.WebControls.ScrollBars.Auto
                                       subpane.Separator.Visible = DefaultBoolean.True
                                       subpane.Separator.SeparatorStyle.Border.BorderWidth = System.Web.UI.WebControls.Unit.Pixel(1)
                                       subpane.Separator.SeparatorStyle.BorderTop.BorderWidth = System.Web.UI.WebControls.Unit.Pixel(0)
                                       subpane.SetContent(RenderBody().ToHtmlString())
                               End Sub)

    End Sub).GetHtml()