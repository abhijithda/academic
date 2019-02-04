VERSION 5.00
Object = "{E7D6E204-3EEC-4D89-8955-8236E52B25C0}#1.0#0"; "TCI_TOOLS.OCX"
Begin VB.Form frmModSys 
   BackColor       =   &H008080FF&
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Update System Details"
   ClientHeight    =   10965
   ClientLeft      =   1755
   ClientTop       =   540
   ClientWidth     =   11790
   FillColor       =   &H8000000A&
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   10965
   ScaleWidth      =   11790
   ShowInTaskbar   =   0   'False
   WindowState     =   2  'Maximized
   Begin TCI_tools.Splabel Splabel1 
      Height          =   570
      Left            =   3585
      TabIndex        =   37
      Top             =   480
      Width           =   4620
      _ExtentX        =   8149
      _ExtentY        =   1005
      CAPTION         =   "Update System Details"
      BACKCOLOUR      =   -2147483637
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
   Begin VB.ComboBox cmbSys 
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
      ItemData        =   "frmModSys.frx":0000
      Left            =   3960
      List            =   "frmModSys.frx":0002
      TabIndex        =   36
      Top             =   1320
      Width           =   3000
   End
   Begin VB.TextBox txtPro 
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
      Left            =   3840
      MaxLength       =   20
      TabIndex        =   22
      Top             =   2520
      Width           =   3000
   End
   Begin VB.TextBox txtMb 
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
      Left            =   3840
      MaxLength       =   20
      TabIndex        =   21
      Top             =   3120
      Width           =   3000
   End
   Begin VB.TextBox txtPm 
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
      Left            =   3840
      MaxLength       =   20
      TabIndex        =   20
      Top             =   3720
      Width           =   3000
   End
   Begin VB.TextBox txtSm 
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
      Left            =   3840
      MaxLength       =   20
      TabIndex        =   19
      Top             =   4320
      Width           =   3000
   End
   Begin VB.TextBox txtFd 
      BackColor       =   &H80000009&
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
      Left            =   3840
      MaxLength       =   20
      TabIndex        =   18
      Top             =   5520
      Width           =   3000
   End
   Begin VB.TextBox txtCdr 
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
      Left            =   3840
      MaxLength       =   20
      TabIndex        =   17
      Top             =   6120
      Width           =   3000
   End
   Begin VB.TextBox txtCdrw 
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
      Left            =   3840
      MaxLength       =   20
      TabIndex        =   16
      Top             =   6720
      Width           =   3000
   End
   Begin VB.TextBox txtCost 
      BeginProperty DataFormat 
         Type            =   1
         Format          =   """$""#,##0.00;(""$""#,##0.00)"
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   1033
         SubFormatType   =   2
      EndProperty
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
      Left            =   7440
      MaxLength       =   10
      TabIndex        =   15
      Top             =   7920
      Width           =   3000
   End
   Begin VB.CommandButton cmdUpdate 
      Caption         =   "Update"
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
      Left            =   840
      TabIndex        =   14
      Top             =   9480
      Width           =   3000
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
      Left            =   4200
      TabIndex        =   13
      Top             =   9480
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
      Left            =   7560
      TabIndex        =   12
      Top             =   9480
      Width           =   3000
   End
   Begin VB.CommandButton cmdOk 
      Caption         =   "Ok"
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
      Left            =   10920
      TabIndex        =   11
      Top             =   9480
      Width           =   3000
   End
   Begin VB.CheckBox chkFd 
      BackColor       =   &H008080FF&
      Caption         =   "Floppy Drive"
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
      Left            =   720
      TabIndex        =   10
      Top             =   5520
      Width           =   3000
   End
   Begin VB.CheckBox chkCdr 
      BackColor       =   &H008080FF&
      Caption         =   "Cd-R Drive"
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
      Left            =   720
      TabIndex        =   9
      Top             =   6120
      Width           =   3000
   End
   Begin VB.CheckBox chkCdRW 
      BackColor       =   &H008080FF&
      Caption         =   "Cd-RW Drive"
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
      Left            =   720
      TabIndex        =   8
      Top             =   6720
      Width           =   3000
   End
   Begin VB.CheckBox chkInt 
      BackColor       =   &H008080FF&
      Caption         =   "Internet"
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
      Left            =   7800
      TabIndex        =   7
      Top             =   5520
      Width           =   3000
   End
   Begin VB.CheckBox chkPrn 
      BackColor       =   &H008080FF&
      Caption         =   "Printer"
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
      Left            =   7800
      TabIndex        =   6
      Top             =   6120
      Width           =   3000
   End
   Begin VB.ComboBox cmbMtT 
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
      ItemData        =   "frmModSys.frx":0004
      Left            =   10920
      List            =   "frmModSys.frx":000E
      TabIndex        =   5
      Top             =   3120
      Width           =   3000
   End
   Begin VB.ComboBox cmbStatus 
      BeginProperty DataFormat 
         Type            =   0
         Format          =   """$""#,##0.00;(""$""#,##0.00)"
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   1033
         SubFormatType   =   0
      EndProperty
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
      ItemData        =   "frmModSys.frx":0023
      Left            =   7440
      List            =   "frmModSys.frx":0030
      TabIndex        =   4
      Top             =   8520
      Width           =   3000
   End
   Begin VB.ComboBox cmbMou 
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
      ItemData        =   "frmModSys.frx":0066
      Left            =   10920
      List            =   "frmModSys.frx":0079
      TabIndex        =   3
      Top             =   4320
      Width           =   3000
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
      ItemData        =   "frmModSys.frx":00B6
      Left            =   10920
      List            =   "frmModSys.frx":00B8
      TabIndex        =   2
      Top             =   1320
      Width           =   3000
   End
   Begin VB.ComboBox cmbmtS 
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
      ItemData        =   "frmModSys.frx":00BA
      Left            =   10920
      List            =   "frmModSys.frx":00CD
      Sorted          =   -1  'True
      TabIndex        =   1
      Top             =   2520
      Width           =   3000
   End
   Begin VB.ComboBox cmbKb 
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
      ItemData        =   "frmModSys.frx":0116
      Left            =   10920
      List            =   "frmModSys.frx":0120
      TabIndex        =   0
      Top             =   3720
      Width           =   3000
   End
   Begin VB.Label Label7 
      Alignment       =   2  'Center
      BackColor       =   &H80000011&
      Caption         =   " Fields marked by '*' cannot be left blank."
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
      Left            =   0
      TabIndex        =   35
      Top             =   10560
      Width           =   15015
   End
   Begin VB.Label Label1 
      BackColor       =   &H008080FF&
      Caption         =   "*System Number"
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
      Left            =   840
      TabIndex        =   34
      Top             =   1320
      Width           =   3000
   End
   Begin VB.Label Label2 
      BackColor       =   &H008080FF&
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
      Left            =   7800
      TabIndex        =   33
      Top             =   1320
      Width           =   3000
   End
   Begin VB.Label Label3 
      BackColor       =   &H008080FF&
      Caption         =   "*Processor"
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
      Left            =   720
      TabIndex        =   32
      Top             =   2520
      Width           =   3000
   End
   Begin VB.Label Label4 
      BackColor       =   &H008080FF&
      Caption         =   "*Mother Board"
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
      Left            =   720
      TabIndex        =   31
      Top             =   3120
      Width           =   3000
   End
   Begin VB.Label Label5 
      BackColor       =   &H008080FF&
      Caption         =   "*Primary Memory"
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
      Left            =   720
      TabIndex        =   30
      Top             =   3720
      Width           =   3000
   End
   Begin VB.Label Label6 
      BackColor       =   &H008080FF&
      Caption         =   "*Secondary Memory"
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
      Left            =   720
      TabIndex        =   29
      Top             =   4320
      Width           =   3000
   End
   Begin VB.Label Label10 
      BackColor       =   &H008080FF&
      Caption         =   "Monitor Size"
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
      Left            =   7800
      TabIndex        =   28
      Top             =   2520
      Width           =   3000
   End
   Begin VB.Label Label11 
      BackColor       =   &H008080FF&
      Caption         =   "Monitor Type"
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
      Left            =   7800
      TabIndex        =   27
      Top             =   3120
      Width           =   3000
   End
   Begin VB.Label Label12 
      BackColor       =   &H008080FF&
      Caption         =   "Keyboard"
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
      Left            =   7800
      TabIndex        =   26
      Top             =   3720
      Width           =   3000
   End
   Begin VB.Label Label16 
      BackColor       =   &H008080FF&
      Caption         =   "System Cost"
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
      Left            =   4320
      TabIndex        =   25
      Top             =   7920
      Width           =   3000
   End
   Begin VB.Label Label17 
      BackColor       =   &H008080FF&
      Caption         =   "Status"
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
      Left            =   4320
      TabIndex        =   24
      Top             =   8520
      Width           =   3000
   End
   Begin VB.Label lblmou 
      BackColor       =   &H008080FF&
      Caption         =   "Mouse"
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
      Left            =   7800
      TabIndex        =   23
      Top             =   4320
      Width           =   3000
   End
