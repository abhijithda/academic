VERSION 5.00
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Object = "{E7D6E204-3EEC-4D89-8955-8236E52B25C0}#1.0#0"; "TCI_TOOLS.OCX"
Begin VB.Form frmAdvStuSrch 
   BackColor       =   &H008080FF&
   Caption         =   "Advanced Search"
   ClientHeight    =   7710
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   10605
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   ScaleHeight     =   7710
   ScaleWidth      =   10605
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin VB.CommandButton cmdDel 
      Caption         =   "Delete Group"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   4800
      TabIndex        =   15
      Top             =   8640
      Visible         =   0   'False
      Width           =   2500
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Get report of this query"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   960
      TabIndex        =   14
      Top             =   8640
      Visible         =   0   'False
      Width           =   3135
   End
   Begin TCI_tools.SplabelB SplabelB1 
      Height          =   420
      Left            =   1680
      TabIndex        =   13
      Top             =   240
      Width           =   9990
      _ExtentX        =   17621
      _ExtentY        =   741
      CAPTION         =   "Check the checkbox and enter the fields which you want for searching"
      BACKCOLOUR      =   -2147483633
      TEXTBACKCOLOUR  =   12640511
      BACKSTYLE       =   1
      TEXTFORECOLOUR  =   7088128
      PLAY            =   -1  'True
      INTERVAL1       =   175
      INTERVAL2       =   10
      BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin MSDataGridLib.DataGrid DataGridStud 
      Height          =   4455
      Left            =   960
      TabIndex        =   1
      Top             =   3120
      Width           =   12975
      _ExtentX        =   22886
      _ExtentY        =   7858
      _Version        =   393216
      AllowUpdate     =   0   'False
      DefColWidth     =   167
      HeadLines       =   2
      RowHeight       =   23
      BeginProperty HeadFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ColumnCount     =   2
      BeginProperty Column00 
         DataField       =   ""
         Caption         =   ""
         BeginProperty DataFormat {6D835690-900B-11D0-9484-00A0C91110ED} 
            Type            =   0
            Format          =   ""
            HaveTrueFalseNull=   0
            FirstDayOfWeek  =   0
            FirstWeekOfYear =   0
            LCID            =   1033
            SubFormatType   =   0
         EndProperty
      EndProperty
      BeginProperty Column01 
         DataField       =   ""
         Caption         =   ""
         BeginProperty DataFormat {6D835690-900B-11D0-9484-00A0C91110ED} 
            Type            =   0
            Format          =   ""
            HaveTrueFalseNull=   0
            FirstDayOfWeek  =   0
            FirstWeekOfYear =   0
            LCID            =   1033
            SubFormatType   =   0
         EndProperty
      EndProperty
      SplitCount      =   1
      BeginProperty Split0 
         BeginProperty Column00 
         EndProperty
         BeginProperty Column01 
         EndProperty
      EndProperty
   End
   Begin VB.TextBox txtName 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   3000
      MaxLength       =   20
      TabIndex        =   12
      Top             =   1080
      Width           =   3000
   End
   Begin VB.CheckBox chkBr 
      BackColor       =   &H008080FF&
      Caption         =   "Branch"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   1560
      TabIndex        =   11
      Top             =   2280
      Width           =   1215
   End
   Begin VB.CheckBox chkNo 
      BackColor       =   &H008080FF&
      Caption         =   "Number of Logins"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   7800
      TabIndex        =   10
      Top             =   1680
      Width           =   2655
   End
   Begin VB.CheckBox chkBa 
      BackColor       =   &H008080FF&
      Caption         =   "Batch"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   1560
      TabIndex        =   9
      Top             =   1680
      Width           =   1215
   End
   Begin VB.CheckBox chkSem 
      BackColor       =   &H008080FF&
      Caption         =   "Semester"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   7800
      TabIndex        =   8
      Top             =   1080
      Width           =   2655
   End
   Begin VB.ComboBox cmbBr 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   405
      ItemData        =   "frmAdvStuSrch.frx":0000
      Left            =   3000
      List            =   "frmAdvStuSrch.frx":0022
      Sorted          =   -1  'True
      TabIndex        =   7
      Top             =   2280
      Width           =   2940
   End
   Begin VB.CheckBox chkName 
      BackColor       =   &H008080FF&
      Caption         =   "Name"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   1560
      TabIndex        =   6
      Top             =   1080
      Width           =   1215
   End
   Begin VB.TextBox txtNo 
      BeginProperty DataFormat 
         Type            =   1
         Format          =   "0;(0)"
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   1033
         SubFormatType   =   1
      EndProperty
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   420
      Left            =   10680
      MaxLength       =   3
      TabIndex        =   5
      Top             =   1680
      Width           =   1000
   End
   Begin VB.TextBox txtBa 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   420
      Left            =   3000
      MaxLength       =   5
      TabIndex        =   4
      Top             =   1680
      Width           =   2940
   End
   Begin VB.TextBox txtSem 
      BeginProperty DataFormat 
         Type            =   1
         Format          =   "0;(0)"
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   1033
         SubFormatType   =   1
      EndProperty
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   420
      Left            =   10680
      MaxLength       =   1
      TabIndex        =   3
      Top             =   1080
      Width           =   1000
   End
   Begin VB.CommandButton cmdOk 
      Caption         =   "Ok"
      Default         =   -1  'True
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   8040
      TabIndex        =   2
      Top             =   8640
      Width           =   2500
   End
   Begin VB.CommandButton cmdExit 
      Caption         =   "Exit"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   11280
      TabIndex        =   0
      Top             =   8640
      Width           =   2500
   End
