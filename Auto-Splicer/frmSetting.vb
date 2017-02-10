Imports System.IO
Imports Newtonsoft.Json


Public Class frmSetting
    Private dataTable As DataTable
    Private dataSet As DataSet
    Private dataSetSplicer As DataSet
    Private dataSetSetting As DataSet
    Private dataSetArc As DataSet

    Private vConfigurationPath As String

    Public Property configuration_path() As String
        Get
            Return getConfigurationPath()
        End Get
        Set(ByVal value As String)
            vConfigurationPath = value
        End Set
    End Property

    Public Property output_path() As String
        Get
            Return getOutputPath()
        End Get
        Set(ByVal value As String)
            vConfigurationPath = value
        End Set
    End Property

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


    Private Sub frmSetting_Load(sender As Object, e As EventArgs) Handles Me.Load


        'Get Path Setting
        Dim vSplicerFile As String = getConfigurationPath() & "splicer.json"
        Dim vConfigFile As String = getConfigurationPath() & "configuration.json"
        Dim vArcFile As String = getConfigurationPath() & "arc.json"

        txtConfPath.Text = getConfigurationPath()
        txtLogPath.Text = getOutputPath()

        ''---Model---
        Dim vConfigJson As String = File.ReadAllText(vConfigFile)
        Dim vSplicerJson As String = File.ReadAllText(vSplicerFile)
        Dim vArcJson As String = File.ReadAllText(vArcFile)

        dataSet = JsonConvert.DeserializeObject(Of DataSet)(vConfigJson)
        dataSetSplicer = JsonConvert.DeserializeObject(Of DataSet)(vSplicerJson)


        dgOperation.DataSource = dataSet.Tables("operation")
        dgModel.DataSource = dataSet.Tables("model")

        cbModel.DataSource = dataSet.Tables("model")
        cbModel.ValueMember = "name"
        cbModel.DisplayMember = "name"

        '---Splicer-----
        Dim vSplicer As String = cbModel.SelectedValue
        dgSplicer.DataSource = dataSetSplicer.Tables(vSplicer)
        '---------------

        '-----Arc-------
        dataSetArc = JsonConvert.DeserializeObject(Of DataSet)(vArcJson)
        With dataSetArc.Tables("arc")
            lblArcCount.Text = .Rows(0).Item("count")
            txtArcMax.Text = .Rows(0).Item("maxcount")
            txtMaxHour.Text = .Rows(0).Item("maxhour")
            lblLastReset.Text = .Rows(0).Item("startdate")
            lblLastArc.Text = .Rows(0).Item("lastdate")
        End With
        '---------------

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim vSettingFile As String = Application.StartupPath & "\setting.json"
        dataSetSetting.Tables("setting").Rows(0).Item("output") = txtLogPath.Text
        dataSetSetting.Tables("setting").Rows(0).Item("configuration") = txtConfPath.Text
        Dim vJsonSettingStr As String = JsonConvert.SerializeObject(dataSetSetting, Formatting.Indented)
        File.WriteAllText(vSettingFile, vJsonSettingStr)


        'DataSet.Tables("configuration").TableName = txtSN.Text
        Dim vConfigFile As String = getConfigurationPath() & "configuration.json"
        Dim vSplicerFile As String = getConfigurationPath() & "splicer.json"
        Dim vArcFile As String = getConfigurationPath() & "arc.json"

        Dim vJsonStr As String = JsonConvert.SerializeObject(dataSet, Formatting.Indented)
        File.WriteAllText(vConfigFile, vJsonStr)

        Dim vJsonSplicerStr As String = JsonConvert.SerializeObject(dataSetSplicer, Formatting.Indented)
        File.WriteAllText(vSplicerFile, vJsonSplicerStr)


        With dataSetArc.Tables("arc")
            .Rows(0).Item("maxcount") = txtArcMax.Text
            .Rows(0).Item("maxhour") = txtMaxHour.Text
        End With
        Dim vJsonArcStr As String = JsonConvert.SerializeObject(dataSetArc, Formatting.Indented)
        File.WriteAllText(vArcFile, vJsonArcStr)


        MsgBox("Save successfull!", MsgBoxStyle.Information, "Save configuration")
        Me.Close()
    End Sub



    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click
        cbModel.Refresh()
    End Sub

    Private Sub cbModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbModel.SelectedIndexChanged
        'MsgBox(cbModel.SelectedValue)
        Dim vSplicer As String = cbModel.SelectedValue
        Dim vDataTable As DataTable = dataSetSplicer.Tables(vSplicer)

        If Not vDataTable Is Nothing Then
            dgSplicer.DataSource = vDataTable
        Else
            vDataTable = GetSplicerTable(vSplicer)
            dgSplicer.DataSource = vDataTable
            dataSetSplicer.Tables.Add(vDataTable)
        End If





    End Sub

    Function GetSplicerTable(vTableName) As DataTable
        ' Create new DataTable instance.
        Dim table As New DataTable

        table.TableName = vTableName
        ' Create four typed columns in the DataTable.
        table.Columns.Add("seq", GetType(Integer))
        table.Columns.Add("name", GetType(String))
        table.Columns.Add("fiber", GetType(String))
        table.Columns.Add("program", GetType(String))
        table.Columns.Add("maxloss", GetType(String))

        '' Add five rows with those columns filled in the DataTable.
        'table.Rows.Add("Splicer Number", txtSplicerName.Text)
        'table.Rows.Add("Cleaver CT-32 Number", txtCleaver32.Text)
        'table.Rows.Add("Cleaver CT-38 Number", txtCleaver38.Text)
        'table.Rows.Add("Remark", txtRemark.Text.Replace("|", " "))
        Return table
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnArcReset_Click(sender As Object, e As EventArgs) Handles btnArcReset.Click
        With dataSetArc.Tables("arc")
            '.Rows(0).Item("") = 0
            .Rows(0).Item("count") = 0
            .Rows(0).Item("maxcount") = txtArcMax.Text
            .Rows(0).Item("maxhour") = txtMaxHour.Text
            .Rows(0).Item("startdate") = Now
            '.Rows(0).Item("lastdate")=""

            '--update screen--
            lblArcCount.Text = .Rows(0).Item("count")
            txtArcMax.Text = .Rows(0).Item("maxcount")
            txtMaxHour.Text = .Rows(0).Item("maxhour")
            lblLastReset.Text = .Rows(0).Item("startdate")
            lblLastArc.Text = .Rows(0).Item("lastdate")
        End With


    End Sub
End Class