VERSION 5.00
Object = "{E7D6E204-3EEC-4D89-8955-8236E52B25C0}#1.0#0"; "TCI_TOOLS.OCX"
Begin VB.Form frmModAdmin 
   BackColor       =   &H008080FF&
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Modify Administrator"
   ClientHeight    =   7005
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   9600
   BeginProperty Font 
      Name            =   "Arial"
      Size            =   12
      Charset         =   0
      Weight          =   700
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   7005
   ScaleWidth      =   9600
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin TCI_tools.Splabel Splabel1 
      Height          =   570
      Left            =   2115
      TabIndex        =   15
      Top             =   360
      Width           =   5370
      _ExtentX        =   9472
      _ExtentY        =   1005
      CAPTION         =   "Administrator Modification"
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
   Begin VB.ComboBox cmbLab 
      CausesValidation=   0   'False
      DataField       =   "LAB_NAME"
      DataSource      =   "Adodc1"
      Height          =   405
      ItemData        =   "frmModAdmin.frx":0000
      Left            =   4920
      List            =   "frmModAdmin.frx":0002
      TabIndex        =   13
      Top             =   4200
      Width           =   3000
   End
   Begin VB.ComboBox cmbID 
      Height          =   405
      Left            =   5040
      TabIndex        =   12
      Top             =   1950
      Width           =   3015
   End
   Begin VB.OptionButton Optenter 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Select Administrator ID"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   1
      Left            =   720
      TabIndex        =   11
      Top             =   1950
      Value           =   -1  'True
      Width           =   3975
   End
   Begin VB.OptionButton Optenter 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Enter the Administrator ID"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   0
      Left            =   720
      TabIndex        =   10
      Top             =   1230
      Width           =   3975
   End
   Begin VB.TextBox txtID 
      Height          =   420
      Index           =   0
      Left            =   5040
      TabIndex        =   9
      Top             =   1200
      Width           =   3000
   End
   Begin VB.TextBox txtName 
      Height          =   375
      Left            =   4920
      MaxLength       =   20
      TabIndex        =   7
      Top             =   3600
      Width           =   3000
   End
   Begin VB.TextBox txtPass 
      Height          =   375
      IMEMode         =   3  'DISABLE
      Left            =   4920
      MaxLength       =   20
      PasswordChar    =   "*"
      TabIndex        =   3
      Top             =   4800
      Width           =   3000
   End
   Begin VB.TextBox txtConf 
      Height          =   375
      IMEMode         =   3  'DISABLE
      Left            =   4920
      MaxLength       =   20
      PasswordChar    =   "*"
      TabIndex        =   2
      Top             =   5400
      Width           =   3000
   End
   Begin VB.CommandButton cmdUpdate 
      BackColor       =   &H8000000C&
      Caption         =   "Update"
      Height          =   495
      Left            =   3840
      TabIndex        =   1
      Top             =   6240
      Width           =   1455
   End
   Begin VB.CommandButton cmdCancel 
      BackColor       =   &H8000000C&
      Caption         =   "Exit"
      Height          =   495
      Left            =   6240
      TabIndex        =   0
      Top             =   6240
      Width           =   1575
   End
   Begin VB.Label Label3 
      Appearance      =   0  'Flat
      BackColor       =   &H00C0C0C0&
      Caption         =   "Modify Administrator details"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000008&
      Height          =   405
      Left            =   360
      TabIndex        =   14
      Top             =   2760
      Width           =   3615
   End
   Begin VB.Label lblName 
      Alignment       =   2  'Center
      BackColor       =   &H00C0C0C0&
      Caption         =   "Administrator &Name"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   405
      Left            =   1920
      TabIndex        =   8
      Top             =   3600
      Width           =   2775
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H00C0C0C0&
      Caption         =   "Password"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   405
      Left            =   1920
      TabIndex        =   6
      Top             =   4800
      Width           =   2775
   End
   Begin VB.Label Label2 
      Alignment       =   2  'Center
      BackColor       =   &H00C0C0C0&
      Caption         =   "Confirm Password"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   405
      Left            =   1920
      TabIndex        =   5
      Top             =   5400
      Width           =   2775
   End
   Begin VB.Label lblLab 
      Alignment       =   2  'Center
      BackColor       =   &H00C0C0C0&
      Caption         =   "Lab Name"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   1920
      TabIndex        =   4
      Top             =   4200
      Width           =   2760
   End
