<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScanBotMain
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.BStartScan = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TEDelay = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.BImportList = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.GCScanList = New DevExpress.XtraGrid.GridControl()
        Me.GVScanList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumnID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnCodeList = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnCheckList = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.TEDelay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.GCScanList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVScanList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.BStartScan)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 479)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(492, 32)
        Me.PanelControl1.TabIndex = 0
        '
        'BStartScan
        '
        Me.BStartScan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BStartScan.Location = New System.Drawing.Point(2, 2)
        Me.BStartScan.Name = "BStartScan"
        Me.BStartScan.Size = New System.Drawing.Size(488, 28)
        Me.BStartScan.TabIndex = 0
        Me.BStartScan.Text = "Start Scan"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.TEDelay)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.TextEdit1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(492, 69)
        Me.PanelControl2.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 38)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Delay (ms)"
        '
        'TEDelay
        '
        Me.TEDelay.Location = New System.Drawing.Point(86, 35)
        Me.TEDelay.Name = "TEDelay"
        Me.TEDelay.Size = New System.Drawing.Size(394, 20)
        Me.TEDelay.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Window Name"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(86, 9)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(394, 20)
        Me.TextEdit1.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.BImportList)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 69)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(492, 38)
        Me.PanelControl3.TabIndex = 2
        '
        'BImportList
        '
        Me.BImportList.Dock = System.Windows.Forms.DockStyle.Right
        Me.BImportList.Location = New System.Drawing.Point(383, 2)
        Me.BImportList.Name = "BImportList"
        Me.BImportList.Size = New System.Drawing.Size(107, 34)
        Me.BImportList.TabIndex = 0
        Me.BImportList.Text = "Import List"
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.GCScanList)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl4.Location = New System.Drawing.Point(0, 107)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(492, 372)
        Me.PanelControl4.TabIndex = 3
        '
        'GCScanList
        '
        Me.GCScanList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCScanList.Location = New System.Drawing.Point(2, 2)
        Me.GCScanList.MainView = Me.GVScanList
        Me.GCScanList.Name = "GCScanList"
        Me.GCScanList.Size = New System.Drawing.Size(488, 368)
        Me.GCScanList.TabIndex = 0
        Me.GCScanList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVScanList})
        '
        'GVScanList
        '
        Me.GVScanList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumnID, Me.GridColumnCodeList, Me.GridColumnCheckList})
        Me.GVScanList.GridControl = Me.GCScanList
        Me.GVScanList.Name = "GVScanList"
        Me.GVScanList.OptionsView.ShowGroupPanel = False
        '
        'GridColumnID
        '
        Me.GridColumnID.Caption = "ID"
        Me.GridColumnID.FieldName = "id"
        Me.GridColumnID.Name = "GridColumnID"
        Me.GridColumnID.Visible = True
        Me.GridColumnID.VisibleIndex = 0
        Me.GridColumnID.Width = 146
        '
        'GridColumnCodeList
        '
        Me.GridColumnCodeList.Caption = "Code List"
        Me.GridColumnCodeList.FieldName = "code"
        Me.GridColumnCodeList.Name = "GridColumnCodeList"
        Me.GridColumnCodeList.Visible = True
        Me.GridColumnCodeList.VisibleIndex = 1
        Me.GridColumnCodeList.Width = 1253
        '
        'GridColumnCheckList
        '
        Me.GridColumnCheckList.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumnCheckList.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumnCheckList.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumnCheckList.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumnCheckList.Caption = "CheckList"
        Me.GridColumnCheckList.FieldName = "is_check"
        Me.GridColumnCheckList.Name = "GridColumnCheckList"
        Me.GridColumnCheckList.Visible = True
        Me.GridColumnCheckList.VisibleIndex = 2
        Me.GridColumnCheckList.Width = 233
        '
        'ScanBotMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 511)
        Me.Controls.Add(Me.PanelControl4)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MinimizeBox = False
        Me.Name = "ScanBotMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scan Bot"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.TEDelay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.GCScanList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVScanList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GCScanList As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVScanList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumnID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnCodeList As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnCheckList As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BStartScan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BImportList As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TEDelay As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
