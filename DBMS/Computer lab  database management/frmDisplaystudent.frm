VERSION 5.00
Object = "{E7D6E204-3EEC-4D89-8955-8236E52B25C0}#1.0#0"; "TCI_TOOLS.OCX"
Begin VB.Form frmDisplayStudent 
   BackColor       =   &H008080FF&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Details of the student"
   ClientHeight    =   9045
   ClientLeft      =   2160
   ClientTop       =   1020
   ClientWidth     =   10875
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   9045
   ScaleWidth      =   10875
   StartUpPosition =   2  'CenterScreen
   Tag             =   "aa"
   Begin TCI_tools.SplabelB SplabelB1 
      Height          =   420
      Left            =   240
      TabIndex        =   24
      Top             =   360
      Width           =   10110
      _ExtentX        =   17833
      _ExtentY        =   741
      CAPTION         =   "[ Enter / Select ]  Student's Register no. on which you want  information."
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
   Begin VB.CommandButton CmdRAll 
      Caption         =   "Report All"
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
      Left            =   240
      TabIndex        =   23
      Top             =   8280
      Width           =   2055
   End
   Begin VB.CommandButton cmdAdvSearchStud 
      BackColor       =   &H80000010&
      Caption         =   "Advanced Search"
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
      Left            =   7560
      TabIndex        =   22
      Top             =   2640
      Width           =   3000
   End
   Begin VB.CommandButton disp_report 
      Caption         =   "Report Current"
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
      Left            =   2520
      TabIndex        =   21
      Top             =   8280
      Width           =   2055
   End
   Begin VB.ComboBox cmbReg 
      CausesValidation=   0   'False
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   4200
      TabIndex        =   20
      Top             =   2040
      Width           =   3015
   End
   Begin VB.ComboBox cmbName 
      CausesValidation=   0   'False
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   4200
      TabIndex        =   19
      Top             =   2640
      Visible         =   0   'False
      Width           =   3015
   End
   Begin VB.OptionButton Option1 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Select Student Name"
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
      Index           =   2
      Left            =   480
      TabIndex        =   18
      Top             =   2640
      Visible         =   0   'False
      Width           =   3375
   End
   Begin VB.OptionButton Option1 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Select Register Number"
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
      Index           =   1
      Left            =   480
      TabIndex        =   17
      Top             =   2040
      Width           =   3375
   End
   Begin VB.TextBox txtReg 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   4200
      MaxLength       =   10
      TabIndex        =   16
      Top             =   1440
      Width           =   3000
   End
   Begin VB.OptionButton Option1 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Enter Register Number"
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
      Index           =   0
      Left            =   480
      TabIndex        =   15
      Top             =   1440
      Value           =   -1  'True
      Width           =   3375
   End
   Begin VB.CommandButton cmdFind 
      Caption         =   "&Find"
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
      Left            =   4920
      TabIndex        =   14
      Top             =   8280
      Width           =   2055
   End
   Begin VB.CommandButton cmdok 
      Caption         =   "&Ok"
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
      Left            =   7200
      TabIndex        =   0
      Top             =   8280
      Width           =   2055
   End
   Begin VB.Frame frmstuddetails 
      BackColor       =   &H8000000B&
      Caption         =   "Display of Students Details"
      Height          =   3975
      Left            =   2040
      TabIndex        =   1
      Top             =   3480
      Width           =   7095
      Begin VB.TextBox txtBatchName 
         Appearance      =   0  'Flat
         CausesValidation=   0   'False
         DataField       =   "BRANCH"
         DataSource      =   "Adodc1"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   385
         Index           =   7
         Left            =   3000
         Locked          =   -1  'True
         TabIndex        =   13
         ToolTipText     =   " Students Batch Name"
         Top             =   2640
         Width           =   3255
      End
      Begin VB.TextBox txtHrs 
         Appearance      =   0  'Flat
         CausesValidation=   0   'False
         DataField       =   "LOGIN_TIMES"
         DataSource      =   "Adodc1"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   385
         Index           =   6
         Left            =   3000
         Locked          =   -1  'True
         TabIndex        =   12
         Tag             =   "$"
         ToolTipText     =   "  Students Total no. of hours worked in the lab."
         Top             =   3120
         Width           =   3255
      End
      Begin VB.TextBox txtSem 
         Appearance      =   0  'Flat
         CausesValidation=   0   'False
         DataField       =   "SEM"
         DataSource      =   "Adodc1"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   385
         Index           =   3
         Left            =   3000
         Locked          =   -1  'True
         TabIndex        =   11
         ToolTipText     =   " Student's Semester"
         Top             =   1680
         Width           =   3255
      End
      Begin VB.TextBox txtBranch 
         Appearance      =   0  'Flat
         CausesValidation=   0   'False
         DataField       =   "BRANCH"
         DataSource      =   "Adodc1"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   385
         Index           =   2
         Left            =   3000
         Locked          =   -1  'True
         TabIndex        =   10
         ToolTipText     =   " Student's Branch"
         Top             =   2160
         Width           =   3255
      End
      Begin VB.TextBox txtRegister 
         Appearance      =   0  'Flat
         CausesValidation=   0   'False
         DataField       =   "REG_NO"
         DataSource      =   "Adodc1"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   385
         Index           =   1
         Left            =   3000
         Locked          =   -1  'True
         TabIndex        =   5
         ToolTipText     =   " Student's Register Number"
         Top             =   1200
         Width           =   3255
      End
      Begin VB.TextBox txtName 
         Appearance      =   0  'Flat
         CausesValidation=   0   'False
         DataField       =   "NAME"
         DataSource      =   "Adodc1"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   385
         Index           =   0
         Left            =   3000
         Locked          =   -1  'True
         TabIndex        =   3
         ToolTipText     =   " Students Name"
         Top             =   720
         Width           =   3255
      End
      Begin VB.Label lblTothrs 
         Alignment       =   1  'Right Justify
         BackColor       =   &H8000000B&
         Caption         =   "Number of Login's"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Left            =   240
         TabIndex        =   9
         Top             =   3120
         Width           =   2460
         WordWrap        =   -1  'True
      End
      Begin VB.Label Label4 
         Alignment       =   1  'Right Justify
         BackColor       =   &H8000000B&
         Caption         =   "&Semester"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Left            =   360
         TabIndex        =   8
         Top             =   1680
         Width           =   2100
      End
      Begin VB.Label Label3 
         Alignment       =   1  'Right Justify
         BackColor       =   &H8000000B&
         Caption         =   "&Branch"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Left            =   360
         TabIndex        =   7
         Top             =   2160
         Width           =   2100
      End
      Begin VB.Label Label2 
         Alignment       =   1  'Right Justify
         BackColor       =   &H8000000B&
         Caption         =   "Batch na&me"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Left            =   360
         TabIndex        =   6
         Top             =   2640
         Width           =   2100
      End
      Begin VB.Label lblregister 
         Alignment       =   1  'Right Justify
         BackColor       =   &H8000000B&
         Caption         =   "&Register number"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Left            =   360
         TabIndex        =   4
         Top             =   1200
         Width           =   2100
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         BackColor       =   &H8000000B&
         Caption         =   "&Name of Student"
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
         Left            =   120
         TabIndex        =   2
         Top             =   720
         Width           =   2295
      End
   End
