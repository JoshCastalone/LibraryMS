Public NotInheritable Class SplashScreen1

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ''Set up the dialog text at runtime according to the application's assembly information.  

        ''TODO: Customize the application's assembly information in the "Application" pane of the project 
        ''  properties dialog (under the "Project" menu).

        ''Application title
        'If My.Application.Info.Title <> "" Then
        '    ApplicationTitle.Text = My.Application.Info.Title
        'Else
        '    'If the application title is missing, use the application name, without the extension
        '    ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        'End If

        ''Format the version information using the text set into the Version control at design time as the
        ''  formatting string.  This allows for effective localization if desired.
        ''  Build and revision information could be included by using the following code and changing the 
        ''  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
        ''  String.Format() in Help for more information.
        ''
        ''    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        'Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        ''Copyright info
        'Copyright.Text = My.Application.Info.Copyright
    End Sub

    Private Sub MainLayoutPanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'This loads the progress bar, and shows the log-in form when the progress bar
        ProgressBar1.Visible = True
        ProgressBar1.Value = ProgressBar1.Value + 2
        If (ProgressBar1.Value = 10) Then
            Label3.Text = "Reading modules.."
        ElseIf (ProgressBar1.Value = 20) Then
            Label3.Text = "Turning on modules."
        ElseIf (ProgressBar1.Value = 40) Then
            Label3.Text = "Starting modules.."
        ElseIf (ProgressBar1.Value = 60) Then
            Label3.Text = "Loading modules.."
        ElseIf (ProgressBar1.Value = 80) Then
            Label3.Text = "Done Loading modules.."
        ElseIf (ProgressBar1.Value = 100) Then
            LoginForm1.Show()
            Timer1.Enabled = False
            Me.Hide()
        End If
    End Sub
End Class
