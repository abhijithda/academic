VERSION 5.00
Object = "{E7D6E204-3EEC-4D89-8955-8236E52B25C0}#1.0#0"; "TCI_TOOLS.OCX"
Begin VB.Form frmRemLab 
   BackColor       =   &H008080FF&
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Remove Lab"
   ClientHeight    =   6945
   ClientLeft      =   3225
   ClientTop       =   1965
   ClientWidth     =   8880
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6945
   ScaleWidth      =   8880
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin TCI_tools.SplabelB SplabelB1 
      Height          =   570
      Left            =   2955
      TabIndex        =   13
      Top             =   360
      Width           =   2655
      _ExtentX        =   4683
      _ExtentY        =   1005
      CAPTION         =   "Remove Lab"
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
   Begin VB.TextBox txtLab 
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
      Height          =   375
      Left            =   4680
      MaxLength       =   10
      TabIndex        =   12
      Text            =   "Text1"
      Top             =   1920
      Width           =   3000
   End
   Begin VB.CommandButton cmdCancel 
      Caption         =   "&Cancel"
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
      Left            =   5400
      TabIndex        =   11
      Top             =   5760
      Width           =   2055
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
      Left            =   1800
      TabIndex        =   10
      Top             =   5760
      Width           =   2055
   End
   Begin VB.TextBox txtNo 
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
      Height          =   375
      Left            =   4560
      Locked          =   -1  'True
      TabIndex        =   9
      Text            =   "Text1"
      Top             =   5040
      Width           =   3000
   End
   Begin VB.TextBox txtDept 
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
      Height          =   375
      Left            =   4560
      Locked          =   -1  'True
      TabIndex        =   7
      Text            =   "Text1"
      Top             =   4440
      Width           =   3000
   End
   Begin VB.TextBox txtName 
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
      Height          =   375
      Left            =   4560
      Locked          =   -1  'True
      TabIndex        =   5
      Text            =   "Text1"
      Top             =   3840
      Width           =   3000
   End
   Begin VB.ComboBox cmbLab 
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
      Style           =   2  'Dropdown List
      TabIndex        =   2
      Top             =   2550
      Width           =   3015
   End
   Begin VB.OptionButton Optenter 
      BackColor       =   &H8000000A&
      Caption         =   "Select Lab Name"
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
      Left            =   1080
      TabIndex        =   1
      Top             =   2550
      Value           =   -1  'True
      Width           =   3135
   End
   Begin VB.OptionButton Optenter 
      BackColor       =   &H8000000A&
      Caption         =   "Enter the Lab Name"
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
      Left            =   1080
      TabIndex        =   0
      Top             =   1830
      Width           =   3135
   End
   Begin VB.Label Label3 
      Alignment       =   2  'Center
      BackColor       =   &H8000000A&
      Caption         =   "Number of Systems"
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
      Left            =   1440
      TabIndex        =   8
      Top             =   5040
      Width           =   2775
   End
   Begin VB.Label Label2 
      Alignment       =   2  'Center
      BackColor       =   &H8000000A&
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
      Left            =   1440
      TabIndex        =   6
      Top             =   4440
      Width           =   2775
   End
   Begin VB.Label lblName 
      Alignment       =   2  'Center
      BackColor       =   &H8000000A&
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
      Left            =   1440
      TabIndex        =   4
      Top             =   3840
      Width           =   2775
   End
   Begin VB.Label Label1 
      BackColor       =   &H008080FF&
      Caption         =   "Details of lab :"
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
      Left            =   480
      TabIndex        =   3
      Top             =   3240
      Width           =   3375
   End
End
Attribute VB_Name = "frmRemLab"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public sel As Boolean
Dim flag As Boolean

Private Sub cmbLab_Click()
    flag = False
    Call cmdRem_Click
End Sub

Private Sub cmdCancel_Click()
    Unload Me
End Sub
Private Sub cmdRem_Click()
    ModConnect.Records_Close
'    On Error GoTo e1
    If sel Then
        txtLab.Text = cmbLab.Text
    End If
    ID = Trim(txtLab.Text)
    
    ModConnect.Rs.Open "select * from lab where lab_name = '" + ID + "' ", Conn, adOpenDynamic
    On Error GoTo e1
    txtName.Text = ModConnect.Rs(0)
    txtDept.Text = ModConnect.Rs(1)
    txtNo.Text = ModConnect.Rs(2)
    If flag = False Then
        flag = True
        Exit Sub
    End If
    
    If Not ModConnect.Rs.EOF Then
        Dim Msg As Integer
        Msg = MsgBox("Remove Lab: " + ID + " ?", vbYesNo + vbQuestion, "Confirmation")
        If Msg = vbYes Then

' to maintain the referntial integrity, we remove the lab entry in
' the system, time_table, history and history tables
' at the end we delete the lab entry in the lab table

            Stg = "delete system where lab='" + ID + "'"
            ModConnect.Conn.Execute (Stg)
            
            Stg = "delete time_table where lab='" + ID + "'"
            ModConnect.Conn.Execute (Stg)
            
            Stg = "delete history where lab_name='" + ID + "'"
            ModConnect.Conn.Execute (Stg)
            
            Stg = "delete administrator where lab='" + ID + "'"
            ModConnect.Conn.Execute (Stg)
            
            On Error Resume Next
            Recs.Close
            
            'Recs.Open "select * from lab", ModConnect.Conn, adOpenDynamic
            'stg = "delete system where lab = '" + cmbLab.Text + "'"
            On Error Resume Next
            ModConnect.Conn.Execute (Stg)
            
'   Delete the specified lab from the database
            Stg = "delete lab where lab_name = '" + ID + "'"
            ModConnect.Conn.Execute (Stg)
            MsgBox "Removed: Lab = " + ID, vbInformation + vbOKOnly, "Delelted"
            Clear
        End If
    Else
e1:         MsgBox " Error :  " + ID + " is not present", vbError + vbOKOnly, "Cannot Remove"
            Call Clear
    End If
    ModConnect.Records_Close
    Call ModFun.Combo_Fill(cmbLab, "lab", "lab_name", "lab_name")
End Sub

Public Sub Opt_Enter(Index As Integer)
    If Index = 0 Then
        sel = False
        
        'cmbLab.Text = ""
        cmbLab.Enabled = False
        cmbLab.BackColor = &H80000011
        txtLab.BackColor = &H80000005
        txtLab.Text = ""
        txtLab.Enabled = True
    Else
        sel = True
        txtLab.Text = ""
        txtLab.Enabled = False
        txtLab.BackColor = &H80000011
        cmbLab.Enabled = True
        cmbLab.BackColor = &H80000005
        cmbLab.ListIndex = cmbLab.ListCount - 1
    End If
End Sub

Private Sub Optenter_Click(Index As Integer)
    Call Opt_Enter(Index)
End Sub

Public Sub Clear()
    txtLab.Text = ""
    txtNo.Text = ""
    txtName.Text = ""
    txtDept.Text = ""
End Sub

Private Sub Form_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Me.Refresh
End Sub

Private Sub Form_Load()
    Clear
    Call ModFun.Combo_Fill(cmbLab, "lab", "lab_name", "lab_name")
    Call Opt_Enter(1)
End Sub

