VERSION 5.00
Object = "{E7D6E204-3EEC-4D89-8955-8236E52B25C0}#1.0#0"; "TCI_TOOLS.OCX"
Begin VB.Form FrmDispLab 
   BackColor       =   &H008080FF&
   Caption         =   "Lab Details"
   ClientHeight    =   7020
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   9570
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   ScaleHeight     =   7020
   ScaleWidth      =   9570
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton CmdRep 
      Caption         =   "Report the Details of All Lab"
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
      Left            =   1560
      TabIndex        =   11
      Top             =   6000
      Width           =   6615
   End
   Begin VB.TextBox txtName 
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
      Height          =   375
      Left            =   4920
      Locked          =   -1  'True
      TabIndex        =   9
      Text            =   "Text1"
      Top             =   2760
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
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   4920
      Locked          =   -1  'True
      TabIndex        =   6
      Text            =   "Text1"
      Top             =   3360
      Width           =   3000
   End
   Begin VB.TextBox txtNo 
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
      Height          =   375
      Left            =   4920
      Locked          =   -1  'True
      TabIndex        =   5
      Text            =   "Text1"
      Top             =   3960
      Width           =   3000
   End
   Begin VB.ComboBox cmbLab 
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
      Left            =   4920
      TabIndex        =   3
      Top             =   1710
      Width           =   3015
   End
   Begin VB.CommandButton cmdDisp 
      Caption         =   "&Display"
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
      Left            =   1920
      TabIndex        =   2
      Top             =   4920
      Width           =   2055
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
      Left            =   5520
      TabIndex        =   1
      Top             =   4920
      Width           =   2055
   End
   Begin TCI_tools.SplabelB SplabelB1 
      Height          =   570
      Left            =   3345
      TabIndex        =   0
      Top             =   240
      Width           =   2880
      _ExtentX        =   5080
      _ExtentY        =   1005
      CAPTION         =   "Details of Lab"
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
   Begin VB.Label Label4 
      Alignment       =   2  'Center
      BackColor       =   &H8000000A&
      BackStyle       =   0  'Transparent
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
      Left            =   1560
      TabIndex        =   10
      Top             =   2760
      Width           =   2775
   End
   Begin VB.Label Label2 
      Alignment       =   2  'Center
      BackColor       =   &H8000000A&
      BackStyle       =   0  'Transparent
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
      Left            =   1560
      TabIndex        =   8
      Top             =   3360
      Width           =   2775
   End
   Begin VB.Label Label3 
      Alignment       =   2  'Center
      BackColor       =   &H8000000A&
      BackStyle       =   0  'Transparent
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
      Left            =   1560
      TabIndex        =   7
      Top             =   3960
      Width           =   2775
   End
   Begin VB.Label lblName 
      Alignment       =   2  'Center
      BackColor       =   &H8000000A&
      BackStyle       =   0  'Transparent
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
      Height          =   405
      Left            =   1560
      TabIndex        =   4
      Top             =   1680
      Width           =   2775
   End
End
Attribute VB_Name = "FrmDispLab"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub cmdCancel_Click()
    Unload Me
End Sub
Private Sub cmdDisp_Click()
    Call disp_details
End Sub

Public Sub Clear()
    cmbLab.Text = ""
    txtNo.Text = ""
    txtName.Text = ""
    txtDept.Text = ""
End Sub

Private Sub CmdRep_Click()
    If LabData.LabConn.State = 0 Then
        LabData.LabConn.Open
    End If
    LabData.Lab
    DataRepLab.Refresh
    DataRepLab.Show 1
    LabData.LabConn.Close
End Sub

Private Sub Form_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Me.Refresh
End Sub

Private Sub Form_Load()
    Clear
    Call ModFun.Combo_Fill(cmbLab, "lab", "lab_name", "lab_name")
End Sub

Public Sub disp_details()
ModConnect.Records_Close
'    On Error GoTo e1
    ID = cmbLab.Text
    
    ModConnect.Rs.Open "select * from lab where lab_name = '" + ID + "' ", Conn, adOpenDynamic
    If ModConnect.Rs.EOF Then
            Call Clear
e1:         MsgBox " Error :  " + ID + " is not present", vbInformation + vbOKOnly, "Cannot Remove"
            Exit Sub
    End If
    txtName.Text = ModConnect.Rs(0)
    txtDept.Text = ModConnect.Rs(1)
    txtNo.Text = ModConnect.Rs(2)
    ModConnect.Records_Close
End Sub

