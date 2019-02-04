VERSION 5.00
Object = "{E7D6E204-3EEC-4D89-8955-8236E52B25C0}#1.0#0"; "TCI_TOOLS.OCX"
Begin VB.Form frmDispAdmin 
   BackColor       =   &H008080FF&
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Display details of the Administrator"
   ClientHeight    =   6795
   ClientLeft      =   4545
   ClientTop       =   3510
   ClientWidth     =   9990
   BeginProperty Font 
      Name            =   "Arial"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6795
   ScaleWidth      =   9990
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Tag             =   "aa"
   Begin TCI_tools.SplabelB SplabelB1 
      Height          =   420
      Left            =   840
      TabIndex        =   14
      Top             =   240
      Width           =   7035
      _ExtentX        =   12409
      _ExtentY        =   741
      CAPTION         =   "To obtain the Report of all the Administrators   -->"
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
   Begin VB.CommandButton cmdReport 
      Caption         =   "&Report"
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
      Left            =   7920
      TabIndex        =   13
      Top             =   240
      Width           =   2055
   End
   Begin VB.ComboBox cmbid 
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
      Left            =   5520
      TabIndex        =   12
      Top             =   2040
      Width           =   3015
   End
   Begin VB.OptionButton Optenter 
      BackColor       =   &H8000000B&
      Caption         =   "Select Administrator ID"
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
      Left            =   1200
      TabIndex        =   11
      Top             =   2040
      Value           =   -1  'True
      Width           =   3975
   End
   Begin VB.OptionButton Optenter 
      BackColor       =   &H8000000B&
      Caption         =   "Enter the Administrator ID"
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
      Left            =   1200
      TabIndex        =   10
      Top             =   1320
      Width           =   3975
   End
   Begin VB.TextBox txtLab 
      Appearance      =   0  'Flat
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   420
      Left            =   4560
      TabIndex        =   9
      Top             =   4440
      Width           =   3000
   End
   Begin VB.CommandButton Command1 
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
      Left            =   5595
      TabIndex        =   7
      Top             =   5640
      Width           =   2055
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
      Left            =   1800
      TabIndex        =   6
      Top             =   5640
      Width           =   2055
   End
   Begin VB.TextBox txtID 
      DataField       =   "ID"
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
      Height          =   420
      Index           =   0
      Left            =   5505
      TabIndex        =   5
      ToolTipText     =   " Enter Students Name"
      Top             =   1290
      Width           =   3000
   End
   Begin VB.Frame frmstuddetails 
      BackColor       =   &H8000000A&
      Caption         =   " Administrator Details"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2295
      Left            =   1560
      TabIndex        =   0
      Top             =   3000
      Width           =   6375
      Begin VB.TextBox txtID 
         Appearance      =   0  'Flat
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
         Height          =   420
         Index           =   1
         Left            =   3000
         TabIndex        =   3
         Top             =   960
         Width           =   3000
      End
      Begin VB.TextBox txtName 
         Appearance      =   0  'Flat
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
         Height          =   420
         Index           =   0
         Left            =   3000
         TabIndex        =   1
         Top             =   480
         Width           =   3000
      End
      Begin VB.Label lblLab 
         Alignment       =   1  'Right Justify
         BackColor       =   &H8000000B&
         Caption         =   "Lab"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   405
         Left            =   120
         TabIndex        =   8
         Top             =   1440
         Width           =   2775
      End
      Begin VB.Label lblLabName 
         Alignment       =   1  'Right Justify
         BackColor       =   &H8000000B&
         Caption         =   "Administrator &ID"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   405
         Left            =   120
         TabIndex        =   4
         Top             =   960
         Width           =   2775
      End
      Begin VB.Label lblName 
         Alignment       =   1  'Right Justify
         BackColor       =   &H8000000B&
         Caption         =   "Administrator &Name"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   405
         Left            =   120
         TabIndex        =   2
         Top             =   480
         Width           =   2775
      End
   End
End
Attribute VB_Name = "frmDispAdmin"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public sel As Boolean
Private Sub cmdCancel_Click()
    Unload Me
    frmAdministrator.Show
End Sub

Private Sub cmdClear_Click()
    txtName(0).Text = ""    ' Clear text box.
    txtID(1).Text = ""
    txtName(0).SetFocus
End Sub


Private Sub cmbID_Click()
    If sel Then
        txtID(0).Text = cmbID.Text
    End If
    ID = Trim(txtID(0).Text)
    Call cmdFind_Click
End Sub

Private Sub cmdFind_Click()
    ModConnect.Rs.Open "select * from administrator where id = '" + txtID(0).Text + "' ", Conn, adOpenKeyset, adLockOptimistic
    If ModConnect.Rs.EOF Then
        Dim Msg As Variant
            MsgBox " " + txtID(0).Text + " not present in the list.", vbOKOnly, "Search Failure"
            ModConnect.Rs.Close
            txtID(1).Text = ""
            txtName(0).Text = ""
            txtLab.Text = ""
        Exit Sub
    End If
    txtID(1).Text = ModConnect.Rs(0)
    txtName(0).Text = ModConnect.Rs(1)
    If IsNull(ModConnect.Rs(2)) Then
        txtLab.Text = ""
    Else
        txtLab.Text = ModConnect.Rs(2)
    End If
    ModConnect.Rs.Close
End Sub

Private Sub cmdReport_Click()
    LabData.LabConn.Open
    LabData.ADMINISTRATOR
    Admin_Report.Refresh
    Admin_Report.Show 1
    LabData.LabConn.Close
End Sub

Private Sub Command1_Click()
    Unload Me
End Sub

Private Sub Form_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Me.Refresh
End Sub

Private Sub Form_KeyPress(KeyAscii As Integer)
    If sel Then
        txtID(0).Text = cmbID.Text
    End If
    ID = Trim(txtID(0).Text)
End Sub

Private Sub Form_Load()
    Call ModConnect.Connect
    Call ModFun.Combo_Fill(cmbID, "administrator", "id", "id")
    Call Opt_Enter(1)
End Sub

Private Sub Optenter_Click(Index As Integer)
    Call Opt_Enter(Index)
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
        cmbID.Text = ""
    End If
End Sub


Private Sub txtID_KeyPress(Index As Integer, KeyAscii As Integer)
    If Asc(KeyAscii) = vbEnter Then
        Call cmdFind_Click
    End If
End Sub
