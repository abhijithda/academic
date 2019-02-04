VERSION 5.00
Object = "{E7D6E204-3EEC-4D89-8955-8236E52B25C0}#1.0#0"; "TCI_TOOLS.OCX"
Begin VB.Form frmAddstudent 
   BackColor       =   &H008080FF&
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Add Details of the student"
   ClientHeight    =   6270
   ClientLeft      =   4275
   ClientTop       =   2220
   ClientWidth     =   8850
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6270
   ScaleWidth      =   8850
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Tag             =   "aa"
   Begin TCI_tools.Splabel Splabel1 
      Height          =   570
      Left            =   3120
      TabIndex        =   14
      Top             =   360
      Width           =   2625
      _ExtentX        =   4630
      _ExtentY        =   1005
      CAPTION         =   "Add Student"
      BACKCOLOUR      =   -2147483633
      TEXTBACKCOLOUR  =   12640511
      BACKSTYLE       =   1
      TEXTFORECOLOUR  =   7088128
      PLAY            =   -1  'True
      INTERVAL1       =   175
      INTERVAL2       =   10
      BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin VB.TextBox Text5 
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
      Left            =   4080
      MaxLength       =   5
      TabIndex        =   12
      Text            =   "Text1"
      Top             =   3960
      Width           =   3000
   End
   Begin VB.TextBox Text3 
      BeginProperty DataFormat 
         Type            =   0
         Format          =   "# Sem"
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   1033
         SubFormatType   =   0
      EndProperty
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
      Left            =   4080
      MaxLength       =   1
      TabIndex        =   11
      Text            =   "Text1"
      Top             =   3000
      Width           =   3000
   End
   Begin VB.TextBox Text2 
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
      Left            =   4080
      MaxLength       =   10
      TabIndex        =   10
      Text            =   "Text1"
      Top             =   2520
      Width           =   3000
   End
   Begin VB.TextBox Text1 
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
      Left            =   4080
      MaxLength       =   20
      TabIndex        =   9
      Text            =   "Text1"
      Top             =   2040
      Width           =   3000
   End
   Begin VB.CommandButton cmdclear 
      Caption         =   "C&lear"
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
      Left            =   3840
      TabIndex        =   2
      Top             =   5400
      Width           =   1695
   End
   Begin VB.CommandButton cmdcancel 
      Caption         =   "&Exit"
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
      Left            =   6120
      TabIndex        =   1
      Top             =   5400
      Width           =   1575
   End
   Begin VB.CommandButton cmdadd 
      Caption         =   "&Add"
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
      Left            =   1440
      TabIndex        =   0
      Top             =   5400
      Width           =   1695
   End
   Begin VB.Frame frmstuddetails 
      BackColor       =   &H008080FF&
      Height          =   3735
      Left            =   720
      TabIndex        =   3
      Top             =   1320
      Width           =   7095
      Begin VB.ComboBox cmbBr 
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
         ItemData        =   "frmAddstudent.frx":0000
         Left            =   3360
         List            =   "frmAddstudent.frx":0022
         Sorted          =   -1  'True
         Style           =   2  'Dropdown List
         TabIndex        =   13
         Top             =   2160
         Width           =   2940
      End
      Begin VB.Label lblregister 
         Alignment       =   1  'Right Justify
         BackColor       =   &H008080FF&
         Caption         =   "Register number"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   360
         Left            =   360
         TabIndex        =   7
         Top             =   1200
         Width           =   2100
      End
      Begin VB.Label lblBatchName 
         Alignment       =   1  'Right Justify
         BackColor       =   &H008080FF&
         Caption         =   "Batch name"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   360
         Left            =   360
         TabIndex        =   6
         Top             =   2640
         Width           =   2100
      End
      Begin VB.Label lblBranch 
         Alignment       =   1  'Right Justify
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
         ForeColor       =   &H00000000&
         Height          =   360
         Left            =   360
         TabIndex        =   5
         Top             =   2160
         Width           =   2100
      End
      Begin VB.Label lblSemester 
         Alignment       =   1  'Right Justify
         BackColor       =   &H008080FF&
         Caption         =   "Semester [1-8]"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   360
         Left            =   360
         TabIndex        =   4
         Top             =   1680
         Width           =   2100
      End
      Begin VB.Label lblName 
         Alignment       =   1  'Right Justify
         BackColor       =   &H008080FF&
         Caption         =   "Student Name"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   405
         Left            =   360
         TabIndex        =   8
         Top             =   720
         Width           =   2100
      End
   End
