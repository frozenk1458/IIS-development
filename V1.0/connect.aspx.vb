Partial Class SamplePage
    Inherits System.Web.UI.Page
    Protected Sub Button1_Click(ByVal sender As Object, _
            ByVal e As System.EventArgs) Handles Button1.Click
        Label1.Text = "Clicked at " & DateTime.Now.ToString()
    End Sub
End Class