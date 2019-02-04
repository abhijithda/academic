VERSION 5.00
Object = "{E7D6E204-3EEC-4D89-8955-8236E52B25C0}#1.0#0"; "TCI_TOOLS.OCX"
Begin VB.Form frmRemStu 
   BackColor       =   &H008080FF&
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Remove Student"
   ClientHeight    =   7770
   ClientLeft      =   3060
   ClientTop       =   1905
   ClientWidth     =   9705
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   7770
   ScaleWidth      =   9705
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cmdDel 
      Caption         =   "Press here for Group Deletion"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   855
      Left            =   7440
      TabIndex        =   18
      Top             =   360
      Width           =   2145
   End
   Begin TCI_tools.Splabel Splabel2 
      Height          =   600
      Left            =   3135
      TabIndex        =   17
      Top             =   480
      Width           =   3435
      _ExtentX        =   6059
      _ExtentY        =   1058
      CAPTION         =   "Student Details"
      BACKCOLOUR      =   -2147483633
      TEXTBACKCOLOUR  =   12640511
      BACKSTYLE       =   1
      TEXTFORECOLOUR  =   7088128
      PLAY            =   -1  'True
      INTERVAL1       =   175
      INTERVAL2       =   10
      BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Arial"
         Size            =   21.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin VB.Frame frmstuddetails 
      BackColor       =   &H8000000B&
      Caption         =   "Display of Students Details"
      Height          =   4335
      Left            =   1065
      TabIndex        =   4
      Top             =   2280
      Width           =   7575
      Begin VB.TextBox txtBatchName 
         Appearance      =   0  'Flat
         DataField       =   "BATCH_NAME"
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
         TabIndex        =   10
         ToolTipText     =   " Students Batch Name"
         Top             =   2640
         Width           =   3550
      End
      Begin VB.TextBox txtHrs 
         Appearance      =   0  'Flat
         DataField       =   "TOT_HRS_WORKED"
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
         TabIndex        =   9
         Tag             =   "$"
         ToolTipText     =   "  Students Total no. of hours worked in the lab during working hrs."
         Top             =   3120
         Width           =   3550
      End
      Begin VB.TextBox txtSem 
         Appearance      =   0  'Flat
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
         TabIndex        =   8
         ToolTipText     =   " Student's Semester"
         Top             =   1680
         Width           =   3550
      End
      Begin VB.TextBox txtBranch 
         Appearance      =   0  'Flat
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
         TabIndex        =   7
         ToolTipText     =   " Student's Branch"
         Top             =   2160
         Width           =   3550
      End
      Begin VB.TextBox txtRegister 
         Appearance      =   0  'Flat
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
         TabIndex        =   6
         ToolTipText     =   " Student's Register Number"
         Top             =   1200
         Width           =   3550
      End
      Begin VB.TextBox txtName 
         Appearance      =   0  'Flat
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
         TabIndex        =   5
         ToolTipText     =   " Students Name"
         Top             =   720
         Width           =   3550
      End
      Begin VB.Label lblTothrs 
         Alignment       =   1  'Right Justify
         BackColor       =   &H8000000B&
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
         Height          =   360
         Left            =   240
         TabIndex        =   16
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
         TabIndex        =   15
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
         TabIndex        =   14
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
         TabIndex        =   13
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
         TabIndex        =   12
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
         TabIndex        =   11
         Top             =   720
         Width           =   2295
      End
   End
   Begin VB.CommandButton Command1 
      Caption         =   "E&xit"
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
      Left            =   6480
      MaskColor       =   &H00C0FFFF&
      TabIndex        =   3
      Top             =   6960
      Width           =   2535
   End
   Begin VB.CommandButton cmdRemove 
      Caption         =   "&Remove Student "
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
      Left            =   3360
      MaskColor       =   &H00C0FFFF&
      TabIndex        =   2
      Top             =   6960
      Width           =   2535
   End
   Begin VB.TextBox txtReg 
      DataField       =   "REG_NO"
      DataSource      =   "Adodc1"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   420
      Index           =   1
      Left            =   5040
      MaxLength       =   10
      TabIndex        =   0
      ToolTipText     =   " Student's Register Number"
      Top             =   1560
      Width           =   3255
   End
   Begin VB.Label lblRemove 
      Alignment       =   2  'Center
      BackColor       =   &H008080FF&
      Caption         =   "Enter the Register Number :"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   480
      Left            =   330
      TabIndex        =   1
      Top             =   1560
      Width           =   5385
      WordWrap        =   -1  'True
   End
End
Attribute VB_Name = "frmRemStu"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False


Public Sub Clear_Fields()
    txtName(0).Text = ""
    txtRegister(1).Text = ""
    txtBatchName(7).Text = ""
    txtSem(3).Text = ""
    txtHrs(6).Text = ""
    txtBranch(2).Text = ""
End Sub

Private Sub cmdDel_Click()
    frmAdvStuSrch.Show 1
End Sub

Private Sub cmdRemove_Click()
    Clear_Fields
    Dim Msg As Variant
    Call ModConnect.Records_Close
    Call ModConnect.Connect
    ModConnect.Rs.Open "select * from student where reg_no = '" + txtReg(1).Text + "' ", ModConnect.Conn, adOpenKeyset, adLockOptimistic
    If ModConnect.Rs.EOF Then
        Msg = MsgBox(txtReg(1).Text + " not present in the list.", vbinfo + vbOKOnly, "Search Failure")
        ModConnect.Rs.Close
        Exit Sub
    End If
     
    txtRegister(1).Text = ModConnect.Rs(0)
    txtName(0).Text = ModConnect.Rs(1)
    If IsNull(ModConnect.Rs(2)) Then
        txtSem(3).Text = ""
    Else
        txtSem(3).Text = ModConnect.Rs(2)
    End If
    
    If IsNull(ModConnect.Rs(3)) Then
        txtBatchName(7).Text = ""
    Else
        txtBatchName(7).Text = ModConnect.Rs(3)
    End If
    If IsNull(ModConnect.Rs(4)) Then
        txtBranch(2).Text = ""
    Else
        txtBranch(2).Text = ModConnect.Rs(4)
    End If
    ModConnect.Recs.Open "select login_times from password where student_id = '" + txtReg(1).Text + "' ", ModConnect.Conn, adOpenKeyset, adLockOptimistic
    txtHrs(6).Text = ModConnect.Recs(0)
    ModConnect.Records_Close
        
    Msg = MsgBox("Remove student " + txtReg(1).Text + " from the database?", vbYesNo, "Remove confirmation")
    If Msg = vbYes Then
        ModConnect.Rs.Open "select reg_no from student where reg_no = '" + txtReg(1).Text + "'", ModConnect.Conn, adOpenDynamic
        Stg = "delete password where student_id='" + txtRegister(1).Text + "'"
        ModConnect.Conn.Execute (Stg)
        Stg = "delete  student where reg_no='" + txtRegister(1).Text + "'"
        ModConnect.Conn.Execute (Stg)
        Msg = MsgBox("Student " + txtReg(1).Text + " removed from the database.", vbinfo + vbOKOnly, "Student Removed")
        Clear_Fields
    End If
    txtReg(1).Text = ""
    Call ModConnect.Records_Close
End Sub



Private Sub Command1_Click()
    Unload Me
End Sub
Private Sub Form_Load()
    txtReg(1).Text = ""
    Clear_Fields
End Sub



Private Sub Splabel1_DragDrop(Source As Control, X As Single, Y As Single)

End Sub