End
Attribute VB_Name = "frmAddstudent"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim Br_Cnt As Integer
Public Sub cmbBr_KeyPress(KeyAscii As Integer)
    Dim Ch As String * 1
    Ch = Chr$(KeyAscii)
    Select Case Ch
        Case vbBack:
                        Br_Cnt = Br_Cnt - 1
        Case Else:
                        If Br_Cnt >= 5 Then
                            KeyAscii = 0
                            MsgBox "Branch Should be of 5 letters", vbInformation
                        Exit Sub
                        End If
                        Br_Cnt = Br_Cnt + 1
    End Select
End Sub

Private Sub cmdAdd_Click()
    
    Reg = UCase(Trim(Text2.Text))
    Nam = UCase(Trim(Text1.Text))
    Sem = UCase(Trim(Text3.Text))
    Batch = UCase(Trim(Text5.Text))
    Branch = cmbBr.Text
    
    If Reg = "" Or Nam = "" Or Sem = "" Or Batch = "" Or Branch = "" Then
        MsgBox "Enter All the fields", vbInformation + vbOKOnly, "Details Incomplete"
        Exit Sub
    End If
        
'    If strlen(branch) Then
'        MsgBox "Branch Should be of 5 characters", vbInformation, "Invalied length"
'        Exit Sub
'    End If
    Call ModConnect.Records_Close
    ModConnect.Rs.Open "select reg_no from student where reg_no='" + Reg + "'", ModConnect.Conn, adOpenDynamic
    
    If ModConnect.Rs.EOF Then
        Stg = "insert into student (reg_no,name,sem,batch,branch)values ('" + Reg + "','" + Nam + "','" + Sem + "','" + Batch + "','" + Branch + "')"
        ModConnect.Conn.Execute (Stg)
        ModConnect.Recs.Open "select * from password where student_id = '" + Reg + "'", ModConnect.Conn, adOpenDynamic
        ModConnect.Conn.Execute ("insert into password (student_id,passwd) values ('" + Reg + "','student')")
        MsgBox Reg + " : Added ", vbInformation + vbOKOnly, "Student Added"
    Else
        MsgBox "Error : " + Reg + " exists.", vbCritical + vbOKOnly, "Add Failure"
    End If
    Call Records_Close
    Br_Cnt = 0
End Sub

Private Sub cmdCancel_Click()
    Unload Me
    frmAdministrator.Show
End Sub

Private Sub cmdClear_Click()
    Call Clear
End Sub

Public Sub Clear()
    Text1.Text = ""   ' Clear text box.
    Text2.Text = ""
    Text3.Text = ""
    cmbBr.ListIndex = -1
    Text5.Text = ""
    Br_Cnt = 0
End Sub

Private Sub Form_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Me.Refresh
End Sub

Private Sub Form_Load()
    Call ModConnect.Connect
'    Call Combo_Br_Fill(cmbBr, "student", "branch", "branch")
    Call Clear
End Sub

Private Sub Text3_KeyPress(KeyAscii As Integer)
    Dim Ch As String * 1
    Ch = Chr$(KeyAscii)
    Select Case Ch
        Case 1 To 8:
        Case vbBack:
        Case Else: KeyAscii = 0
    End Select
End Sub

Private Sub Combo_Br_Fill(cmbID As ComboBox, table_name As String, col As String, ord_name As String)
    Dim Brn_Str As String
    Dim Index As Integer
    Call ModConnect.Records_Close
    Brn_Str = ""
    While cmbID.ListCount <> Index
        cmbID.ListIndex = cmbID.ListIndex + 1
        If Brn_Str = "" Then
            Brn_Str = "'" + cmbID.Text + "'"
        Else
            Brn_Str = Brn_Str + "," + "'" + cmbID.Text + "'"
        End If
        Index = Index + 1
    Wend
    stg_12 = "select distinct " + col + " from  " + table_name + "  where " + col + " not in (" + Brn_Str + ")  order by " + ord_name + ""
    ModConnect.Rs.Open stg_12, ModConnect.Conn, adOpenForwardOnly
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

