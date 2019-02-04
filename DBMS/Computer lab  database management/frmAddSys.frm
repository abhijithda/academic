VERSION 5.00
Object = "{E7D6E204-3EEC-4D89-8955-8236E52B25C0}#1.0#0"; "TCI_TOOLS.OCX"
Begin VB.Form frmAddSys 
   BackColor       =   &H008080FF&
   Caption         =   "Add System to the existing Labs"
   ClientHeight    =   11010
   ClientLeft      =   2115
   ClientTop       =   60
   ClientWidth     =   11955
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   ScaleHeight     =   11010
   ScaleWidth      =   11955
   WindowState     =   2  'Maximized
   Begin TCI_tools.Splabel Splabel1 
      Height          =   570
      Left            =   3840
      TabIndex        =   36
      Top             =   240
      Width           =   5445
      _ExtentX        =   9604
      _ExtentY        =   1005
      CAPTION         =   " Enter System Information"
      BACKCOLOUR      =   -2147483633
      TEXTBACKCOLOUR  =   14737632
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
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin VB.ComboBox cmbKb 
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
      ItemData        =   "frmAddSys.frx":0000
      Left            =   11040
      List            =   "frmAddSys.frx":000A
      TabIndex        =   34
      Top             =   3720
      Width           =   3000
   End
   Begin VB.ComboBox cmbmtS 
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
      ItemData        =   "frmAddSys.frx":003A
      Left            =   11040
      List            =   "frmAddSys.frx":004D
      Sorted          =   -1  'True
      TabIndex        =   33
      Top             =   2520
      Width           =   3000
   End
   Begin VB.ComboBox cmbLab 
      CausesValidation=   0   'False
      DataField       =   "LAB_NAME"
      DataSource      =   "Adodc1"
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
      ItemData        =   "frmAddSys.frx":0096
      Left            =   11040
      List            =   "frmAddSys.frx":0098
      Style           =   2  'Dropdown List
      TabIndex        =   32
      Top             =   1320
      Width           =   3000
   End
   Begin VB.ComboBox cmbMou 
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
      ItemData        =   "frmAddSys.frx":009A
      Left            =   11040
      List            =   "frmAddSys.frx":00AD
      TabIndex        =   30
      Top             =   4320
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
         Size            =   12.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   405
      ItemData        =   "frmAddSys.frx":00EA
      Left            =   7560
      List            =   "frmAddSys.frx":00F7
      TabIndex        =   29
      Top             =   8520
      Visible         =   0   'False
      Width           =   3000
   End
   Begin VB.ComboBox cmbMtT 
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
      ItemData        =   "frmAddSys.frx":012D
      Left            =   11040
      List            =   "frmAddSys.frx":0137
      TabIndex        =   28
      Top             =   3120
      Width           =   3000
   End
   Begin VB.CheckBox chkPrn 
      BackColor       =   &H008080FF&
      Caption         =   "Printer"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   7920
      TabIndex        =   27
      Top             =   6120
      Width           =   3000
   End
   Begin VB.CheckBox chkInt 
      BackColor       =   &H008080FF&
      Caption         =   "Internet"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   7920
      TabIndex        =   26
      Top             =   5520
      Width           =   3000
   End
   Begin VB.CheckBox chkCdRW 
      BackColor       =   &H008080FF&
      Caption         =   "Cd-RW Drive"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   840
      TabIndex        =   25
      Top             =   6720
      Width           =   3000
   End
   Begin VB.CheckBox chkCdr 
      BackColor       =   &H008080FF&
      Caption         =   "Cd-R Drive"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   840
      TabIndex        =   24
      Top             =   6120
      Width           =   3000
   End
   Begin VB.CheckBox chkFd 
      BackColor       =   &H008080FF&
      Caption         =   "Floppy Drive"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   840
      TabIndex        =   23
      Top             =   5520
      Width           =   3000
   End
   Begin VB.CommandButton cmdCancel 
      Caption         =   "Exit"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   9240
      TabIndex        =   22
      Top             =   9480
      Width           =   3000
   End
   Begin VB.CommandButton cmdClear 
      Caption         =   "Clear"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   5040
      TabIndex        =   21
      Top             =   9480
      Width           =   3000
   End
   Begin VB.CommandButton cmdAdd 
      Caption         =   "Add"
      Default         =   -1  'True
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   960
      TabIndex        =   20
      Top             =   9480
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
         Size            =   12.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   7560
      MaxLength       =   10
      TabIndex        =   19
      Top             =   7920
      Width           =   3000
   End
   Begin VB.TextBox txtCdrw 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   3960
      MaxLength       =   20
      TabIndex        =   18
      Top             =   6720
      Width           =   3000
   End
   Begin VB.TextBox txtCdr 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   3960
      MaxLength       =   20
      TabIndex        =   17
      Top             =   6120
      Width           =   3000
   End
   Begin VB.TextBox txtFd 
      BackColor       =   &H80000009&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   3960
      MaxLength       =   20
      TabIndex        =   16
      Top             =   5520
      Width           =   3000
   End
   Begin VB.TextBox txtSm 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   3960
      MaxLength       =   10
      TabIndex        =   15
      Top             =   4320
      Width           =   3000
   End
   Begin VB.TextBox txtPm 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   3960
      MaxLength       =   10
      TabIndex        =   14
      Top             =   3720
      Width           =   3000
   End
   Begin VB.TextBox txtMb 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   3960
      MaxLength       =   20
      TabIndex        =   13
      Top             =   3120
      Width           =   3000
   End
   Begin VB.TextBox txtPro 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   3960
      MaxLength       =   20
      TabIndex        =   12
      Top             =   2520
      Width           =   3000
   End
   Begin VB.TextBox txtSys 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   4080
      MaxLength       =   10
      TabIndex        =   11
      Top             =   1320
      Width           =   3000
   End
   Begin VB.Label Label7 
      Alignment       =   2  'Center
      BackColor       =   &H8000000B&
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
      Top             =   10200
      Width           =   15015
   End
   Begin VB.Label lblmou 
      BackColor       =   &H008080FF&
      Caption         =   "Mouse"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   7920
      TabIndex        =   31
      Top             =   4320
      Width           =   3000
   End
   Begin VB.Label Label17 
      BackColor       =   &H008080FF&
      Caption         =   "Status"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   4440
      TabIndex        =   10
      Top             =   8520
      Visible         =   0   'False
      Width           =   3000
   End
   Begin VB.Label Label16 
      BackColor       =   &H008080FF&
      Caption         =   "System Cost (Rs.)"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   4440
      TabIndex        =   9
      Top             =   7920
      Width           =   3000
   End
   Begin VB.Label Label12 
      BackColor       =   &H008080FF&
      Caption         =   "Keyboard"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   7920
      TabIndex        =   8
      Top             =   3720
      Width           =   3000
   End
   Begin VB.Label Label11 
      BackColor       =   &H008080FF&
      Caption         =   "Monitor Type"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   7920
      TabIndex        =   7
      Top             =   3120
      Width           =   3000
   End
   Begin VB.Label Label10 
      BackColor       =   &H008080FF&
      Caption         =   "Monitor Size"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   7920
      TabIndex        =   6
      Top             =   2520
      Width           =   3000
   End
   Begin VB.Label Label6 
      BackColor       =   &H008080FF&
      Caption         =   "*Secondary Memory (GB)"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   360
      Left            =   600
      TabIndex        =   5
      Top             =   4320
      Width           =   3225
   End
   Begin VB.Label Label5 
      BackColor       =   &H008080FF&
      Caption         =   "*Primary Memory (MB)"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   840
      TabIndex        =   4
      Top             =   3720
      Width           =   3000
   End
   Begin VB.Label Label4 
      BackColor       =   &H008080FF&
      Caption         =   "*Mother Board"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   840
      TabIndex        =   3
      Top             =   3120
      Width           =   3000
   End
   Begin VB.Label Label3 
      BackColor       =   &H008080FF&
      Caption         =   "*Processor"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   840
      TabIndex        =   2
      Top             =   2520
      Width           =   3000
   End
   Begin VB.Label Label2 
      BackColor       =   &H008080FF&
      Caption         =   "Lab Name"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   7920
      TabIndex        =   1
      Top             =   1320
      Width           =   3000
   End
   Begin VB.Label Label1 
      BackColor       =   &H008080FF&
      Caption         =   "*System Number"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   960
      TabIndex        =   0
      Top             =   1320
      Width           =   3000
   End
