Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Imports System.Threading

Public Class ScanBotMain
    '<DllImport("User32.dll")> Private Shared Function SetForegroundWindow(ByVal point As IntPtr) As Integer
    'End Function

    'Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
    '    Dim proc_name As String = TextEdit1.Text
    '    Dim p As Process = Process.GetProcessesByName(proc_name).FirstOrDefault()
    '    If Not IsNothing(p) Then
    '        Dim h As IntPtr = p.MainWindowHandle
    '        SetForegroundWindow(h)
    '        SendKeys.SendWait(TextEdit2.Text)
    '        Console.WriteLine("ok")
    '    End If
    'End Sub
    Private Declare Sub keybd_event Lib "user32" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As UInteger, ByVal dwExtraInfo As UInteger)
    Const KEYEVENTF_KEYUP = &H2
    Private Declare Function ShowWindow Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal nCmdShow As SHOW_WINDOW) As Boolean
    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal zero As IntPtr, ByVal lpWindowName As String) As IntPtr
    Private Declare Function SetForegroundWindow Lib "user32" (ByVal hwnd As IntPtr) As Integer
    Private Declare Function GetForegroundWindow Lib "user32" () As Integer

    Private Enum SHOW_WINDOW As Integer
        SW_HIDE = 0
        SW_SHOWNORMAL = 1
        SW_NORMAL = 1
        SW_SHOWMINIMIZED = 2
        SW_SHOWMAXIMIZED = 3
        SW_MAXIMIZE = 3
        SW_SHOWNOACTIVATE = 4
        SW_SHOW = 5
        SW_MINIMIZE = 6
        SW_SHOWMINNOACTIVE = 7
        SW_SHOWNA = 8
        SW_RESTORE = 9
        SW_SHOWDEFAULT = 10
        SW_FORCEMINIMIZE = 11
        SW_MAX = 11
    End Enum


    <DllImport("user32.dll", SetLastError:=True)>
    Friend Shared Function SendInput(ByVal cInputs As Int32, ByRef pInputs As INPUT, ByVal cbSize As Int32) As Int32
    End Function

    <StructLayout(LayoutKind.Explicit, Pack:=1, Size:=28)>
    Friend Structure INPUT
        <FieldOffset(0)> Public dwType As InputType
        <FieldOffset(4)> Public ki As KEYBDINPUT
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Friend Structure KEYBDINPUT
        Public wVk As Int16
        Public wScan As Int16
        Public dwFlags As KEYEVENTF
        Public time As Int32
        Public dwExtraInfo As IntPtr
    End Structure

    Friend Enum InputType As Integer
        Keyboard = 1
    End Enum

    <Flags()>
    Friend Enum KEYEVENTF As Integer
        EXTENDEDKEY = 1
        KEYUP = 2
        [UNICODE] = 4
        SCANCODE = 8
    End Enum

    Private Sub SendTheKeys(ByVal flags As KEYEVENTF, ByVal key As Keys)
        Dim input As New INPUT
        Dim ki As New KEYBDINPUT
        input.dwType = InputType.Keyboard
        input.ki = ki
        input.ki.wVk = Convert.ToInt16(key)
        input.ki.wScan = 0
        input.ki.time = 0
        input.ki.dwFlags = flags
        input.ki.dwExtraInfo = IntPtr.Zero
        Dim cbSize As Integer = Marshal.SizeOf(GetType(INPUT))
        Dim result As Integer = SendInput(1, input, cbSize)
        If result = 0 Then Debug.WriteLine(Marshal.GetLastWin32Error)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles BStartScan.Click
        Dim window_name As String = TextEdit1.Text
        Dim targetwindow As IntPtr = FindWindow(Nothing, window_name)
        SetForegroundWindow(targetwindow)
        For i As Integer = 0 To GVScanList.RowCount - 1
            SendKeys.Send(GVScanList.GetRowCellValue(i, "code").ToString)
            SendKeys.Send("{enter}")
            'delay
            Thread.Sleep(TEDelay.EditValue)
            'check if error
            Dim windowhandle As IntPtr = FindWindow(Nothing, "Stop")
            If windowhandle = Nothing Then
                GVScanList.SetRowCellValue(i, "is_check", "yes")
            Else
                Exit For
            End If
        Next
        GVScanList.RefreshData()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles BImportList.Click
        'import excel
        load_excel_data()

        '
        'Trial
        'Dim dt As New DataTable
        'dt.Columns.Add("ID")
        'dt.Columns.Add("code")
        'dt.Columns.Add("is_check")
        'dt.Columns(0).AutoIncrement = True
        '

        'For i As Integer = 0 To 10
        '    Dim R1 As DataRow = dt.NewRow
        '    R1("code") = "888820092991"
        '    R1("is_check") = "no"
        '    dt.Rows.Add(R1)
        'Next
        ''
        'Dim R3 As DataRow = dt.NewRow
        'R3("ID") = "3"
        'R3("code") = "888820092992"
        'R3("is_check") = "no"
        'dt.Rows.Add(R3)

        'For i As Integer = 0 To 10
        '    Dim R1 As DataRow = dt.NewRow
        '    R1("code") = "888820092991"
        '    R1("is_check") = "no"
        '    dt.Rows.Add(R1)
        'Next
        'GCScanList.DataSource = dt
        'GCScanList.Refresh()
        'GVScanList.RefreshData()
        ''

        '

    End Sub

    Private Sub ScanBotMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TEDelay.EditValue = 100
    End Sub

    Sub load_excel_data()
        Dim oledbconn As New OleDbConnection
        Dim strConn As String
        Dim data_temp As New DataTable

        Dim path As String = My.Application.Info.DirectoryPath.ToString & "\code_import.xlsx"
        Console.WriteLine(path)

        strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & path & "';Extended Properties=""Excel 12.0 XML; IMEX=1;HDR=NO;TypeGuessRows=0;ImportMixedTypes=Text;"""
        oledbconn.ConnectionString = strConn
        Dim MyCommand As OleDbDataAdapter
        Try
            MyCommand = New OleDbDataAdapter("select [F1] as id,[F2] as code,'no' as is_check from [code$] WHERE NOT [F2] IS NULL", oledbconn)
            MyCommand.Fill(data_temp)
            MyCommand.Dispose()
        Catch ex As Exception
            MyCommand = New OleDbDataAdapter("select [F1] as id,[F2] as code,'no' as is_check from [code$] WHERE NOT [F2] IS NULL", oledbconn)
            MyCommand.Fill(data_temp)
            MyCommand.Dispose()
        End Try

        GCScanList.DataSource = data_temp
    End Sub
End Class