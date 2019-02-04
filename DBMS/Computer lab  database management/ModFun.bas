Attribute VB_Name = "ModFun"
Public Sub Combo_Fill(cmbID As ComboBox, table_name As String, col As String, ord_name As String)
    Dim Index As Integer
    Call ModConnect.Records_Close
    ModConnect.Rs.Open "select distinct " + col + " from  " + table_name + "  order by " + ord_name + " ", ModConnect.Conn, adOpenForwardOnly
    cmbID.Clear
'   ModConnect.Recs.Open "select * from lab", , adOpenDynamic, adLockReadOnly
    While ModConnect.Rs.EOF = False
        cmbID.AddItem Rs(0)
        cmbID.ItemData(cmbID.NewIndex) = Index
        Index = Index + 1
        ModConnect.Conn.Execute ("select " + col + " from " + table_name + " order by " + ord_name + "")
        ModConnect.Rs.MoveNext
    Wend
    ModConnect.Rs.Close
    cmbID.ListIndex = -1
End Sub

Public Sub Count_No_(str As String)
    Call ModConnect.Records_Close
    Rs.Open "select count(sys_no) from system where lab = '" + str + "'", Cn, adOpenDynamic
    Stg = "select count(sys_no) from system where lab = '" + str + "'"
    ModConnect.Conn.Execute (Stg)
    num1 = Rs(0)
    num1 = CStr(num1)
    Rs.Close
    ModConnect.Rs.Open "select * from lab", ModConnect.Conn, adOpenDynamic
    Stg = "update lab set no_of_sys =" + num1 + " where lab_name =  '" + str + "' "
    ModConnect.Conn.Execute ("update lab set no_of_sys = to_number('" + num1 + "') where lab_name =  '" + str + "'")
'    ModConnect.Conn.Execute (stg)
    ModConnect.Records_Close
End Sub

Public Sub Un_Reserve()
'   Remove reservation whose time are already elasped
    ModConnect.Records_Close
    On Error GoTo err
    ModConnect.Recs.Open "select user_id from reservation", ModConnect.Conn, adOpenDynamic
    Stg = "delete reservation where res_date < (sysdate - .1)"
    ModConnect.Conn.Execute (Stg)
    ModConnect.Records_Close
err:
End Sub

Public Sub Numbers_(KeyAscii As Integer)
    Dim Ch As String * 1
    Ch = Chr$(KeyAscii)
    Select Case Ch
    Case 0 To 9:
    Case vbBack:
    Case Else: KeyAscii = 0
    End Select
End Sub

Public Sub Enter_key_(KeyAscii As Integer, Cmd_Button As CommandButton)
    If KeyAscii = 13 Then
        Cmd_Button.Value = True
    End If
End Sub

Public Sub Chk_Cmb_(Chk As CheckBox, Cmb As ComboBox)
    If Chk.Value = 0 Then
        Cmb.ListIndex = -1
        Cmb.Enabled = False
        Cmb.BackColor = &H80000011
    Else
        Cmb.Enabled = True
        Cmb.BackColor = &H80000005
    End If
End Sub

Public Sub Data_Grid_Fill_(Dg As DataGrid, Stg As String)
    ModConnect.Records_Close
    ModConnect.Rs.Open Stg, ModConnect.Conn, adOpenKeyset, adLockPessimistic
    ModConnect.Conn.Execute (Stg)
    If ModConnect.Rs.RecordCount = -1 Or ModConnect.Rs.RecordCount = 0 Then
        MsgBox "Nothing to Display", vbInformation, "Unsuccessful Search"
        Stg = ""
    Else
        Set Dg.DataSource = ModConnect.Rs
    End If
End Sub

Public Sub Logout_Call()
    ModConnect.Rhis.Open "select user_id from history", ModConnect.Conn, adOpenDynamic
    stg1 = "insert into history (user_id,login) values ('" + ModVar.LOGIN_ID + "','" + ModVar.LOGIN_TIME + "')"
    stg2 = "update history set sys_no = '" + ModVar.LOGIN_SYS + "', lab_name = '" + ModVar.LOGIN_LAB + "',name='" + ModVar.LOGIN_NAME + "'where user_id = '" + ModVar.LOGIN_ID + "'"
    LOGOUT_TIME = Now
    Stg = "update history set logout = '" + ModVar.LOGOUT_TIME + "' where user_id = '" + ModVar.LOGIN_ID + "' and login='" + LOGIN_TIME + "'"
    ModConnect.Conn.Execute (stg1)
    ModConnect.Conn.Execute (stg2)
    ModConnect.Conn.Execute (Stg)
    ModConnect.Records_Close
    LOGOUT_TIME = Date + Time
    LOGIN_ID = MDIFrmMain.lblLogin.Caption = ""
    LOGIN_NAME = ""
    MDIFrmMain.lblName.Caption = "<---Press on Login to enter"
    MDIFrmMain.picSCmds.Visible = False
    MDIFrmMain.cmdLogin.Caption = "Login"
    MDIFrmMain.lblLogin.Caption = " Idle from Time : "
    MDIFrmMain.Timer1.Enabled = True
End Sub