End
Attribute VB_Name = "frmModSys"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public Sub Clear()
    txtPro.Text = ""
    txtMb.Text = ""
    txtPm.Text = ""
    txtSm.Text = ""
    cmbMou.ListIndex = 2
    chkFd.Value = 0
    chkCDr.Value = 0
    chkCDrw.Value = 0
    chkInt.Value = 0
    chkPrn.Value = 0
    txtCost.Text = ""
    cmbMTt.ListIndex = 0
    cmbStatus.ListIndex = 0
    cmbMTs.ListIndex = 0
    cmbKb.ListIndex = 0
    cmbLab.ListIndex = cmbLab.ListCount - 1
    
    txtFd.BackColor = &H80000011
    txtCdr.BackColor = &H80000011
    txtCdrw.BackColor = &H80000011
    txtFd.Enabled = False
    txtCdr.Enabled = False
    txtCdrw.Enabled = False
    txtFd.Text = ""
    txtCdr.Text = ""
    txtCdrw.Text = ""
End Sub

Private Sub chkCDr_Click()
    If chkCDr.Value Then
        txtCdr.BackColor = &H80000005
        txtCdr.Enabled = True
    Else
        txtCdr.BackColor = &H80000011
        txtCdr.Text = ""
        txtCdr.Enabled = False
    End If
