<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetting
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgOperation = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgModel = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgSplicer = New System.Windows.Forms.DataGridView()
        Me.cbModel = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLogPath = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtConfPath = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblLastArc = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblLastReset = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMaxHour = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblArcCount = New System.Windows.Forms.Label()
        Me.btnArcReset = New System.Windows.Forms.Button()
        Me.txtArcMax = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgOperation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgModel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgSplicer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(804, 512)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgOperation)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(796, 483)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Operation"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgOperation
        '
        Me.dgOperation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgOperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOperation.Location = New System.Drawing.Point(6, 6)
        Me.dgOperation.Name = "dgOperation"
        Me.dgOperation.RowTemplate.Height = 24
        Me.dgOperation.Size = New System.Drawing.Size(784, 471)
        Me.dgOperation.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgModel)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(796, 483)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Model"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgModel
        '
        Me.dgModel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgModel.Location = New System.Drawing.Point(6, 6)
        Me.dgModel.Name = "dgModel"
        Me.dgModel.RowTemplate.Height = 24
        Me.dgModel.Size = New System.Drawing.Size(787, 471)
        Me.dgModel.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgSplicer)
        Me.TabPage3.Controls.Add(Me.cbModel)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(796, 483)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Splicing"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgSplicer
        '
        Me.dgSplicer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgSplicer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSplicer.Location = New System.Drawing.Point(3, 58)
        Me.dgSplicer.Name = "dgSplicer"
        Me.dgSplicer.RowTemplate.Height = 24
        Me.dgSplicer.Size = New System.Drawing.Size(790, 424)
        Me.dgSplicer.TabIndex = 22
        '
        'cbModel
        '
        Me.cbModel.FormattingEnabled = True
        Me.cbModel.Items.AddRange(New Object() {"CFP", "CFP GLACIER", "AC400"})
        Me.cbModel.Location = New System.Drawing.Point(154, 19)
        Me.cbModel.Name = "cbModel"
        Me.cbModel.Size = New System.Drawing.Size(314, 24)
        Me.cbModel.TabIndex = 21
        Me.cbModel.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(84, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Model :"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox2)
        Me.TabPage4.Controls.Add(Me.GroupBox1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(796, 483)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Path"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtLogPath)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 142)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(746, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Output & Log file"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Full path end with ""\"""
        '
        'txtLogPath
        '
        Me.txtLogPath.Location = New System.Drawing.Point(20, 31)
        Me.txtLogPath.Name = "txtLogPath"
        Me.txtLogPath.Size = New System.Drawing.Size(663, 22)
        Me.txtLogPath.TabIndex = 0
        Me.txtLogPath.Text = "d:\"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtConfPath)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(746, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Configuration files"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Full path end with ""\"""
        '
        'txtConfPath
        '
        Me.txtConfPath.Location = New System.Drawing.Point(20, 31)
        Me.txtConfPath.Name = "txtConfPath"
        Me.txtConfPath.Size = New System.Drawing.Size(663, 22)
        Me.txtConfPath.TabIndex = 0
        Me.txtConfPath.Text = "d:\"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GroupBox3)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(796, 483)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Control"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblLastArc)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.lblLastReset)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtMaxHour)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.lblArcCount)
        Me.GroupBox3.Controls.Add(Me.btnArcReset)
        Me.GroupBox3.Controls.Add(Me.txtArcMax)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(23, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(749, 128)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Arc Control"
        '
        'lblLastArc
        '
        Me.lblLastArc.AutoSize = True
        Me.lblLastArc.ForeColor = System.Drawing.Color.Blue
        Me.lblLastArc.Location = New System.Drawing.Point(354, 100)
        Me.lblLastArc.Name = "lblLastArc"
        Me.lblLastArc.Size = New System.Drawing.Size(24, 17)
        Me.lblLastArc.TabIndex = 12
        Me.lblLastArc.Text = "...."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(280, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 17)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Last Arc :"
        '
        'lblLastReset
        '
        Me.lblLastReset.AutoSize = True
        Me.lblLastReset.ForeColor = System.Drawing.Color.Blue
        Me.lblLastReset.Location = New System.Drawing.Point(100, 100)
        Me.lblLastReset.Name = "lblLastReset"
        Me.lblLastReset.Size = New System.Drawing.Size(24, 17)
        Me.lblLastReset.TabIndex = 10
        Me.lblLastReset.Text = "...."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 17)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Last Reset :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(413, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "hrs"
        '
        'txtMaxHour
        '
        Me.txtMaxHour.Location = New System.Drawing.Point(359, 58)
        Me.txtMaxHour.Name = "txtMaxHour"
        Me.txtMaxHour.Size = New System.Drawing.Size(48, 22)
        Me.txtMaxHour.TabIndex = 7
        Me.txtMaxHour.Text = "51"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(280, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Not Over :"
        '
        'lblArcCount
        '
        Me.lblArcCount.AutoSize = True
        Me.lblArcCount.Location = New System.Drawing.Point(146, 29)
        Me.lblArcCount.Name = "lblArcCount"
        Me.lblArcCount.Size = New System.Drawing.Size(16, 17)
        Me.lblArcCount.TabIndex = 5
        Me.lblArcCount.Text = "1"
        '
        'btnArcReset
        '
        Me.btnArcReset.Location = New System.Drawing.Point(605, 93)
        Me.btnArcReset.Name = "btnArcReset"
        Me.btnArcReset.Size = New System.Drawing.Size(138, 24)
        Me.btnArcReset.TabIndex = 52
        Me.btnArcReset.Text = "Reset Acr count"
        Me.btnArcReset.UseVisualStyleBackColor = True
        '
        'txtArcMax
        '
        Me.txtArcMax.Location = New System.Drawing.Point(103, 60)
        Me.txtArcMax.Name = "txtArcMax"
        Me.txtArcMax.Size = New System.Drawing.Size(52, 22)
        Me.txtArcMax.TabIndex = 50
        Me.txtArcMax.Text = "100"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Max Count :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Current Arc Count :"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(692, 526)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 40)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(566, 526)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 40)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 570)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmSetting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System Configuration"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgOperation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgModel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgSplicer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgOperation As System.Windows.Forms.DataGridView
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents dgModel As System.Windows.Forms.DataGridView
    Friend WithEvents cbModel As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgSplicer As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLogPath As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtConfPath As System.Windows.Forms.TextBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblArcCount As System.Windows.Forms.Label
    Friend WithEvents btnArcReset As System.Windows.Forms.Button
    Friend WithEvents txtArcMax As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMaxHour As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblLastReset As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblLastArc As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