End
Attribute VB_Name = "frmDisplayStudent"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public sel As Integer
Public Reg As String
Public StrStu As String

Private Sub cmbName_Click()
    
    Call cmdFind_Click
End Sub

Private Sub cmbReg_Click()
  
  Call cmdFind_Click
End Sub

Private Sub cmdAdvSearchStud_Click()
      Unload Me
    'Call Dis_able
    frmAdvStuSrch.Show 1, frmAdministrator
    ModConnect.Records_Close
    Conn.Execute "COMMIT"
    'Call Dis_able
   'Call Combo_Drop
End Sub

Private Sub cmdFind_Click()
    If sel = 0 Then
        Reg = Trim(txtReg.Text)
    ElseIf sel = 1 Then
        Reg = cmbReg.Text
    ElseIf sel = 2 Then
        Name1 = cmbName.Text
    End If
    If Reg = "" And Name1 = "" Then
        Exit Sub
    End If
    StrStu = Reg
    If ModConnect.Rs.State = 1 Then
        Call Records_Close
    End If
    ModConnect.Rs.Open "select * from stu_view where reg_no = '" + Reg + "' or name='" + Name1 + "'", ModConnect.Conn, adOpenForwardOnly, adLockReadOnly
    If ModConnect.Rs.EOF Then
        Dim Msg As Variant
        Msg = MsgBox(Reg + " not present in the list.", vbOKOnly, "Search Failure")
        Call Clear
        ModConnect.Records_Close
        Exit Sub
    End If
    If Recs.State = 1 Then
        Recs.Close
    End If
    
    
    Recs.Open "select login_times from password where student_id = '" + Reg + "'", Conn, adOpenDynamic
    txtRegister(1).Text = ModConnect.Rs(1)
    txtName(0).Text = ModConnect.Rs(0)
    txtSem(3).Text = ModConnect.Rs(2)
    txtBatchName(7).Text = ModConnect.Rs(3)
    txtBranch(2).Text = ModConnect.Rs(4)
    txtHrs(6).Text = ModConnect.Recs(0)
    ModConnect.Rs.Close
