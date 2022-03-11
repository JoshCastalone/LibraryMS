Imports System.IO
Imports System.Management
Imports System
Imports System.Drawing.Printing
Imports System.Runtime.InteropServices
Imports System.ComponentModel

'This is the code for the frmSysInfo, the form that displays the system information of the current computer.
'This code is adapted from "https://www.mooict.com/visual-basic-tutorial-create-a-system-information-viewer-app/"
'with few modifications.
Public Class frmSysInfo
    Private Sub SaveToFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToFileToolStripMenuItem.Click
        'Opens the SaveFileDialog to save the text (Calls the SaveThis function)
        Try
            SaveThis()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Closes the form and releases resources.
        Close()
        Dispose()
    End Sub

    Private Sub frmSysInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This fetches the CPU information and displays it on the txtCPU text box.
        Try
            Dim MyObj As Object
            Dim cpu As Object
            MyObj = GetObject("WinMgmts:").instancesof("Win32_Processor")
            For Each cpu In MyObj
                txtCPU.Text = cpu.Name.ToString + " " + cpu.CurrentClockSpeed.ToString + " Mhz"
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")
            End
        End Try

        'This fetches the GPU information/s and displays it on the textboxes.
        Try
            Dim objQuery As New ObjectQuery("Select * from Win32_VideoController")
            Dim objSearch As New ManagementObjectSearcher(objQuery)
            For Each memObj As ManagementObject In objSearch.Get
                txtFullName.Text = memObj("Name")
                txtProcessorName.Text = memObj("VideoProcessor")
                txtRefreshRate.Text = Convert.ToInt64(memObj("MaxRefreshRate")).ToString & "Hrz"
                txtRAMGB.Text = Convert.ToInt64(memObj("AdapterRAM") / 1048576 / 1024).ToString & " GB"
                txtDescription.Text = memObj("Description")
                txtDeviceID.Text = memObj("DeviceID")
                txtDriverVer.Text = memObj("DriverVersion")
            Next
        Catch ex As Exception

        End Try

        'This fetches the RAM information and displays it on the textboxes.
        Try
            'Total RAM
            Dim RAMAmount As Double
            RAMAmount = (My.Computer.Info.TotalPhysicalMemory) / 1048576 / 1024
            txtTotalRAM.Text = RAMAmount.ToString("N") & " GB"

            'Remaining RAM
            Dim RAMRemaining As Double
            RAMRemaining = (My.Computer.Info.TotalPhysicalMemory - My.Computer.Info.AvailablePhysicalMemory) / 1048576 / 1024
            txtAvailableRAM.Text = RAMRemaining.ToString("N") & " GB"
        Catch ex As Exception

        End Try

        Try
            'This fetches information about the OS and displays them on the textboxes.
            TextBox1.Text = System.Environment.MachineName
            TextBox2.Text = System.Environment.UserName
            TextBox3.Text = My.Computer.Info.OSFullName
            TextBox4.Text = My.Computer.Info.OSPlatform
            TextBox5.Text = My.Computer.Info.OSVersion
            TextBox6.Text = My.Computer.Info.InstalledUICulture.ToString
        Catch ex As Exception

        End Try

        Try
            PrintPreviewDialog1.Document = PrintDocument1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lstStorage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStorage.SelectedIndexChanged
        'This displays the information of the selected drive to the texboxes.
        Dim sDrive As String = lstStorage.SelectedItem.ToString
        Dim dReady As String = My.Computer.FileSystem.GetDriveInfo(sDrive).IsReady

        If dReady = True Then
            txtStorageName.Text = My.Computer.FileSystem.GetDriveInfo(sDrive).VolumeLabel
            txtFileSys.Text = My.Computer.FileSystem.GetDriveInfo(sDrive).DriveFormat

            'This fetches the total memory of the selected drive.
            Dim tMemory As Double
            tMemory = (My.Computer.FileSystem.GetDriveInfo(sDrive)).TotalSize / 1048576 / 1024
            txtDTSize.Text = tMemory.ToString("N") & " GB"
            'Format(tMemory, "0.00") & " GB"

            'This fetches the available space of the selected drive.
            Dim fMemory As Double
            fMemory = (My.Computer.FileSystem.GetDriveInfo(sDrive)).AvailableFreeSpace / 1048576 / 1024
            txtFSpace.Text = fMemory.ToString("N") & " GB"
            'Format(fMemory, "0.00") & " GB"

            'This shows what is the type of the drive connected.
            Dim DtypeNo As Integer = My.Computer.FileSystem.GetDriveInfo(sDrive).DriveType
            If DtypeNo = 0 Then
                txtDType.Text = "Unknown"
            ElseIf DtypeNo = 1 Then
                txtDType.Text = "CD/DVD"
            ElseIf DtypeNo = 2 Then
                txtDType.Text = "Removable Media"
            ElseIf DtypeNo = 3 Then
                txtDType.Text = "Hard Drive"
            ElseIf DtypeNo = 4 Then
                txtDType.Text = "Network Drive or Cloud Drive"
            ElseIf DtypeNo = 5 Then
                txtDType.Text = "Network Drive or Cloud Drive"
            ElseIf DtypeNo = 6 Then
                txtDType.Text = "Removable Media"
            Else
                MsgBox(sDrive & " - is not ready", MsgBoxStyle.Critical, "Warning")
            End If
        End If
    End Sub

    Private Sub btnShowStorage_Click(sender As Object, e As EventArgs) Handles btnShowStorage.Click
        'This fetches list of available drives and displays it at the listbox.
        Try
            For Each drv As IO.DriveInfo In IO.DriveInfo.GetDrives
                lstStorage.Items.Add(drv)
            Next
        Catch ex As Exception

        End Try
    End Sub
    'This fetches the information about the current computer's CPU, RAM, GPU, and OS, then copies
    'it as text, and then generates the .txt file and prompts the user to select the directory and
    'file name of the generated text file.
    Private Sub SaveThis()
        Try
            Dim file As IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter("spec.txt", False)
            file.WriteLine("Computer specs")

            'CPU Information
            file.WriteLine("==============================================================")
            file.WriteLine("=======================CPU Information========================")
            file.WriteLine("==============================================================")
            Dim MyObj As Object
            Dim CPU As Object
            MyObj = GetObject("WinMgmts:").instancesof("Win32_Processor")
            For Each CPU In MyObj
                file.WriteLine(CPU.name.ToString + " " + CPU.CurrentClockSpeed.ToString + " Mhz")
            Next

            file.WriteLine("==============================================================")
            file.WriteLine("=======================RAM Information========================")
            file.WriteLine("==============================================================")
            Dim rAmount As Double
            rAmount = (My.Computer.Info.TotalPhysicalMemory) / 1048576 / 1024
            file.WriteLine("Total RAM in your system: " + rAmount.ToString("N") & " GB")
            Dim RAMRemaining As Double
            RAMRemaining = (My.Computer.Info.TotalPhysicalMemory - My.Computer.Info.AvailablePhysicalMemory) / 1048576 / 1024
            file.WriteLine("Available RAM in your system: " + RAMRemaining.ToString("N") & " GB")
            file.WriteLine("==============================================================")

            file.WriteLine("========================GPU Information=======================")
            file.WriteLine("==============================================================")
            Dim oQuery As New ObjectQuery("Select * from Win32_VideoController")
            Dim oSearch As New ManagementObjectSearcher(oQuery)
            For Each mObj As ManagementObject In oSearch.Get
                file.WriteLine("GPU Name: " & mObj("Name"))
                file.WriteLine("Processor name: " & mObj("VideoProcessor"))
                file.WriteLine("Refresh rate: " & Convert.ToInt64(mObj("MaxRefreshRate")).ToString & "Hrz")
                file.WriteLine("Amount of RAM(GB): " & Convert.ToInt64(mObj("AdapterRAM") / 1048576 / 1024).ToString & " GB")
                file.WriteLine("Description: " & mObj("Description"))
                file.WriteLine("Device ID: " & mObj("DeviceID"))
                file.WriteLine("Driver Version: " & mObj("DriverVersion"))
                file.WriteLine("==============================================================")
            Next
            file.WriteLine("===================Operating System Information===============")
            file.WriteLine("==============================================================")
            file.WriteLine("Computer Name: " & Environment.MachineName)
            file.WriteLine("Current User: " & Environment.UserName)
            file.WriteLine("Operating System: " & My.Computer.Info.OSFullName)
            file.WriteLine("Platform: " & My.Computer.Info.OSPlatform)
            file.WriteLine("Version: " & My.Computer.Info.OSVersion)
            file.WriteLine("Operating System: " & My.Computer.Info.InstalledUICulture.ToString)
            file.WriteLine("==============================================================")
            file.WriteLine("Thank you for viewing System Information Viewer.")

            file.Close()
            With SaveFileDialog1
                .AddExtension = True
                .OverwritePrompt = True
                .DefaultExt = "txt"
                .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                .FileName = "SystemInfo"
                .Filter = "Text files (*.txt)|*.txt|All files|*.*"
                .FilterIndex = 1
                .Title = "SystemInfo - Save file"
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    My.Computer.FileSystem.CopyFile("spec.txt", .FileName, True)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Exception")
        End Try
    End Sub

    'This shows the printer dialog, and when the user clicks the OK button, it will print the text file
    'using the printer settings set by the user.
    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        'SaveThis()
        For Each s As String In IO.File.ReadAllLines("spec.txt")
            TextBox7.AppendText(s + vbNewLine)
        Next
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If

    End Sub

    'This sets the format for how the texts retrieved from the hidden text box should appear when printed
    'from the Print dialog.
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font1 As New Font("Arial", 10, FontStyle.Regular)
        e.Graphics.DrawString(TextBox7.Text, font1, Brushes.Black, 100, 100)
    End Sub

    Private Sub frmSysInfo_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class