End
Attribute VB_Name = "frmModAdmin"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public sel As Boolean


Private Sub cmbID_Click()
    Call Find_Admin
    txtConf.Text = ""
End Sub

Private Sub cmdCancel_Click()
    Unload Me
End Sub
Public Sub Clear()
    txtID(0).Text = ""
'    txtID(1).Text = ""
    txtName.Text = ""
    cmbLab.Text = ""
    txtPass.Text = ""
    txtConf.Text = ""
End Sub

Private Sub cmdDisplay_Click()
    Call Find_Admin
End Sub

Private Sub Form_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Me.Refresh
End Sub

Private Sub Form_Load()
    Call ModConnect.Connect
    Call Clear
    Call ModFun.Combo_Fill(cmbID, "Administrator", "id", "id")
    Call ModFun.Combo_Fill(cmbLab, "lab", "lab_name", "lab_name")
    Call Opt_Enter(1)
    Call Find_Admin
End Sub
Public Sub Opt_Enter(Index As Integer)
    If Index = 0 Then
        sel = False
        cmbID.Enabled = False
        cmbID.Text = ""
        cmbID.BackColor = &H80000011
        txtID(0).BackColor = &H80000005
        txtID(0).Text = ""
        txtID(0).Enabled = True
    Else
        sel = True
        txtID(0).Text = ""
        txtID(0).Enabled = False
        txtID(0).BackColor = &H80000011
        cmbID.Enabled = True
        cmbID.BackColor = &H80000005
        cmbID.ListIndex = 0
    End If
End Sub

Private Sub Optenter_Click(Index As Integer)
    Call Opt_Enter(Index)
End Sub


Private Sub cmdUpdate_Click()
    ID = UCase(Trim(txtID(0).Text))
    Name1 = UCase(Trim(txtName.Text))
    If ID = "" Then
        MsgBox "Enter ADMINISTRATOR ID", vbInformation + vbOKOnly, "Incomplete information"
    End If
    If Name1 = "" Then
        MsgBox "Enter ADMINISTRATOR NAME", vbInformation + vbOKOnly, "Incomplete information"
    End If
    If txtPass.Text = txtConf.Text Then
        ModConnect.Recs.Open "select * from administrator where id='" + ID + "' ", ModConnect.Conn, adOpenDynamic
        If Not ModConnect.Recs.EOF Then
            Stg = "update administrator set name='" + Name1 + "',lab='" + cmbLab.Text + "',passwd ='" + txtPass.Text + "' where id = '" + ID + "'"
            ModConnect.Conn.Execute (Stg)
            MsgBox "Administrator Updated", vbOKOnly, "Successful Updation"
        Else
            MsgBox "Error: ADMINISTRATOR ID = " + txtID(0).Text + " does not exist.", vbInformation + vbOKOnly, "Admin ID Not Present"
        End If
    Else
        MsgBox "Passwords donot match", vbOKOnly
    End If
    Call ModConnect.Records_Close
End Sub

 Public Sub Find_Admin()

    ModConnect.Records_Close
    If sel Then
        txtID(0).Text = cmbID.Text
    End If
    ID = Trim(txtID(0).Text)
    
    ModConnect.Rs.Open "select name,lab,passwd from administrator where id='" + ID + "' ", Conn, adOpenDynamic
    If Not ModConnect.Rs.EOF Then
        txtName.Text = ModConnect.Rs(0)
        If IsNull(ModConnect.Rs(1)) Then
            cmbLab.Text = ""
        Else
            cmbLab.Text = ModConnect.Rs(1)
        End If
        
        If IsNull(ModConnect.Rs(2)) Then
            txtPass.Text = ""
        Else
            txtPass.Text = ModConnect.Rs(2)
        End If
        
        'If Not IsNull(ModConnect.Recs(0)) Then
          '  txtPass.Text = ModConnect.Recs(0)
        'Else
         '   txtPass.Text = ""
        'End If
        'If IsNull(ModConnect.Recs(0)) Then
         '   txtConf.Text = ""
        'Else
         '   txtConf.Text = ModConnect.Recs(0)
        'End If
    Else
e1:     MsgBox " Error :  " + txtID(0).Text + " is not present", vbInformation + vbOKOnly, "Cannot Remove"
        Call Clear
    End If
    ModConnect.Records_Close
 End Sub