End
Attribute VB_Name = "frmAdvStuSrch"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public flag As Boolean
Public Del_Str As String

Private Sub chkBa_Click()
    If chkBa.Value = 1 Then
        txtBa.Enabled = True
        txtBa.BackColor = &H80000005
    Else
        txtBa.Enabled = False
        txtBa.BackColor = &H80000011
        txtBa.Text = ""
    End If
End Sub

Private Sub chkBr_Click()
    If chkBr.Value = 1 Then
        cmbBr.Enabled = True
        cmbBr.BackColor = &H80000005
    Else
        cmbBr.Enabled = False
        cmbBr.BackColor = &H80000011
        cmbBr.Text = ""
    End If
End Sub

Private Sub chkName_Click()
    If chkName.Value = 1 Then
        txtName.Enabled = True
        txtName.BackColor = &H80000005
    Else
        txtName.Enabled = False
        txtName.BackColor = &H80000011
        txtName.Text = ""
    End If
End Sub

Private Sub chkNo_Click()
    If chkNo.Value = 1 Then
        txtNo.Enabled = True
        txtNo.BackColor = &H80000005
    Else
        txtNo.Enabled = False
        txtNo.BackColor = &H80000011
        txtNo.Text = ""
    End If
End Sub

Private Sub chkSem_Click()
    If chkSem.Value = 1 Then
        txtSem.Enabled = True
        txtSem.BackColor = &H80000005
    Else
        txtSem.Enabled = False
        txtSem.BackColor = &H80000011
        txtSem.Text = ""
    End If
End Sub


Private Sub cmdDel_Click()
    If chkNo.Value = 1 Then
        MsgBox "Uncheck  Login Times. This is not a valid for delete action", vbInformation, "Error Delete"
        Exit Sub
    End If
    If Del_Str <> "" Then
        If (MsgBox("Are You Sure?", vbYesNo + vbQuestion, "Confirm Deletion") = vbYes) Then
            ModConnect.Records_Close
            ModConnect.Rs.Open "select reg_no from student where " + Del_Str, ModConnect.Conn, adOpenForwardOnly
            ModConnect.Recs.Open "select * from password", ModConnect.Conn, adOpenDynamic
            While ModConnect.Rs.EOF = False
                Stg = "delete password where student_id = '" + Rs(0) + "'"
                ModConnect.Conn.Execute (Stg)
                ModConnect.Rs.MoveNext
            Wend
            Stg = "delete student where " + Del_Str
            ModConnect.Conn.Execute (Stg)
            cmdDel.Visible = False
            Command1.Visible = False
            MsgBox "Selected Group Deleted", vbInformation
        End If
    End If
    ModConnect.Records_Close
    Call ModFun.Combo_Fill(cmbBr, "student", "branch", "branch")
End Sub

Private Sub CmdExit_Click()
    Unload Me
    Load frmDisplayStudent
    frmDisplayStudent.Show 1
End Sub