End Sub

Private Sub chkCDrw_Click()
    If chkCDrw.Value Then
        txtCdrw.BackColor = &H80000005
        txtCdrw.Enabled = True
    Else
        txtCdrw.BackColor = &H80000011
        txtCdrw.Text = ""
        txtCdrw.Enabled = False
    End If
End Sub

Private Sub chkFd_Click()
    If chkFd.Value Then
        txtFd.BackColor = &H80000005
        txtFd.Enabled = True
    Else
        txtFd.BackColor = &H80000011
        txtFd.Text = ""
        txtFd.Enabled = False
    End If
End Sub

Private Sub cmbLab_Click()
    Call Drop_Combo
End Sub

Private Sub cmbLab_GotFocus()
    Call Drop_Combo
End Sub

Private Sub cmbLab_LostFocus()
    Call Drop_Combo
End Sub

Private Sub cmbSys_Click()
    Call Cmb_Sys
End Sub

Private Sub Cmb_Sys()
    sys = cmbSys.Text
    ModConnect.Rs.Open "select * from system where sys_no='" + sys + "'", ModConnect.Conn, adOpenDynamic
    If Not ModConnect.Rs.EOF Then
        If Not IsNull(Rs(2)) Then
            txtPro.Text = ModConnect.Rs(2)
        Else
            txtPro.Text = ""
        End If
        If Not IsNull(Rs(3)) Then
            txtMb.Text = ModConnect.Rs(3)
        Else
            txtMb.Text = ""
        End If
        If Not IsNull(Rs(4)) Then
            txtPm.Text = ModConnect.Rs(4)
        Else
            txtPm.Text = ""
        End If
        If Not IsNull(Rs(5)) Then
            txtSm.Text = ModConnect.Rs(5)
        Else
            txtSm.Text = ""
        End If
        If Not IsNull(Rs(6)) Then
            txtFd.Text = ModConnect.Rs(6)
        Else
            txtFd.Text = ""
        End If
        If Not IsNull(Rs(7)) Then
            txtCdr.Text = ModConnect.Rs(7)
        Else
            txtCdr.Text = ""
        End If
        If Not IsNull(Rs(8)) Then
            txtCdrw.Text = ModConnect.Rs(8)
        Else
            txtCdrw.Text = ""
        End If
        cmbMTs.Text = ModConnect.Rs(9)
        cmbMTt.Text = ModConnect.Rs(10)
        cmbKb.Text = ModConnect.Rs(11)
        cmbMou.Text = ModConnect.Rs(12)
        If ModConnect.Rs(13) = "Absent" Then
            chkInt.Value = 0
        Else
            chkInt.Value = 1
        End If
        If Rs(14) = "Absent" Then
            chkPrn.Value = 0
        Else
            chkPrn.Value = 1
        End If
        If Not IsNull(Rs(15)) Then
            txtCost.Text = Rs(15)
        End If
        cmbStatus.Text = Rs(16)
    Else
        MsgBox "System (" + sys + ") is not present in lab (" + Lab + ")", vbOKOnly, "System does not exists"
    End If
    ModConnect.Rs.Close
