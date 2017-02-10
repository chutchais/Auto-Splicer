
Imports Newtonsoft.Json
Imports System.IO

Public Class Form1
    Private WithEvents UsbFsm As UsbFsm100ServerClass
    Private splicerTable As DataTable
    Private dataTable As DataTable
    Private dataSet As DataSet
    Private dataSetSetting As DataSet
    Private dataSetArc As DataSet

    Private vRecentSaved As String = Application.StartupPath & "\recently_saved.json"
    Public vConfPath As String = "d:\" 'Application.StartupPath & "\"

    Dim objFITSDLL As FITSDLL.clsDB

    Private vArcCount As Integer
    ' Private objFITSDLL As New FITSDLL.clsDB

    'Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click

    '    Dim strVal As String
    '    strVal = UsbFsm.CommandAndReceiveText("=FUNCSTAT", 1000)
    '    If strVal = "NOFIN" Then
    '        strVal = UsbFsm.CommandAndReceiveText("=DAT|ESTLOSS", 1000)
    '    End If
    '    tssMessage.Text = strVal

    'End Sub
    Private Sub wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub
    
    Private Sub UsbFsm_Attached(sender As Object, e As EventArgs) Handles UsbFsm.Attached
        tssSplicer.Text = "Connected"
    End Sub

    Private Sub UsbFsm_Detached(sender As Object, e As EventArgs) Handles UsbFsm.Detached
        tssSplicer.Text = "Disonnect"
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'High light on last Column (first row)
        'Me.DataGridView1.CurrentCell = Me.DataGridView1(1, 0)


        
        

    End Sub


    Private Sub Form1_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        UsbFsm = Nothing
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        initialConfiguration()

        'foreach (DataRow row in dataTable.Rows)
        'Console.WriteLine(row["id"] + " - " + row["item"]);
        UsbFsm = New UsbFsm100ServerClass(Me.Handle)
        objFITSDLL = New FITSDLL.clsDB
        Dim vInitResult As Boolean

        With objFITSDLL
            vInitResult = .fn_InitDB("*", "", "2.9", "dbAcacia")
        End With

        Me.Text = Me.Text + " version : " & Application.ProductVersion.Trim
        'Dim vHandShake As String
        'vHandShake = objFITSDLL.fn_Handshake("CFP", "180", "2.9", "vSn")
        ' vHandShake = objFITSDLL.fn_Query("CFP", "180", "2.9", "vSn")
        ' UsbFsm.InitDriver(Me.Handle)
    End Sub

    Private Function getConfigurationPath() As String
        Dim vSplicerPath As String = ""
        Dim vConfigPath As String = ""
        Dim vSettingPath As String = Application.StartupPath & "\setting.json"
        Dim vSettingJson As String = File.ReadAllText(vSettingPath)
        dataSetSetting = JsonConvert.DeserializeObject(Of DataSet)(vSettingJson)
        If dataSetSetting.Tables.Count = 0 Then
            'vSplicerPath = "d:\"
            getConfigurationPath = "d:\"
        Else
            'vSplicerPath = dataSetSetting.Tables("setting").Rows(0).Item("configuration").ToString
            getConfigurationPath = dataSetSetting.Tables("setting").Rows(0).Item("configuration").ToString
        End If
    End Function

    Private Function getOutputPath() As String
        Dim vSplicerPath As String = ""
        Dim vConfigPath As String = ""
        Dim vSettingPath As String = Application.StartupPath & "\setting.json"
        Dim vSettingJson As String = File.ReadAllText(vSettingPath)
        dataSetSetting = JsonConvert.DeserializeObject(Of DataSet)(vSettingJson)
        If dataSetSetting.Tables.Count = 0 Then
            'vSplicerPath = "d:\"
            getOutputPath = "d:\"
        Else
            'vSplicerPath = dataSetSetting.Tables("setting").Rows(0).Item("configuration").ToString
            getOutputPath = dataSetSetting.Tables("setting").Rows(0).Item("output").ToString
        End If
    End Function


    Sub initialConfiguration()

        btnSave.Enabled = False
        'Login
        txtEn.Text = "" : txtEn.Enabled = True : txtEn.Select()
        btnLogIn.Enabled = True : btnLogOut.Enabled = False
        '-----
        vConfPath = getConfigurationPath()

        ''---Model---
        'Dim vModelJson As String = File.ReadAllText(vConfPath & "model.json")
        'Dim vModeldataSet As DataSet = JsonConvert.DeserializeObject(Of DataSet)(vModelJson)
        'cbModel.DataSource = vModeldataSet.Tables("model")
        'cbModel.ValueMember = "name"
        'cbModel.DisplayMember = "name"
        ''dataTable = dataSet.Tables("configuration")
        ''-------

        ''---Model---
        'Dim vOperationJson As String = File.ReadAllText(vConfPath & "operation.json")
        'Dim vOperationdataSet As DataSet = JsonConvert.DeserializeObject(Of DataSet)(vOperationJson)
        'cbOperation.DataSource = vOperationdataSet.Tables("operation")
        'cbOperation.ValueMember = "operation"
        'cbOperation.DisplayMember = "name"
        ''dataTable = dataSet.Tables("configuration")
        ''-------
        Dim vConfJson As String = File.ReadAllText(vConfPath & "configuration.json")
        Dim vConfdataSet As DataSet = JsonConvert.DeserializeObject(Of DataSet)(vConfJson)

        cbModel.DataSource = vConfdataSet.Tables("model")
        cbModel.ValueMember = "name"
        cbModel.DisplayMember = "name"

        cbOperation.DataSource = vConfdataSet.Tables("operation")
        cbOperation.ValueMember = "operation"
        cbOperation.DisplayMember = "name"

        '----Arc-----
        Dim vArcJson As String = File.ReadAllText(vConfPath & "arc.json")
        dataSetArc = JsonConvert.DeserializeObject(Of DataSet)(vArcJson)

        lblArcCount.Text = dataSetArc.Tables("arc").Rows(0).Item("count")
        lblArcSince.Text = dataSetArc.Tables("arc").Rows(0).Item("startdate")
        lblCurrentArc.Text = dataSetArc.Tables("arc").Rows(0).Item("lastdate")
        lblMaxArc.Text = dataSetArc.Tables("arc").Rows(0).Item("maxcount")
        lblMaxHour.Text = dataSetArc.Tables("arc").Rows(0).Item("maxhour")

        LogOn(True)

        btnStart.Enabled = False
        btnNew.Enabled = False
        txtSN.Enabled = False : txtSN.Text = ""
        DataGridView1.DataSource = Nothing
        lbSplicerName.Text = "..."
        lblCurrentStatus.Text = "..."

        txtLossValue.Enabled = False
        txtLossValue.Text = ""
        txtLossValue.BackColor = Color.White

        btnSaveData.Enabled = False
        btnClear.Enabled = False
        btnUpload.Enabled = False

        txtSplicerName.Enabled = False
        txtCleaver32.Enabled = False
        txtCleaver38.Enabled = False
        txtRemark.Enabled = False
        txtSplicerName.Text = ""
        txtCleaver32.Text = ""
        txtCleaver38.Text = ""
        txtRemark.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strVal As String
        strVal = UsbFsm.CommandAndReceiveText("$SET", 1000)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim strVal As String
        strVal = UsbFsm.CommandAndReceiveText("$MENU", 1000)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim strVal As String
        strVal = UsbFsm.CommandAndReceiveText("$ESC", 1000)
    End Sub


   

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object,
                                               ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) _
                                           Handles DataGridView1.CellEnter
        Dim vSplicNameIndex As Integer = 1 'e.ColumnIndex
        Dim vSplicValueIndex As Integer = 5 'e.ColumnIndex
        Dim value As Object = DataGridView1.Rows(e.RowIndex).Cells(vSplicValueIndex).Value
        Dim name As Object = DataGridView1.Rows(e.RowIndex).Cells(vSplicNameIndex).Value

        If IsDBNull(name) Then
            lbSplicerName.Text = "" ' blank if dbnull values
            txtLossValue.Text = ""
        Else
            lbSplicerName.Text = CType(name, String)
            txtLossValue.Text = IIf(IsDBNull(value), "", value)
            'DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Yellow
            ' btnSet.Select()
        End If
    End Sub


    Private Sub DataGridView1_CellLeaveClick(ByVal sender As System.Object,
                                               ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) _
                                           Handles DataGridView1.CellLeave
        Dim vSplicColIndex As Integer = 1 'e.ColumnIndex
        Dim value As Object = DataGridView1.Rows(e.RowIndex).Cells(vSplicColIndex).Value

        If IsDBNull(value) Then
            lbSplicerName.Text = "" ' blank if dbnull values
        Else
            lbSplicerName.Text = CType(value, String)
            DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
        End If
        btnSet.Text = "SET"
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles txtLossValue.GotFocus


    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLossValue.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnSave_Click(sender, e)
        End If
    End Sub

    Private Sub TextBox1_MouseEnter(sender As Object, e As EventArgs) Handles txtLossValue.MouseEnter
        txtLossValue.SelectAll()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtLossValue.TextChanged
        If txtLossValue.Text = "" Then
            txtLossValue.BackColor = Color.White
            btnSave.Enabled = False

            Exit Sub
        End If

        If IsNumeric(txtLossValue.Text) Then
            btnSave.Enabled = True

            Dim vSplicColIndex As Integer = 4 'e.ColumnIndex 'dataGridView1.CurrentRow.Index
            Dim MaxLoss As Double = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(vSplicColIndex).Value
            Dim vValue As Double = Val(txtLossValue.Text)
            If vValue <= MaxLoss Then
                txtLossValue.BackColor = Color.Green
            Else
                txtLossValue.BackColor = Color.Red
            End If

        Else
            txtLossValue.BackColor = Color.Red
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtLossValue.Text = "" Then
            MsgBox("Invalid LOSS value. (not allow blank value) " & vbCrLf & _
                   "Try to read value and Save again", MsgBoxStyle.Critical, "Invalid LOSS value")
            btnSet.Text = "Read Value"
            Exit Sub
        End If

        Dim vSplicColIndex As Integer = 5 'e.ColumnIndex 'dataGridView1.CurrentRow.Index
        Dim vValue As Double = Val(txtLossValue.Text)
        DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(vSplicColIndex).Value = vValue
        DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(vSplicColIndex).Style.BackColor = txtLossValue.BackColor

        btnSet.Text = "SET"

        If isListCompleted() Then
            btnUpload.Enabled = True
        Else
            btnUpload.Enabled = False
        End If


        'Move Next
        If DataGridView1.CurrentRow.Index < DataGridView1.Rows.Count - 1 Then
            Dim nextRow As DataGridViewRow = DataGridView1.Rows(DataGridView1.CurrentRow.Index + 1)
            DataGridView1.CurrentCell = nextRow.Cells(0)
            nextRow.Selected = True
            'txtLossValue.Select()
            btnSet.Select()
        Else
            DataGridView1.ClearSelection()
            btnUpload.Select()
        End If
    End Sub

    Function isListCompleted() As Boolean

        Dim vSplicColIndex As Integer = 4 'e.ColumnIndex 'dataGridView1.CurrentRow.Index
        'Dim MaxLoss As Double = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(vSplicColIndex).Value
        'Dim vValue As Double = Val(txtLossValue.Text)
        'If vValue <= MaxLoss Then
        '    txtLossValue.BackColor = Color.Green
        'Else
        '    txtLossValue.BackColor = Color.Red
        'End If
        'Dim MaxLoss As Double
        'Dim vValue As Double
        Dim row As DataRow
        Dim vRowIndex As Integer = 1
        For Each row In dataTable.Rows
            'MaxLoss = row.Item(vSplicColIndex).ToString
            'vValue = row.Item(vSplicColIndex + 1).ToString
            'If vValue <= MaxLoss Then
            '    DataGridView1.Rows(vRowIndex).Cells(vSplicColIndex + 1).Style.BackColor = Color.Green
            'Else
            '    DataGridView1.Rows(vRowIndex).Cells(0).Style.BackColor = Color.Red
            'End If
            vRowIndex = vRowIndex + 1
            If row(5).ToString = "" Then
                Return False
            End If
        Next
        Return True
        'Console.WriteLine(row["id"] + " - " + row["item"]);
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        initialConfiguration()
        If File.Exists(vRecentSaved) Then
            File.Delete(vRecentSaved)
        End If
    End Sub


    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click


        If MsgBox("Are you sure to upload data to FIT?", vbQuestion + vbYesNo + vbDefaultButton2, _
                  "Upload data") = vbYes Then
            'Upload Data.
            Dim vSn As String = txtSN.Text
            Dim vModel As String = cbModel.SelectedValue
            Dim vOperation As String = cbOperation.SelectedValue
            Dim vEn As String = txtEn.Text
            If uploadToFit(vSn, vModel, vOperation, vEn) Then
                'Keep Output file
                saveLogFile(vModel & "_" & vSn & ".json", vModel)
                MsgBox("Upload data successful", MsgBoxStyle.Information, "Success!!")
            End If
            'intial data
            btnNew_Click(sender, e)
            If File.Exists(vRecentSaved) Then
                File.Delete(vRecentSaved)
            End If
        End If
    End Sub

    Sub saveLogFile(vFilename As String, vModel As String)
        Dim vOutFolder As String = getOutputPath() & Now.ToString("yyyyMMdd") & "\"
        If Not Directory.Exists(vOutFolder) Then
            ' This path is a directory.
            Directory.CreateDirectory(vOutFolder)
        End If
        If File.Exists(vOutFolder & vFilename) Then
            File.Delete(vOutFolder & vFilename)
        Else
            Dim vJsonStr As String = JsonConvert.SerializeObject(dataSet.Tables(vModel), Formatting.Indented)
            File.WriteAllText(vOutFolder & vFilename, vJsonStr)
        End If
    End Sub

    Function uploadToFit(vSn As String, vModel As String, _
                         vOperation As String, vEn As String) As Boolean
        Try
            'Handcheck
            Dim vHandShake As String
            Dim vCheckIn As String = ""
            Dim vCheckOut As String = ""
            Dim vParamList As String = "FBN Serial No|CFP P/N|EN"
            Dim vDataList As String = ""
            Dim vResult As String = "PASS"
            Dim vRemark As String = ""
            Dim vCFPpn As String = ""
            vCFPpn = objFITSDLL.fn_Query(vModel, vOperation, "2.9", vSn, "part_no", ",")
            vDataList = vSn & "|" & vCFPpn & "|" & vEn

            Dim row As DataRow
            'Splicer Info
            splicerTable = GetSplicerTable()
            For Each row In splicerTable.Rows
                vParamList = vParamList & "|" & row(0).ToString
                vDataList = vDataList & "|" & row(1).ToString
            Next
            'Measurement data
            For Each row In dataTable.Rows
                vParamList = vParamList & "|" & row(1).ToString
                vDataList = vDataList & "|" & row(5).ToString
                'check fail record.
                If row(5).ToString = "" Or Val(row(5).ToString) > Val(row(4).ToString) Then
                    vResult = "FAIL"
                    vRemark = row(1).ToString & " = " & row(5).ToString & " (0/" & row(4).ToString & ")"
                End If
            Next
            'Append Result
            vParamList = vParamList & "|Result|ARC_COUNT"
            vDataList = vDataList & "|" & vResult & "|" & "1"

            vHandShake = objFITSDLL.fn_Handshake(vModel, vOperation, "2.9", vSn)

            'Rev = '0' check-in insert
            'Rev = '3' check-in update


            'Rev = '1'  check-out insert
            'Rev = '2'  check-out update (not working yet, please use delete and re-insert instead)

            'Rev = '5'  check-out delete
            'Rev = '6'  check-in delete


            Select Case vHandShake
                Case "True"
                    'Need both check in and Out
                    vCheckIn = objFITSDLL.fn_Log(vModel, vOperation, "0", "FBN Serial No", vSn) 'Insert
                    'vCheckIn = objFITSDLL.fn_Log(vModel, vOperation, "6", "FBN Serial No", vSn) 'Delete

                    vCheckOut = objFITSDLL.fn_Log(vModel, vOperation, "1", vParamList, vDataList, "|")
                    vCheckIn = objFITSDLL.fn_Log(vModel, vOperation, "5", "FBN Serial No", vSn) 'Checkout Delete
                    vCheckIn = objFITSDLL.fn_Log(vModel, vOperation, "6", "FBN Serial No", vSn) 'Checkin Delete 

                    'Log(Now() & "--" & vSn & "--" & vModel & "--" & vProcess & "--" & vExeStation & "--" & vLastID & "--" & vCheckOut & "--" & IIf(vResult = "Passed", "PASS", vDisposCode))
                Case vHandShake.Contains("in-processing in " & vOperation)
                    'already check-in,Need only Check-out
                    vCheckOut = objFITSDLL.fn_Log(vModel, vOperation, "1", vParamList, vDataList, "|")
                    'Log(Now() & "--" & vSn & "--" & vModel & "--" & vProcess & "--" & vExeStation & "--" & vLastID & "--" & vCheckOut & "--" & IIf(vResult = "Passed", "PASS", vDisposCode))
                Case Else
                    MsgBox("Unable to upload data to FIT" & vbCrLf & _
                        "Because " & vHandShake, MsgBoxStyle.Critical, "Unable to upload data")
                    Return False
            End Select
            'Check IN
            'check Out

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click
        Dim vTag As String = btnSet.Text
        Dim strVal As String
        Select Case vTag
            Case "SET"
                If Not checkArc() Then
                    Exit Sub
                End If
                strVal = UsbFsm.CommandAndReceiveText("$SET", 1000)
                btnSet.Text = "Read Value"
            Case "Read Value"
                If Not checkArc() Then
                    Exit Sub
                End If
                strVal = UsbFsm.CommandAndReceiveText("=FUNCSTAT", 1000)
                If strVal = "NOFIN" Then
                    strVal = UsbFsm.CommandAndReceiveText("=DAT|ESTLOSS", 1000)
                    txtLossValue.Text = Split(strVal, "=")(1)
                End If
                '----Increase Arc Count---
                increaseArcCount()
                '-------------------------
                tssMessage.Text = strVal
                btnSet.Text = "Save"
            Case "Save"
                btnSave_Click(sender, e)
                'btnSet.Text = "SET"
        End Select
    End Sub

    Sub increaseArcCount()
        dataSetArc.Tables("arc").Rows(0).Item("count") = dataSetArc.Tables("arc").Rows(0).Item("count") + 1
        dataSetArc.Tables("arc").Rows(0).Item("lastdate") = Now
        lblArcCount.Text = dataSetArc.Tables("arc").Rows(0).Item("count")
        lblCurrentArc.Text = dataSetArc.Tables("arc").Rows(0).Item("lastdate")

        Dim vArcFile As String = getConfigurationPath() & "arc.json"
        Dim vJsonArcStr As String = JsonConvert.SerializeObject(dataSetArc, Formatting.Indented)
        File.WriteAllText(vArcFile, vJsonArcStr)
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        btnSet.Text = "SET"
    End Sub

    Private Function checkArc() As Boolean
        Try
            Dim vCurrentArc As Integer = dataSetArc.Tables("arc").Rows(0).Item("count")
            Dim vMaxArc As Integer = dataSetArc.Tables("arc").Rows(0).Item("maxcount")
            Dim vMaxHour As Integer = dataSetArc.Tables("arc").Rows(0).Item("maxhour")
            Dim vStartDate As Date = dataSetArc.Tables("arc").Rows(0).Item("startdate")
            Dim duration As TimeSpan = Now - vStartDate
            '1-Check Over Arc count
            If vCurrentArc > vMaxArc Then
                MsgBox("Arc count is over limit,Please PM", MsgBoxStyle.Critical, "Arc count is Over")
                Return False
            End If
            '2-Check Over Hour
            If duration.TotalHours > vMaxHour Then
                MsgBox("Arc count is over limit,Please PM", MsgBoxStyle.Critical, "Arc count is Over")
                Return False
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If Not checkArc() Then
            Exit Sub
        End If

        '1) do Handshake First
        Dim vModel As String = cbModel.SelectedValue.ToString
        Dim vOperation As String = cbOperation.SelectedValue.ToString
        Dim vSn As String = txtSN.Text
        Dim vHandShake As String

        'vHandShake = objFITSDLL.fn_Query(vModel, vOperation, "2.9", vSn, "model")
        vHandShake = objFITSDLL.fn_Handshake(vModel, vOperation, "2.9", vSn)

        lblCurrentStatus.Text = vHandShake
        lblCurrentStatus.ForeColor = IIf(vHandShake = "True", Color.Green, Color.Red)

        If vHandShake = "True" Then
            Dim vJson As String
            'check Recently saved file
            If File.Exists(vRecentSaved) Then
                vJson = File.ReadAllText(vRecentSaved)
                dataSet = JsonConvert.DeserializeObject(Of DataSet)(vJson)
                If dataSet.Tables.Contains(vSn) Then
                    If MsgBox("Found recently saved data, Do you need to re-load?", MsgBoxStyle.Question + vbYesNo + vbDefaultButton1, _
                              "Found recently saved file") = vbYes Then
                        dataSet.Tables(vSn).TableName = vModel
                        dataTable = dataSet.Tables(vModel)
                        'Datatable of Splicer info
                        Dim vSplicerTable As DataTable = dataSet.Tables("splicer")
                        With vSplicerTable
                            If .Rows.Count > 0 Then
                                txtSplicerName.Text = .Rows(0).Item(1).ToString
                                txtCleaver32.Text = .Rows(1).Item(1).ToString
                                txtCleaver38.Text = .Rows(2).Item(1).ToString
                                txtRemark.Text = .Rows(3).Item(1).ToString
                            End If
                        End With
                        '-------------------------
                        If isListCompleted() Then
                            btnUpload.Enabled = True
                        Else
                            btnUpload.Enabled = False
                        End If
                    Else
                        GoTo NewUnit
                    End If
                Else
                    'New Start
                    GoTo NewUnit

                End If

                Else
                    'New Start
