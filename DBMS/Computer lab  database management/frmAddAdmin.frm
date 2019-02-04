VERSION 5.00
Object = "{E7D6E204-3EEC-4D89-8955-8236E52B25C0}#1.0#0"; "TCI_TOOLS.OCX"
Begin VB.Form frmAddAdmin 
   BackColor       =   &H008080FF&
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Add Administrator"
   ClientHeight    =   6660
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   7560
   FillColor       =   &H8000000C&
   ForeColor       =   &H00FF80FF&
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6660
   ScaleWidth      =   7560
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin TCI_tools.SplabelB SplabelB1 
      Height          =   510
      Left            =   1800
      TabIndex        =   13
      Top             =   360
      Width           =   3885
      _ExtentX        =   6853
      _ExtentY        =   900
      CAPTION         =   "Create Administrator "
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
      Caption         =   "Clear"
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
      Left            =   840
      TabIndex        =   12
      Top             =   5280
      Width           =   1455
   End
   Begin VB.ComboBox cmbLab 
      CausesValidation=   0   'False
      DataField       =   "LAB_NAME"
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
      Height          =   390
      ItemData        =   "frmAddAdmin.frx":0000
      Left            =   3600
      List            =   "frmAddAdmin.frx":0002
      Style           =   2  'Dropdown List
      TabIndex        =   10
      Top             =   2880
      Width           =   3000
   End
   Begin VB.CommandButton cmdCancel 
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
      Left            =   5040
      TabIndex        =   9
      Top             =   5280
      Width           =   1575
   End
   Begin VB.CommandButton cmdAdd 
      Caption         =   "Add"
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
      Left            =   3000
      TabIndex        =   8
      Top             =   5280
      Width           =   1455
   End
   Begin VB.TextBox txtConf 
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
      IMEMode         =   3  'DISABLE
      Left            =   3600
      MaxLength       =   20
      PasswordChar    =   "*"
      TabIndex        =   7
      Top             =   4080
      Width           =   3000
   End
   Begin VB.TextBox txtPass 
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
      IMEMode         =   3  'DISABLE
      Left            =   3600
      MaxLength       =   20
      PasswordChar    =   "*"
      TabIndex        =   6
      Top             =   3480
      Width           =   3000
   End
   Begin VB.TextBox txtName 
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
      Left            =   3600
      MaxLength       =   20
      TabIndex        =   5
      Top             =   2280
      Width           =   3000
   End
   Begin VB.TextBox txtId 
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
      Left            =   3600
      MaxLength       =   10
      TabIndex        =   4
      Top             =   1680
      Width           =   3000
   End
   Begin VB.Label lblLab 
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
      Height          =   375
      Left            =   600
      TabIndex        =   11
      Top             =   2880
      Width           =   2760
   End
   Begin VB.Label Label2 
      Alignment       =   2  'Center
      BackColor       =   &H00E0E0E0&
      Caption         =   "Confirm Password"
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
      Left            =   600
      TabIndex        =   3
      Top             =   4080
      Width           =   2775
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H00E0E0E0&
      Caption         =   "Password"
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
      Left            =   600
      TabIndex        =   2
      Top             =   3480
      Width           =   2775
   End
   Begin VB.Label lblName 
      Alignment       =   2  'Center
      BackColor       =   &H00E0E0E0&
      Caption         =   "Administrator &Name"
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
      Left            =   600
      TabIndex        =   1
      Top             =   2280
      Width           =   2775
   End
   Begin VB.Label lblLabName 
      Alignment       =   2  'Center
      BackColor       =   &H00E0E0E0&
      Caption         =   "Administrator &ID"
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
      Left            =   600
      TabIndex        =   0
      Top             =   1680
      Width           =   2775
   End
End
Attribute VB_Name = "frmAddAdmin"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub cmdAdd_Click()
    ID = UCase(Trim(txtID.Text))
    Name1 = UCase(Trim(txtName.Text))
    If cmbLab.Text = "" Then
        MsgBox "Enter Lab Name", vbInformation + vbOKOnly, "Incomplete Details"
        Exit Sub
    End If
    If ID = "" Then
        MsgBox "Enter ADMINISTRATOR ID", vbInformation + vbOKOnly, "Incomplete information"
        Exit Sub
    End If
    If Name1 = "" Then
        MsgBox "Enter ADMINISTRATOR NAME", vbInformation + vbOKOnly, "Incomplete information"
        Exit Sub
    End If
    If Trim(txtPass.Text) = "" Then
        MsgBox "Password Should not blank", vbOKOnly + vbInformation, "Password Required"
        Exit Sub
    End If
    If txtPass.Text = txtConf.Text Then
        ModConnect.Recs.Open "select id from administrator where id='" + ID + "' ", ModConnect.Conn, adOpenDynamic
        If ModConnect.Recs.EOF Then
            Stg = "insert into administrator (name,id,lab,passwd) values ('" + Name1 + "','" + ID + "','" + cmbLab.Text + "','" + txtPass.Text + "')"
            ModConnect.Conn.Execute (Stg)
            MsgBox "New Administrator Created", vbOKOnly, "Successful Creation"
        Else
            MsgBox "Error: ADMINISTRATOR ID = " + txtID.Text + " Exists.", vbInformation + vbOKOnly, "ID Present"
        End If
    Else
        MsgBox "Passwords donot match", vbOKOnly
    End If
    Call ModConnect.Records_Close
End Sub

Private Sub cmdCancel_Click()
    Unload Me
End Sub

Private Sub cmdClear_Click()
    txtName.Text = ""
    txtID.Text = ""
    txtPass.Text = ""
    txtConf.Text = ""
End Sub

Private Sub Form_Load()
    Call ModFun.Combo_Fill(cmbLab, "lab", "lab_name", "lab_name")
End Sub

Private Sub Splabel1_DragDrop(Source As Control, X As Single, Y As Single)

End Sub

Private Sub Form_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Me.Refresh
End Sub