Private Sub cmdOK_Click()
    flag = True
    If Trim(txtName.Text) <> "" Then
        Name1 = UCase(Trim(txtName.Text))
        Stg = "name like '" + Name1 + "%'"
    End If
    If Trim(txtBa.Text) <> "" Then
        Ba = UCase(Trim(txtBa.Text))
        If Stg <> "" Then
            Stg = Stg + "and"
        End If
        Stg = Stg + " batch = '" + Ba + "'"
    End If
    If cmbBr.Text <> "" Then
        If Stg <> "" Then
            Stg = Stg + "and"
        End If
        Stg = Stg + " branch = '" + cmbBr.Text + "'"
    End If
    If Trim(txtSem.Text) <> "" Then
        Sem = Trim(txtSem.Text)
        If Stg <> "" Then
            Stg = Stg + "and"
        End If
        Stg = Stg + " sem = to_number('" + Sem + "')"
    End If
    
'   For use in Delete function
    Del_Str = Stg
    
    If Trim(txtNo.Text) <> "" Then
        No1 = Trim(txtNo.Text)
        If Stg <> "" Then
            Stg = Stg + " and "
        End If
        Stg = Stg + "login_times = to_number(" + No1 + ")"
    End If
    If Stg = "" Then
        Exit Sub
    End If
    sample = "create or replace view Stu_View as select name,reg_no,sem,batch,branch,login_times From student, Password where student.reg_no = password.student_id"
    Conn.Execute (sample)
    
    stg2 = "create or replace view temp as select * from stu_view where " + Stg
    Conn.Execute (stg2)
    ModConnect.Records_Close
    
    stg1 = "select * from temp where " + Stg
    ModConnect.Rs.Open stg1, ModConnect.Conn, adOpenKeyset, adLockPessimistic
    'ModConnect.Rs.Open stg1, ModConnect.Conn, adOpenKeyset, adLockPessimistic
    
    
    'ModConnect.Conn.Execute (stg2)
    ModConnect.Conn.Execute (stg1)
    If Not ModConnect.Rs.EOF Then
        Set DataGridStud.DataSource = ModConnect.Rs
        Command1.Visible = True
        cmdDel.Visible = True
    Else
        Command1.Visible = False
        cmdDel.Visible = False
        MsgBox "No records", vbInformation + vbDefaultButton2, "Search Result"
    End If
End Sub

Private Sub Command1_Click()
If flag = True Then
    On Error Resume Next
    LabData.LabConn.Open
    LabData.View_Student
    Query_Student.Refresh
    Query_Student.Show 1
    LabData.LabConn.Close
End If
End Sub


Private Sub Form_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Me.Refresh
End Sub
Private Sub Form_Load()
    Call ModConnect.Connect
    Call Clear_
    Call ModFun.Combo_Fill(cmbBr, "student", "branch", "branch")
End Sub

Public Sub Clear_()
    chkName.Value = 0
    chkBa.Value = 0
    chkBr.Value = 0
    chkSem.Value = 0
    chkNo.Value = 0
    txtName.Text = ""
    txtBa.Text = ""
'    cmbBr.Text = ""
    txtNo.Text = ""
    txtSem.Text = ""
    txtName.Enabled = False
    txtBa.Enabled = False
    cmbBr.Enabled = False
    txtNo.Enabled = False
    txtSem.Enabled = False
    txtBa.BackColor = &H80000011
    cmbBr.BackColor = &H80000011
    txtNo.BackColor = &H80000011
    txtName.BackColor = &H80000011
    txtSem.BackColor = &H80000011
End Sub

Private Sub Form_Terminate()
        ModConnect.Records_Close
End Sub

Private Sub Form_Unload(Cancel As Integer)
    ModConnect.Records_Close
End Sub

Private Sub txtNo_KeyPress(KeyAscii As Integer)
Dim Ch As String * 1
    Ch = Chr$(KeyAscii)
    Select Case Ch
        Case 0 To 999:
        Case vbBack:
        Case Else: KeyAscii = 0
    End Select
End Sub

Private Sub txtSem_KeyPress(KeyAscii As Integer)
Dim Ch As String * 1
    Ch = Chr$(KeyAscii)
    Select Case Ch
        Case 1 To 8:
        Case vbBack:
        Case Else: KeyAscii = 0
    End Select
End Sub
