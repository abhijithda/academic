VERSION 5.00
Object = "{E7D6E204-3EEC-4D89-8955-8236E52B25C0}#1.0#0"; "TCI_TOOLS.OCX"
Begin VB.Form frmAddLab 
   BackColor       =   &H008080FF&
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Create Lab"
   ClientHeight    =   5595
   ClientLeft      =   3330
   ClientTop       =   3180
   ClientWidth     =   7410
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5595
   ScaleWidth      =   7410
   ShowInTaskbar   =   0   'False
   Begin TCI_tools.Splabel Splabel1 
      Height          =   510
      Left            =   2235
      TabIndex        =   7
      Top             =   600
      Width           =   2940
      _ExtentX        =   5186
      _ExtentY        =   900
      CAPTION         =   "Create New Lab"
      BACKCOLOUR      =   -2147483633
      TEXTBACKCOLOUR  =   12640511
      BACKSTYLE       =   1
      TEXTFORECOLOUR  =   7088128
      PLAY            =   -1  'True
      INTERVAL1       =   175
      INTERVAL2       =   10
      BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Arial"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin VB.CommandButton cmdClear 
      Caption         =   "&Clear"
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
      Left            =   480
      TabIndex        =   6
      Top             =   3720
      Width           =   1815
   End
   Begin VB.CommandButton cmdAdd 
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
      Left            =   2880
      TabIndex        =   5
      Top             =   3720
      Width           =   1575
   End
   Begin VB.CommandButton cmdCancel 
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
      Left            =   5160
      TabIndex        =   4
      Top             =   3720
      Width           =   1695
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
      Left            =   3720
      MaxLength       =   10
      TabIndex        =   1
      Top             =   1920
      Width           =   3000
   End
   Begin VB.TextBox txtDept 
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
      Left            =   3720
      MaxLength       =   5
      TabIndex        =   0
      Top             =   2520
      Width           =   3000
   End
   Begin VB.Label lblName 
      Alignment       =   2  'Center
      BackColor       =   &H00E0E0E0&
      Caption         =   "Lab Name"
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
      Left            =   840
      TabIndex        =   3
      Top             =   1920
      Width           =   2415
   End
   Begin VB.Label Label2 
      Alignment       =   2  'Center
      BackColor       =   &H00E0E0E0&
      Caption         =   "Department"
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
      Left            =   840
      TabIndex        =   2
      Top             =   2520
      Width           =   2415
   End
End
Attribute VB_Name = "frmAddLab"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdAdd_Click()
    Lab = UCase(Trim(txtName.Text))
    dept = UCase(Trim(txtDept.Text))
    If Lab = "" Or dept = "" Then
        MsgBox " Enter all Fields", vbInformation + vbMsgBoxSetForeground, "Error Input"
        Exit Sub
    End If
    Rs.Open "select lab_name from lab where lab_name='" + Lab + "'", Conn, adOpenDynamic
    If Rs.EOF Then
        Conn.Execute ("insert into lab (lab_name,dept) values ('" + Lab + "','" + dept + "')")
        MsgBox "New lab created", vbOKOnly, Created
    Else
        MsgBox "Lab by the specified name already exists", vbInformation + vbOKOnly, "Error Lab Creation"
    End If
    Rs.Close
    Call Clear_
End Sub

Private Sub cmdCancel_Click()
    Unload Me
End Sub

Private Sub Clear_()
    txtName.Text = ""
    txtDept.Text = ""
End Sub

Private Sub cmdClear_Click()
    Call Clear_
End Sub

Private Sub Form_Load()
    Call ModConnect.Connect
    Call Clear_
End Sub
