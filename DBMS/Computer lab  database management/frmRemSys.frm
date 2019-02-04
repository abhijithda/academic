VERSION 5.00
Object = "{E7D6E204-3EEC-4D89-8955-8236E52B25C0}#1.0#0"; "TCI_TOOLS.OCX"
Begin VB.Form frmRemSys 
   BackColor       =   &H008080FF&
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Remove System"
   ClientHeight    =   4875
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   7245
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4875
   ScaleWidth      =   7245
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin TCI_tools.Splabel Splabel1 
      Height          =   420
      Left            =   75
      TabIndex        =   6
      Top             =   600
      Width           =   7095
      _ExtentX        =   12515
      _ExtentY        =   741
      CAPTION         =   "Select Lab in which you want to remove a System"
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
   Begin VB.CommandButton cmdRem 
      Caption         =   "&Remove"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   720
      TabIndex        =   5
      Top             =   3720
      Width           =   2055
   End
   Begin VB.CommandButton cmdCancel 
      Caption         =   "&Cancel"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   4320
      TabIndex        =   4
      Top             =   3720
      Width           =   2055
   End
   Begin VB.ComboBox cmbLab 
      CausesValidation=   0   'False
      DataField       =   "LAB_NAME"
      DataSource      =   "Adodc1"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      ItemData        =   "frmRemSys.frx":0000
      Left            =   3600
      List            =   "frmRemSys.frx":0002
      TabIndex        =   1
      Top             =   2040
      Width           =   3000
   End
   Begin VB.ComboBox cmbSys 
      CausesValidation=   0   'False
      DataField       =   "LAB_NAME"
      DataSource      =   "Adodc1"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      ItemData        =   "frmRemSys.frx":0004
      Left            =   3600
      List            =   "frmRemSys.frx":0006
      TabIndex        =   0
      Top             =   2760
      Width           =   3000
   End
   Begin VB.Label Label2 
      BackColor       =   &H8000000B&
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
      Left            =   480
      TabIndex        =   3
      Top             =   2040
      Width           =   3000
   End
   Begin VB.Label Label1 
      BackColor       =   &H8000000B&
      Caption         =   "System Number"
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
      TabIndex        =   2
      Top             =   2760
      Width           =   3000
   End
End
Attribute VB_Name = "frmRemSys"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmbLab_Change()
    Call Drop_Combo
End Sub

Private Sub cmbLab_LostFocus()
    Call Drop_Combo
End Sub

Private Sub cmdCancel_Click()
    Unload Me
End Sub

Private Sub cmdRem_Click()
    ModConnect.Rs.Open "select * from system where sys_no = '" + cmbSys.Text + "'", ModConnect.Conn, adOpenDynamic
    If ModConnect.Rs.EOF Then
        MsgBox "System : " + cmbSys.Text, vbInformation, "Error"
    Else
        If MsgBox("Remove System : " + cmbSys.Text + " ? ", vbCritical + vbYesNo, "Confirmation") = vbYes Then
'   Remove Reservation done on that system
            ModConnect.Recs.Open "select sys_no from reservation", ModConnect.Conn, adOpenDynamic
            Stg = "delete reservation where sys_no = '" + cmbSys.Text + "'"
            On Error Resume Next
            ModConnect.Conn.Execute (Stg)
'   Delete the specified system from the database
            Stg = "delete system where sys_no = '" + cmbSys.Text + "'"
            ModConnect.Conn.Execute (Stg)
            MsgBox "System Removed : " + cmbSys.Text, vbOKOnly, "System Removed"
        End If
    End If
    ModConnect.Records_Close
    Call ModFun.Count_No_(cmbLab.Text)
End Sub

Private Sub Form_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Me.Refresh
End Sub

Private Sub Form_Load()
    Call ModConnect.Connect
    Call ModFun.Combo_Fill(cmbLab, "lab", "lab_name", "lab_name")
    Call Drop_Combo
End Sub

Public Sub Drop_Combo()
    Dim Ar_ind As Integer
    ModConnect.Records_Close
    ModConnect.Rs.Open "select sys_no from system where lab = '" + cmbLab.Text + "' order by sys_no", ModConnect.Conn, adOpenForwardOnly
    Stg = "select sys_no from system where lab = '" + cmbLab.Text + "' order by sys_no"
    cmbSys.Clear
    While ModConnect.Rs.EOF = False
        cmbSys.AddItem ModConnect.Rs(0)
        cmbSys.ItemData(cmbSys.NewIndex) = Ar_ind
        Ar_ind = Ar_ind + 1
        ModConnect.Rs.MoveNext
        ModConnect.Conn.Execute (Stg)
    Wend
    ModConnect.Rs.Close
End Sub