NewUnit:
                vJson = File.ReadAllText(vConfPath & "splicer.json")
                    dataSet = JsonConvert.DeserializeObject(Of DataSet)(vJson)
                dataTable = dataSet.Tables(vModel)
                dataTable.Columns.Add("Splicing LOSS", GetType(Double))
                btnUpload.Enabled = False
                btnSet.Text = "SET"
                End If
                '---


                DataGridView1.DataSource = dataTable

            '--Splicer info
            txtSplicerName.Enabled = True
            txtCleaver32.Enabled = True
            txtCleaver38.Enabled = True
            txtRemark.Enabled = True
            '-----

                btnStart.Enabled = False
                btnNew.Enabled = True
            txtSN.Enabled = False

            btnSaveData.Enabled = True
            btnClear.Enabled = True

            'txtLossValue.Enabled = True
            'txtLossValue.Select()
            txtCleaver32.Enabled = True
            txtCleaver38.Enabled = True
            txtSplicerName.Enabled = True
            txtSplicerName.Select()
            txtRemark.Enabled = True
            Else
                txtSN.SelectAll()
            End If

    End Sub

    Private Sub txtEn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEn.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnLogIn_Click(sender, e)
        End If
    End Sub

    Private Sub txtEn_Validated(sender As Object, e As EventArgs) Handles txtEn.Validated

    End Sub

    Private Sub txtEn_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtEn.Validating
        If txtEn.TextLength <> 6 Then
            e.Cancel = True
        End If

        If Not IsNumeric(txtEn.Text) Then
            e.Cancel = True  
        End If
    End Sub

    Sub LogOn(vEnable As Boolean)
        'Login
        If vEnable Then
            txtEn.Text = ""
            txtEn.Select()
        End If

        txtEn.Enabled = vEnable
        btnLogIn.Enabled = vEnable : btnLogOut.Enabled = Not vEnable
        '-----

        'Serial Number
        txtSN.Enabled = Not vEnable
        btnStart.Enabled = Not vEnable
        btnNew.Enabled = Not vEnable
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click

        If txtEn.TextLength <> 6 Or Not IsNumeric(txtEn.Text) Then
            MsgBox("Invalid Employee number", MsgBoxStyle.Critical, "Invalid EN")
            Exit Sub

        End If

       
        LogOn(False) 'already Loged in
        txtSN.Select()

    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        LogOn(True) 'Signed out
        initialConfiguration()
    End Sub

    Private Sub cbModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbModel.SelectedIndexChanged

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        btnStart.Enabled = True
        btnNew.Enabled = True
        btnSaveData.Enabled = False
        btnClear.Enabled = False
        btnUpload.Enabled = False
        txtSN.Enabled = True : txtSN.Text = "" : txtSN.Select()
        DataGridView1.DataSource = Nothing
        lbSplicerName.Text = "..."
        lblCurrentStatus.Text = "..."
        txtSplicerName.Text = ""
        txtCleaver32.Text = ""
        txtCleaver38.Text = ""
        txtRemark.Text = ""
        txtLossValue.Text = ""
        txtLossValue.ForeColor = Color.White
    End Sub

    Private Sub btnSaveData_Click(sender As Object, e As EventArgs) Handles btnSaveData.Click
        ' Dim dataSet As DataSet = JsonConvert.DeserializeObject(Of DataSet)(vJson)
        Dim vNewDataSet As New DataSet
        Dim vNewTable As New DataTable
        Dim vModel As String = cbModel.SelectedValue
        With dataSet.Tables
            'If .Contains("splicer") Then
            '    dataSet.Tables.Remove("splicer")
            'End If
            vNewDataSet.Tables.Add(GetSplicerTable)
            vNewTable = dataSet.Tables(vModel).Copy()
            vNewDataSet.Tables.Add(vNewTable)
            vNewDataSet.Tables(vModel).TableName = txtSN.Text


            'Dim rows = vNewDataSet.Tables(txtSN.Text).Select("seq = 10")
            'For Each r In rows
            '    tmpCoupon = r("Splicing LOSS")
            'Next


        End With

        Dim vJsonStr As String = JsonConvert.SerializeObject(vNewDataSet, Formatting.Indented)
        File.WriteAllText(vRecentSaved, vJsonStr)
        MsgBox("Save successfull!", MsgBoxStyle.Information, "Save data")
    End Sub

    Private Sub txtSN_GotFocus(sender As Object, e As EventArgs) Handles txtSN.GotFocus
        txtSN.SelectAll()
    End Sub


    Private Sub txtSN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSN.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnStart_Click(sender, e)
        End If
    End Sub


    Private Sub txtEn_TextChanged(sender As Object, e As EventArgs) Handles txtEn.TextChanged

    End Sub

    Private Sub txtSplicerName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSplicerName.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtSplicerName_TextChanged(sender As Object, e As EventArgs) Handles txtSplicerName.TextChanged
        IsSplicerInfoCompleted()
    End Sub

    Function IsSplicerInfoCompleted() As Boolean
        If txtSplicerName.Text <> "" And _
            txtCleaver32.Text <> "" And _
            txtCleaver38.Text <> "" Then
            txtLossValue.Enabled = True
            'txtLossValue.Select()
            Return True
        Else
            txtLossValue.Enabled = False
            Return False
        End If
    End Function

    Private Sub txtCleaver32_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCleaver32.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtCleaver32_TextChanged(sender As Object, e As EventArgs) Handles txtCleaver32.TextChanged
        IsSplicerInfoCompleted()
    End Sub

    Private Sub txtCleaver38_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCleaver38.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtCleaver38_TextChanged(sender As Object, e As EventArgs) Handles txtCleaver38.TextChanged
        IsSplicerInfoCompleted()
    End Sub

    Function GetSplicerTable() As DataTable
        ' Create new DataTable instance.
        Dim table As New DataTable

        table.TableName = "splicer"
        ' Create four typed columns in the DataTable.
        table.Columns.Add("name", GetType(String))
        table.Columns.Add("value", GetType(String))

        ' Add five rows with those columns filled in the DataTable.
        table.Rows.Add("Machine S/N", txtSplicerName.Text)
        table.Rows.Add("Cleaver CT-32 Number", txtCleaver32.Text)
        table.Rows.Add("Cleaver CT-38 Number", txtCleaver38.Text)
        table.Rows.Add("Remark", txtRemark.Text.Replace("|", " "))
        Return table
    End Function

    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        Dim frmConfiguration = New frmSetting
        frmConfiguration.ShowDialog()
        'Refresh all Configuration
        initialConfiguration()
    End Sub

  
End Class
