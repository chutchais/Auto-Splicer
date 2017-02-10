<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssSplicer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssMessage = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbSplicerName = New System.Windows.Forms.Label()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLossValue = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbOperation = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbModel = New System.Windows.Forms.ComboBox()
        Me.lblCurrentStatus = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.txtSN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.txtEn = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSaveData = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtCleaver38 = New System.Windows.Forms.TextBox()
        Me.txtCleaver32 = New System.Windows.Forms.TextBox()
        Me.txtSplicerName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.btnSetting = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblArcSince = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblArcCount = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblMaxHour = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblMaxArc = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(333, 745)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 34)
        Me.Button1.TabIndex = 2
        Me.Button1.TabStop = False
        Me.Button1.Text = "SET"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(172, 745)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 34)
        Me.Button2.TabIndex = 3
        Me.Button2.TabStop = False
        Me.Button2.Text = "MENU"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(493, 745)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(155, 34)
        Me.Button3.TabIndex = 4
        Me.Button3.TabStop = False
        Me.Button3.Text = "ESC"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssSplicer, Me.tssMessage})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 785)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1180, 25)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssSplicer
        '
        Me.tssSplicer.Name = "tssSplicer"
        Me.tssSplicer.Size = New System.Drawing.Size(98, 20)
        Me.tssSplicer.Text = "Splicer Status"
        '
        'tssMessage
        '
        Me.tssMessage.Name = "tssMessage"
        Me.tssMessage.Size = New System.Drawing.Size(18, 20)
        Me.tssMessage.Text = "..."
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(298, 191)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(872, 548)
        Me.DataGridView1.TabIndex = 8
        Me.DataGridView1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 29)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Name :"
        '
        'lbSplicerName
        '
        Me.lbSplicerName.AutoSize = True
        Me.lbSplicerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSplicerName.Location = New System.Drawing.Point(108, 153)
        Me.lbSplicerName.Name = "lbSplicerName"
        Me.lbSplicerName.Size = New System.Drawing.Size(31, 29)
        Me.lbSplicerName.TabIndex = 8
        Me.lbSplicerName.Text = "..."
        '
        'btnSet
        '
        Me.btnSet.Location = New System.Drawing.Point(611, 144)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(155, 38)
        Me.btnSet.TabIndex = 9
        Me.btnSet.Text = "SET"
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(772, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 29)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Loss :"
        '
        'txtLossValue
        '
        Me.txtLossValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLossValue.Location = New System.Drawing.Point(854, 144)
        Me.txtLossValue.Name = "txtLossValue"
        Me.txtLossValue.Size = New System.Drawing.Size(201, 38)
        Me.txtLossValue.TabIndex = 10
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(1061, 144)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(109, 38)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(1015, 745)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(155, 34)
        Me.btnUpload.TabIndex = 11
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(854, 745)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(155, 34)
        Me.btnClear.TabIndex = 10
        Me.btnClear.TabStop = False
        Me.btnClear.Text = "Clear Data"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbOperation)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbModel)
        Me.GroupBox1.Controls.Add(Me.lblCurrentStatus)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnNew)
        Me.GroupBox1.Controls.Add(Me.btnStart)
        Me.GroupBox1.Controls.Add(Me.txtSN)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(682, 129)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Serial Number"
        '
        'cbOperation
        '
        Me.cbOperation.FormattingEnabled = True
        Me.cbOperation.Items.AddRange(New Object() {"CFP", "CFP GLACIER", "AC400"})
        Me.cbOperation.Location = New System.Drawing.Point(425, 18)
        Me.cbOperation.Name = "cbOperation"
        Me.cbOperation.Size = New System.Drawing.Size(224, 24)
        Me.cbOperation.TabIndex = 21
        Me.cbOperation.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(327, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 20)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Operation :"
        '
        'cbModel
        '
        Me.cbModel.FormattingEnabled = True
        Me.cbModel.Items.AddRange(New Object() {"CFP", "CFP GLACIER", "AC400"})
        Me.cbModel.Location = New System.Drawing.Point(81, 18)
        Me.cbModel.Name = "cbModel"
        Me.cbModel.Size = New System.Drawing.Size(240, 24)
        Me.cbModel.TabIndex = 19
        Me.cbModel.TabStop = False
        '
        'lblCurrentStatus
        '
        Me.lblCurrentStatus.AutoSize = True
        Me.lblCurrentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentStatus.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblCurrentStatus.Location = New System.Drawing.Point(79, 93)
        Me.lblCurrentStatus.Name = "lblCurrentStatus"
        Me.lblCurrentStatus.Size = New System.Drawing.Size(27, 25)
        Me.lblCurrentStatus.TabIndex = 18
        Me.lblCurrentStatus.Text = "..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(6, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Status :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(6, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Model :"
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(547, 46)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(102, 38)
        Me.btnNew.TabIndex = 6
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(439, 46)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(102, 38)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'txtSN
        '
        Me.txtSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSN.Location = New System.Drawing.Point(79, 46)
        Me.txtSN.Name = "txtSN"
        Me.txtSN.Size = New System.Drawing.Size(354, 38)
        Me.txtSN.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "SN :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnLogOut)
        Me.GroupBox2.Controls.Add(Me.btnLogIn)
        Me.GroupBox2.Controls.Add(Me.txtEn)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(700, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(470, 129)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operator Info"
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(189, 68)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(102, 38)
        Me.btnLogOut.TabIndex = 3
        Me.btnLogOut.Text = "LogOut"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnLogIn
        '
        Me.btnLogIn.Location = New System.Drawing.Point(81, 68)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(102, 38)
        Me.btnLogIn.TabIndex = 2
        Me.btnLogIn.Text = "LogIn"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'txtEn
        '
        Me.txtEn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEn.Location = New System.Drawing.Point(81, 24)
        Me.txtEn.Name = "txtEn"
        Me.txtEn.Size = New System.Drawing.Size(300, 38)
        Me.txtEn.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 29)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "EN :"
        '
        'btnSaveData
        '
        Me.btnSaveData.Location = New System.Drawing.Point(693, 745)
        Me.btnSaveData.Name = "btnSaveData"
        Me.btnSaveData.Size = New System.Drawing.Size(155, 34)
        Me.btnSaveData.TabIndex = 9
        Me.btnSaveData.TabStop = False
        Me.btnSaveData.Text = "Save Data"
        Me.btnSaveData.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtCleaver38)
        Me.GroupBox3.Controls.Add(Me.txtCleaver32)
        Me.GroupBox3.Controls.Add(Me.txtSplicerName)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 191)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(280, 153)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Splicer Information"
        '
        'txtCleaver38
        '
        Me.txtCleaver38.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCleaver38.Location = New System.Drawing.Point(160, 108)
        Me.txtCleaver38.Name = "txtCleaver38"
        Me.txtCleaver38.Size = New System.Drawing.Size(105, 38)
        Me.txtCleaver38.TabIndex = 8
        '
        'txtCleaver32
        '
        Me.txtCleaver32.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCleaver32.Location = New System.Drawing.Point(160, 65)
        Me.txtCleaver32.Name = "txtCleaver32"
        Me.txtCleaver32.Size = New System.Drawing.Size(105, 38)
        Me.txtCleaver32.TabIndex = 7
        '
        'txtSplicerName
        '
        Me.txtSplicerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSplicerName.Location = New System.Drawing.Point(160, 21)
        Me.txtSplicerName.Name = "txtSplicerName"
        Me.txtSplicerName.Size = New System.Drawing.Size(105, 38)
        Me.txtSplicerName.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(6, 121)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 20)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Cleaver CT-38 :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(6, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Cleaver CT-32 :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(6, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Machine S/N :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtRemark)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 351)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(278, 162)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Remark"
        '
        'txtRemark
        '
        Me.txtRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemark.Location = New System.Drawing.Point(9, 21)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(263, 125)
        Me.txtRemark.TabIndex = 7
        Me.txtRemark.TabStop = False
        '
        'btnSetting
        '
        Me.btnSetting.Location = New System.Drawing.Point(12, 745)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Size = New System.Drawing.Size(155, 34)
        Me.btnSetting.TabIndex = 19
        Me.btnSetting.TabStop = False
        Me.btnSetting.Text = "SETTING"
        Me.btnSetting.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblMaxHour)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.lblMaxArc)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.lblLast)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.lblArcSince)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.lblArcCount)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 518)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(278, 170)
        Me.GroupBox5.TabIndex = 20
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Control"
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.Location = New System.Drawing.Point(76, 133)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(24, 17)
        Me.lblLast.TabIndex = 11
        Me.lblLast.Text = "...."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 133)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 17)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Last Arc :"
        '
        'lblArcSince
        '
        Me.lblArcSince.AutoSize = True
        Me.lblArcSince.Location = New System.Drawing.Point(64, 107)
        Me.lblArcSince.Name = "lblArcSince"
        Me.lblArcSince.Size = New System.Drawing.Size(24, 17)
        Me.lblArcSince.TabIndex = 9
        Me.lblArcSince.Text = "...."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 107)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 17)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Since :"
        '
        'lblArcCount
        '
        Me.lblArcCount.AutoSize = True
        Me.lblArcCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArcCount.Location = New System.Drawing.Point(142, 23)
        Me.lblArcCount.Name = "lblArcCount"
        Me.lblArcCount.Size = New System.Drawing.Size(23, 25)
        Me.lblArcCount.TabIndex = 7
        Me.lblArcCount.Text = "1"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(129, 17)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Current Arc Count :"
        '
        'lblMaxHour
        '
        Me.lblMaxHour.AutoSize = True
        Me.lblMaxHour.Location = New System.Drawing.Point(82, 83)
        Me.lblMaxHour.Name = "lblMaxHour"
        Me.lblMaxHour.Size = New System.Drawing.Size(24, 17)
        Me.lblMaxHour.TabIndex = 15
        Me.lblMaxHour.Text = "...."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 83)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 17)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Max hour :"
        '
        'lblMaxArc
        '
        Me.lblMaxArc.AutoSize = True
        Me.lblMaxArc.Location = New System.Drawing.Point(82, 57)
        Me.lblMaxArc.Name = "lblMaxArc"
        Me.lblMaxArc.Size = New System.Drawing.Size(24, 17)
        Me.lblMaxArc.TabIndex = 13
        Me.lblMaxArc.Text = "...."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 57)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 17)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "Max Arc :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1180, 810)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnSetting)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnSaveData)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtLossValue)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSet)
        Me.Controls.Add(Me.lbSplicerName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auto Splicer - ACACIA"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tssSplicer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbSplicerName As System.Windows.Forms.Label
    Friend WithEvents btnSet As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLossValue As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents tssMessage As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents txtSN As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCurrentStatus As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbModel As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEn As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents btnLogIn As System.Windows.Forms.Button
    Friend WithEvents cbOperation As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnSaveData As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCleaver38 As System.Windows.Forms.TextBox
    Friend WithEvents txtCleaver32 As System.Windows.Forms.TextBox
    Friend WithEvents txtSplicerName As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents btnSetting As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lblArcSince As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblArcCount As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblLast As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblMaxHour As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblMaxArc As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label

End Class