End Sub

Private Sub cmdOK_Click()
    Unload Me
    On Error Resume Next
    frmAdministrator.Show
End Sub

Private Sub CmdRAll_Click()
    On Error Resume Next
    LabData.LabConn.Open
'    If stg <> "" Then
        Dim str As String
        str = "create or replace view Stu_View as select name,reg_no,sem,batch,branch,login_times From student, Password where student.reg_no = password.student_id"
        ModConnect.Conn.Execute (str)
        str = "select * from stu_view"
        ModConnect.Records_Close
        Rs.Open str, Conn, adOpenKeyset
        Conn.Execute (str)
'        DataRepSys.Show 1
'    Else
'        MsgBox "Nothing to display", vbInformation + vbOKOnly, "Report Empty"
'        Exit Sub
'    End If
    LabData.student
    Student_Report.Refresh
    Student_Report.Show 1
    LabData.LabConn.Close
End Sub

Private Sub disp_report_Click()

If frmDisplayStudent.txtRegister(1).Text = "" Then
        Exit Sub
End If
'these statements are used to generate a single student report
    On Error Resume Next
    LabData.LabConn.Open
    STNG = Trim(txtRegister(1).Text)
    LabData.student_sql (STNG)
    SStudent_Report.Refresh
    SStudent_Report.Show 1
    LabData.LabConn.Close

End Sub



Private Sub Form_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Me.Refresh
End Sub

Private Sub Form_Load()
    Call ModConnect.Connect
    Call Combo_Drop
    Call Clear
    Call Dis_able
    'Call Option1_Click(0)
End Sub
Public Sub Clear()
    txtName(0).Text = ""    ' Clear text box.
    txtRegister(1).Text = ""
    txtBatchName(7).Text = ""
    txtBranch(2).Text = ""
    txtHrs(6).Text = ""
    txtSem(3).Text = ""
    txtHrs(6).Text = ""
    cmbReg.Text = ""
    cmbReg.ListIndex = -1
    Reg = ""
    cmbName.Text = ""
    cmbName.ListIndex = -1
End Sub
Public Sub Combo_Drop()
    Dim Ar_ind1 As Integer
    Dim Ar_ind2 As Integer
    ModConnect.Recs.Open "Select reg_no from student order by reg_no", ModConnect.Conn, adOpenForwardOnly
    stg1 = "Select reg_no from student order by reg_no"
    ModConnect.Rs.Open "Select distinct name from student order by name", ModConnect.Conn, adOpenForwardOnly
    stg2 = "Select name from student order by name"
    While ModConnect.Recs.EOF = False
        Ar_ind1 = Ar_ind1 + 1
        cmbReg.AddItem ModConnect.Recs(0)
        cmbReg.ItemData(cmbReg.NewIndex) = Ar_ind1
        ModConnect.Conn.Execute (stg1)
        ModConnect.Recs.MoveNext
    Wend
    While ModConnect.Rs.EOF = False
        Ar_ind2 = Ar_ind2 + 1
        cmbName.AddItem ModConnect.Rs(0)
        cmbName.ItemData(cmbName.NewIndex) = Ar_ind2
        ModConnect.Conn.Execute (stg2)
        ModConnect.Rs.MoveNext
    Wend
    
    Call ModConnect.Records_Close
End Sub

Private Sub Option1_Click(Index As Integer)
    If Index = 0 Then
        sel = 0
        Call Dis_able
        txtReg.Enabled = True
        txtReg.BackColor = &H80000005
    ElseIf Index = 1 Then
        sel = 1
        Call Dis_able
        cmbReg.Enabled = True
        cmbReg.BackColor = &H80000005
    Else
        sel = 2
        Call Dis_able
        cmbName.Enabled = True
        cmbName.BackColor = &H80000005
    End If
End Sub

Public Sub Dis_able()
    txtReg.Text = ""
    txtReg.Enabled = False
    txtReg.BackColor = &H80000011
    cmbReg.Text = ""
    cmbReg.Enabled = False
    cmbReg.BackColor = &H80000011
    cmbName.Text = ""
    cmbName.Enabled = False
    cmbName.BackColor = &H80000011
End Sub