End Sub

Private Sub cmdCancel_Click()
    Unload Me
End Sub

Private Sub cmdClear_Click()
    Call Clear
    Call Clear
End Sub

Private Sub cmdOK_Click()
    Call cmdUpdate_Click
    'Unload Me
End Sub


Private Sub Form_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Me.Refresh
End Sub

Private Sub Form_Load()
'    Call drop_combo
    Call ModConnect.Connect
    Call ModFun.Combo_Fill(cmbLab, "lab", "lab_name", "lab_name")
    Call Drop_Combo
    Call Clear
End Sub

Public Sub Drop_Combo()
    Dim Ar_ind As Integer
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
    cmbSys.ListIndex = cmbSys.ListCount - 1
End Sub

Private Sub cmdUpdate_Click()
    sys = cmbSys.Text
    pro = Trim(txtPro.Text)
    mb = Trim(txtMb.Text)
    pm = Trim(txtPm.Text)
    sm = Trim(txtSm.Text)
    fd = Trim(txtFd.Text)
    cdr = Trim(txtCdr.Text)
    cdrw = Trim(txtCdrw.Text)
    cost = Trim(txtCost.Text)
    mtt = cmbMTt.Text
    mts = cmbMTs.Text
    kb = cmbKb.Text
    mou = cmbMou.Text
    stat = cmbStatus.Text
    
    If pro = "" Or mb = "" Or pm = "" Or sm = "" Then
        MsgBox "Enter all fields which are not optional.", vbInformation
        Exit Sub
    End If
    
    If chkPrn.Value Then
        prn = "Present"
    Else
        prn = "Absent"
    End If
    
    If chkInt.Value Then
        inte = "Present"
    Else
        inte = "Absent"
    End If
    
    If chkFd.Value = 0 Then
        fd = "Absent"
    ElseIf fd = "" Then
        fd = "Present"
    End If
    
    If chkCDr.Value = 0 Then
        cdr = "Absent"
    ElseIf prn = "" Then
        cdr = "Present"
    End If
    
    If chkCDrw.Value = 0 Then
        cdrw = "Absent"
    ElseIf cdrw = "" Then
        cdrw = "Present"
    End If

    ModConnect.Rs.Open "select sys_no from system where sys_no='" + sys + "'", ModConnect.Conn, adOpenDynamic
    If Not ModConnect.Rs.EOF Then
        Stg = "update system set processor ='" + pro + "',mother_board= '" + mb + "',pr_mem= to_number('" + pm + "'),se_mem= to_number('" + sm + "'), fl_drive= '" + fd + "',cdr_drive='" + cdr + "',cdrw_drive='" + cdrw + "',mon_size='" + mts + "',mon_type='" + mtt + "',key_board='" + kb + "',mouse='" + mou + "',internet='" + inte + "',printer='" + prn + "',value=to_number('" + cost + "'),status ='" + stat + "' where sys_no ='" + sys + "' "
'        stg1 = "update system set key_board='" + kb + "',mouse='" + mou + "',internet='" + inte + "',printer='" + prn + "',value='" + cost + "',status ='" + stat + "' where sys_no ='" + sys + "' "
        ModConnect.Conn.Execute (Stg)
 '       ModConnect.Conn.Execute (stg1)
        MsgBox sys + " of lab" + Lab + " Updated.", vbOKOnly, "New System Added"
    Else
        MsgBox "System (" + sys + ") not present in lab (" + Lab + ")", vbOKOnly, "System does not exists"
    End If
    ModConnect.Rs.Close
End Sub

Private Sub txtCost_KeyPress(KeyAscii As Integer)
    Call ModFun.Numbers_(KeyAscii)
End Sub

Private Sub txtPm_KeyPress(KeyAscii As Integer)
    Call ModFun.Numbers_(KeyAscii)
End Sub

Private Sub txtSm_KeyPress(KeyAscii As Integer)
    Call ModFun.Numbers_(KeyAscii)
End Sub


