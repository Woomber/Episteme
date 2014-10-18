Public NotInheritable Class Splash

    Private Sub Splash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Copyright.Text = My.Application.Info.Copyright

        Description.Text = My.Application.Info.Description

        Company.Text = My.Application.Info.CompanyName

    End Sub

    Private Sub MainLayoutPanel_Paint(sender As Object, e As PaintEventArgs) Handles MainLayoutPanel.Paint

    End Sub
End Class