End
Attribute VB_Name = "frmAddSys"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Public Sub Clear()
    txtSys.Text = ""
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


Private Sub cmdAdd_Click()
    Lab = cmbLab.Text
    If Lab = "" Then
        MsgBox "Select Lab. If doesn't Exits... Create One", vbExclamation + vbOKOnly, "No Lab Entry Found"
        Exit Sub
    End If
    sys = UCase(Lab + Trim(txtSys.Text))
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
    
    If sys = "" Or pro = "" Or mb = "" Or pm = "" Or sm = "" Then
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
    ModConnect.Records_Close
    ModConnect.Rs.Open "select sys_no from system where sys_no='" + sys + "'", ModConnect.Conn, adOpenDynamic
    If ModConnect.Rs.EOF Then
'        stg = "insert into system (sys_no,lab,processor,mother_board,pr_mem,se_mem) values ('" + sys + "','" + Lab + "','" + pro + "','" + mb + "',to_number('" + pm + "'),to_number('" + sm + "')"
        Stg = "insert into system (sys_no,lab,processor,mother_board,pr_mem,se_mem,fl_drive,cdr_drive,cdrw_drive,mon_size,mon_type) values ('" + sys + "','" + Lab + "','" + pro + "','" + mb + "',to_number('" + pm + "'),to_number('" + sm + "'),'" + fd + "','" + cdr + "','" + cdrw + "','" + mts + "','" + mtt + "')"
        ModConnect.Conn.Execute (Stg)
 '       stg = "update system set fl_drive = '" + fd + ",cdr_drive = '" + cdr + "', cdrw_drive='" + cdrw + "', mon_size='" + mts + "', mon_type='" + mtt + "'  where sys_no = '" + sys + "'"
 '       ModConnect.Conn.Execute (stg)
        Stg = "update system set key_board ='" + kb + "',mouse='" + mou + "',internet='" + inte + "',printer='" + prn + "' where sys_no = '" + sys + "'"
        ModConnect.Conn.Execute (Stg)
        Stg = "update system set value=to_number('" + cost + "'),status='" + stat + "' where sys_no = '" + sys + "'"
        ModConnect.Conn.Execute (Stg)
        MsgBox sys + " added in lab" + Lab, vbOKOnly, "New System Added"
    Else
        MsgBox "System (" + sys + ") already present in lab (" + Lab + ")", vbOKOnly, "System Exists"
    End If
    ModConnect.Rs.Close
    Call ModFun.Count_No_(cmbLab.Text)
End Sub

Private Sub cmdCancel_Click()
    Unload Me
End Sub

Private Sub cmdClear_Click()
    Call Clear
    Call Clear
End Sub

Private Sub Form_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Me.Refresh
End Sub

Private Sub Form_Load()
'    Call drop_combo
    Call ModConnect.Connect
    Call ModFun.Combo_Fill(cmbLab, "lab", "lab_name", "lab_name")
    Call Clear
End Sub

Public Sub Drop_Combo()
    Call ModConnect.Connect

    Dim Ar_ind As Integer
    ModConnect.Rs.Open "select lab_name from lab order by lab_name", ModConnect.Conn, adOpenForwardOnly
    Stg = "select lab_name from lab"
    While ModConnect.Rs.EOF = False
        cmbLab.AddItem ModConnect.Rs(0)
        cmbLab.ItemData(cmbLab.NewIndex) = Ar_ind
        Ar_ind = Ar_ind + 1
        ModConnect.Rs.MoveNext
        ModConnect.Conn.Execute (Stg)
    Wend
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

Private Sub txtSys_KeyPress(KeyAscii As Integer)
    Call ModFun.Numbers_(KeyAscii)
End Sub
