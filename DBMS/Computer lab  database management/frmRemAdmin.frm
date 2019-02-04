VERSION 5.00
Object = "{E7D6E204-3EEC-4D89-8955-8236E52B25C0}#1.0#0"; "TCI_TOOLS.OCX"
Begin VB.Form frmRemAdmin 
   BackColor       =   &H008080FF&
   Caption         =   "Remove Administrator"
   ClientHeight    =   6420
   ClientLeft      =   4620
   ClientTop       =   3795
   ClientWidth     =   8715
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6420
   ScaleWidth      =   8715
   StartUpPosition =   2  'CenterScreen
   Begin TCI_tools.Splabel Splabel1 
      Height          =   420
      Left            =   480
      TabIndex        =   14
      Top             =   2400
      Width           =   3165
      _ExtentX        =   5583
      _ExtentY        =   741
      CAPTION         =   "Administrator Details"
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
   Begin VB.TextBox txtID 
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
      Index           =   0
      Left            =   4680
      TabIndex        =   10
      Top             =   840
      Width           =   3000
   End
   Begin VB.OptionButton Optenter 
      BackColor       =   &H008080FF&
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
      Left            =   360
      TabIndex        =   9
      Top             =   870
      Width           =   3975
   End
   Begin VB.OptionButton Optenter 
      BackColor       =   &H008080FF&
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
      Left            =   360
      TabIndex        =   8
      Top             =   1590
      Value           =   -1  'True
      Width           =   3975
   End
   Begin VB.ComboBox cmbID 
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
      Left            =   4680
      TabIndex        =   7
      Top             =   1590
      Width           =   3015
   End
   Begin VB.Frame frmstuddetails 
      BackColor       =   &H8000000B&
      Height          =   2040
      Left            =   960
      TabIndex        =   2
      Top             =   3000
      Width           =   6495
      Begin VB.TextBox txtLab 
         Appearance      =   0  'Flat
         CausesValidation=   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   385
         Index           =   2
         Left            =   3000
         TabIndex        =   11
         Top             =   1320
         Width           =   3255
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
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   385
         Index           =   0
         Left            =   3000
         TabIndex        =   4
         Top             =   360
         Width           =   3255
      End
      Begin VB.TextBox txtID 
         Appearance      =   0  'Flat
         CausesValidation=   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   385
         Index           =   1
         Left            =   3000
         TabIndex        =   3
         Top             =   840
         Width           =   3255
      End
      Begin VB.Label lblLab 
         Alignment       =   2  'Center
         BackColor       =   &H8000000B&
         Caption         =   "Lab"
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
         TabIndex        =   12
         Top             =   1320
         Width           =   2775
      End
      Begin VB.Label lblName 
         Alignment       =   2  'Center
         BackColor       =   &H8000000B&
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
         Left            =   120
         TabIndex        =   6
         Top             =   360
         Width           =   2775
      End
      Begin VB.Label lblLabName 
         Alignment       =   2  'Center
         BackColor       =   &H8000000B&
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
         Left            =   120
         TabIndex        =   5
         Top             =   840
         Width           =   2775
      End
   End
   Begin VB.CommandButton cmdRem 
      Caption         =   "&Remove"
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
      Left            =   1200
      TabIndex        =   1
      Top             =   5445
      Width           =   2055
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
      Left            =   4965
      TabIndex        =   0
      Top             =   5445
      Width           =   2055
   End
   Begin VB.Label Label1 
      BackColor       =   &H008080FF&
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   -1  'True
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   240
      TabIndex        =   13
      Top             =   2400
      Width           =   3495
   End
End
Attribute VB_Name = "frmRemAdmin"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public sel As Boolean


Private Sub cmbID_Click()
    Call Find_Admin
End Sub

Private Sub cmdCancel_Click()
    Unload Me
End Sub

Private Sub cmdRem_Click()
    ModConnect.Records_Close
'    On Error GoTo e1
    If sel Then
        txtID(0).Text = cmbID.Text
    End If
    ID = Trim(txtID(0).Text)
    
    ModConnect.Rs.Open "select * from administrator where id='" + ID + "' ", ModConnect.Conn, adOpenDynamic
'    On Error GoTo e1
'    ModConnect.Recs.Open "select * from password where admin_id='" + ID + "' ", ModConnect.Conn, adOpenDynamic
'    On Error Resume Next

    If ModConnect.Rs.EOF Then
        GoTo e1
    End If
    
  
    txtName(0).Text = ModConnect.Rs(0)
    txtID(1).Text = ModConnect.Rs(1)
    If IsNull(ModConnect.Rs(2)) Then
        txtLab(2).Text = ""
    Else
        txtLab(2).Text = ModConnect.Rs(2)
    End If
    If Not ModConnect.Rs.EOF Then
        Dim Msg As Integer
        Msg = MsgBox("Remove Admin_id: " + ID + " ?", vbYesNo + vbQuestion, "Confirmation")
        If Msg = vbYes Then
'            stg = "delete from password where admin_id='" + txtID(0).Text + "'"
'            ModConnect.Conn.Execute (stg)
            Stg = "delete from administrator where id='" + txtID(0).Text + "'"
            ModConnect.Conn.Execute (Stg)
            MsgBox "Removed: ID = " + txtID(0).Text + " Name = " + txtName(0).Text, vbInformation + vbOKOnly, "Delelted"
            Clear
        End If
    Else
e1:        MsgBox " Error :  " + txtID(0).Text + " is not present", vbInformation + vbOKOnly, "Cannot Remove"
            Call Clear
    End If
    ModConnect.Records_Close
    Call ModFun.Combo_Fill(cmbID, "Administrator", "id", "id")
End Sub


Private Sub Form_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Me.Refresh
End Sub

Private Sub Form_Load()
    Call ModConnect.Connect
    Clear
    Call ModFun.Combo_Fill(cmbID, "Administrator", "id", "id")
    Call Opt_Enter(1)
End Sub

Public Sub Clear()
    txtID(0).Text = ""
    txtID(1).Text = ""
    txtName(0).Text = ""
    txtLab(2).Text = ""
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

Public Sub Find_Admin()
    ModConnect.Records_Close
'    On Error GoTo e1
    If sel Then
        txtID(0).Text = cmbID.Text
    End If
    ID = Trim(txtID(0).Text)
    
    ModConnect.Rs.Open "select * from administrator where id='" + ID + "' ", ModConnect.Conn, adOpenDynamic
    On Error GoTo e1
    'ModConnect.Recs.Open "select * from password where admin_id='" + ID + "' ", ModConnect.Conn, adOpenDynamic
    On Error Resume Next
    txtName(0).Text = ModConnect.Rs(0)
    txtID(1).Text = ModConnect.Rs(1)
    If IsNull(ModConnect.Rs(2)) Then
        txtLab(2).Text = ""
    Else
        txtLab(2).Text = ModConnect.Rs(2)
    End If
    ModConnect.Records_Close
e1:
End Sub
