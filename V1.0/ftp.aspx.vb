Partial Class SamplePage
    Inherits System.Web.UI.Page
    Protected Sub Button1_Click(ByVal sender As Object, _
            ByVal e As System.EventArgs) Handles Button1.Click
		Dim file As System.IO.FileInfo = New System.IO.FileInfo("G:\im\Linux\debian-8.7.1-amd64-netinst.io")
		If file.Exists Then 'set appropriate headers
         Response.Clear()
         Response.AddHeader("Content-Disposition", "attachment; filename=" & file.Name)
         Response.AddHeader("Content-Length", file.Length.ToString())
         Response.ContentType = "application/octet-stream"
         Response.WriteFile(file.FullName)
         Response.End 'if file does not exist'
		Else
         Response.Write("The file '"  & file.Name & "' does not exist.")
		 Response.End 'if file does not exist'
        End If 
    End Sub
End Class

