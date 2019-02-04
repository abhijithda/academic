VERSION 5.00
Object = "{E7D6E204-3EEC-4D89-8955-8236E52B25C0}#1.0#0"; "TCI_TOOLS.OCX"
Begin VB.Form frmMyAcc 
   BackColor       =   &H000000C0&
   Caption         =   "My Account "
   ClientHeight    =   11010
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   15240
   ForeColor       =   &H000000FF&
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   Picture         =   "frmMyAcc.frx":0000
   ScaleHeight     =   11010
   ScaleWidth      =   15240
   WindowState     =   2  'Maximized
   Begin TCI_tools.Splabel SplblAcc 
      Height          =   630
      Left            =   3000
      TabIndex        =   1
      Top             =   840
      Width           =   2985
      _ExtentX        =   5265
      _ExtentY        =   1111
      CAPTION         =   "My Account"
      BACKCOLOUR      =   12632319
      TEXTBACKCOLOUR  =   65280
      BACKSTYLE       =   0
      TEXTFORECOLOUR  =   12582912
      PLAY            =   -1  'True
      INTERVAL1       =   175
      INTERVAL2       =   10
      BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Arial"
         Size            =   24
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin VB.CommandButton cmdClose 
      Caption         =   "Close"
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
      Left            =   10440
      TabIndex        =   0
      Top             =   9000
      Width           =   1575
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      BackStyle       =   0  'Transparent
      Caption         =   "Name of Student"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   495
      Left            =   735
      TabIndex        =   13
      Top             =   3480
      Width           =   4995
   End
   Begin VB.Label lblregister 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      BackStyle       =   0  'Transparent
      Caption         =   "Register number"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   495
      Left            =   735
      TabIndex        =   12
      Top             =   2760
      Width           =   4995
   End
   Begin VB.Label Label2 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      BackStyle       =   0  'Transparent
      Caption         =   "Batch name"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   495
      Left            =   735
      TabIndex        =   11
      Top             =   5520
      Width           =   4995
   End
   Begin VB.Label Label3 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      BackStyle       =   0  'Transparent
      Caption         =   "Branch"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   495
      Left            =   720
      TabIndex        =   10
      Top             =   4920
      Width           =   4995
   End
   Begin VB.Label Label4 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      BackStyle       =   0  'Transparent
      Caption         =   "Semester"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   495
      Left            =   735
      TabIndex        =   9
      Top             =   4200
      Width           =   4995
   End
   Begin VB.Label lblTothrs 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      BackStyle       =   0  'Transparent
      Caption         =   "Number of Login's"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   495
      Left            =   735
      TabIndex        =   8
      Top             =   6240
      Width           =   4995
      WordWrap        =   -1  'True
   End
   Begin VB.Label txtTotHrs 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      BackStyle       =   0  'Transparent
      Caption         =   "Number of Login's"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   495
      Left            =   6000
      TabIndex        =   7
      Top             =   6240
      Width           =   4995
      WordWrap        =   -1  'True
   End
   Begin VB.Label txtSem 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      BackStyle       =   0  'Transparent
      Caption         =   "Semester"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   495
      Left            =   6000
      TabIndex        =   6
      Top             =   4200
      Width           =   4995
   End
   Begin VB.Label txtBr 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      BackStyle       =   0  'Transparent
      Caption         =   "Branch"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   495
      Left            =   6000
      TabIndex        =   5
      Top             =   4920
      Width           =   4995
   End
   Begin VB.Label txtBatch 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      BackStyle       =   0  'Transparent
      Caption         =   "Batch name"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   495
      Left            =   6000
      TabIndex        =   4
      Top             =   5520
      Width           =   4995
   End
   Begin VB.Label txtReg 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      BackStyle       =   0  'Transparent
      Caption         =   "Register number"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   495
      Left            =   6000
      TabIndex        =   3
      Top             =   2760
      Width           =   4995
   End
   Begin VB.Label txtName 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFFF&
      BackStyle       =   0  'Transparent
      Caption         =   "Name of Student"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   495
      Left            =   6000
      TabIndex        =   2
      Top             =   3480
      Width           =   4995
   End
End
Attribute VB_Name = "frmMyAcc"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdClose_Click()
    Unload Me
End Sub

Private Sub Form_Load()
'    Call ModConnect.Connect
    SplblAcc.Caption = ModVar.LOGIN_NAME + "'s Account"
    ModConnect.Records_Close
    ModConnect.Rs.Open "Select * from student where reg_no='" + LOGIN_ID + "'", ModConnect.Conn, adOpenDynamic
    Stg = "Select * from student where reg_no='" + LOGIN_ID + "'"
    ModConnect.Conn.Execute (Stg)
'    If ModConnect.Rs.Status = True Then
        txtReg.Caption = ModConnect.Rs(0)
        txtName.Caption = ModConnect.Rs(1)
        txtSem.Caption = ModConnect.Rs(2)
        txtBatch.Caption = ModConnect.Rs(3)
        txtBr.Caption = ModConnect.Rs(4)
    ModConnect.Recs.Open "Select login_times from password where student_id ='" + LOGIN_ID + "'", ModConnect.Conn, adOpenDynamic
    Stg = "Select login_times from password where student_id='" + LOGIN_ID + "'"
    ModConnect.Conn.Execute (Stg)
        txtTotHrs.Caption = ModConnect.Recs(0)
'    Else
'        MsgBox "        Error        ", vbInformation + vbOKOnly, "Error"
'    End If
    ModConnect.Rs.Close
End Sub

