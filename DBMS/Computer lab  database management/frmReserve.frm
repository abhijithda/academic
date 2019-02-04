VERSION 5.00
Object = "{E7D6E204-3EEC-4D89-8955-8236E52B25C0}#1.0#0"; "TCI_TOOLS.OCX"
Begin VB.Form frmReserve 
   BackColor       =   &H008080FF&
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Reserve the System"
   ClientHeight    =   5970
   ClientLeft      =   2940
   ClientTop       =   2790
   ClientWidth     =   8430
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   5970
   ScaleWidth      =   8430
   ShowInTaskbar   =   0   'False
   Begin TCI_tools.Splabel Splabel2 
      Height          =   570
      Left            =   2513
      TabIndex        =   12
      Top             =   240
      Width           =   3405
      _ExtentX        =   6006
      _ExtentY        =   1005
      CAPTION         =   "Reserve System"
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
   Begin TCI_tools.Splabel Splabel1 
      Height          =   555
      Left            =   2235
      TabIndex        =   11
      Top             =   240
      Width           =   375
      _ExtentX        =   661
      _ExtentY        =   979
      CAPTION         =   ""
      BACKCOLOUR      =   -2147483634
      TEXTBACKCOLOUR  =   12640511
      BACKSTYLE       =   0
      TEXTFORECOLOUR  =   7088128
      PLAY            =   -1  'True
      INTERVAL1       =   175
      INTERVAL2       =   10
      BeginProperty FONT {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Microsoft Sans Serif"
         Size            =   20.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin VB.ComboBox cmbHH 
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
      ItemData        =   "frmReserve.frx":0000
      Left            =   5385
      List            =   "frmReserve.frx":0028
      Style           =   2  'Dropdown List
      TabIndex        =   10
      Top             =   3240
      Width           =   855
   End
   Begin VB.ComboBox cmbAM 
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
      ItemData        =   "frmReserve.frx":0053
      Left            =   6465
      List            =   "frmReserve.frx":005D
      Style           =   2  'Dropdown List
      TabIndex        =   9
      Top             =   3240
      Width           =   1095
   End
   Begin VB.ComboBox cmbSys 
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
      Left            =   4425
      Style           =   2  'Dropdown List
      TabIndex        =   7
      Top             =   2400
      Width           =   3015
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
      Left            =   4425
      Style           =   2  'Dropdown List
      TabIndex        =   6
      Top             =   1560
      Width           =   3015
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
      Left            =   5100
      TabIndex        =   4
      Top             =   4395
      Width           =   1755
   End
   Begin VB.CommandButton cmdClear 
      Caption         =   "C&lear"
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
      Left            =   3180
      TabIndex        =   3
      Top             =   4395
      Width           =   1755
   End
   Begin VB.CommandButton cmdRes 
      Caption         =   "&Reserve"
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
      Left            =   1260
      TabIndex        =   2
      Top             =   4395
      Width           =   1755
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H00C0C0C0&
      BackStyle       =   0  'Transparent
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
      Left            =   1080
      TabIndex        =   5
      Top             =   1560
      Width           =   2415
   End
   Begin VB.Label lblstart 
      Alignment       =   2  'Center
      BackColor       =   &H00C0C0C0&
      BackStyle       =   0  'Transparent
      Caption         =   "Start Time"
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
      Left            =   1020
      TabIndex        =   1
      Top             =   3240
      Width           =   2535
   End
   Begin VB.Label lblSys 
      Alignment       =   2  'Center
      BackColor       =   &H00C0C0C0&
      BackStyle       =   0  'Transparent
      Caption         =   "System Number"
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
      Left            =   1020
      TabIndex        =   0
      Top             =   2400
      Width           =   2535
   End
   Begin VB.Label Label2 
      Alignment       =   2  'Center
      BackColor       =   &H008080FF&
      Caption         =   "Hour:"
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
      Left            =   4545
      TabIndex        =   8
      Top             =   3240
      Width           =   855
   End
End
Attribute VB_Name = "frmReserve"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public Var As String

Private Sub cmbLab_Click()
    Call Combo_Fill_Sys
End Sub

Private Sub cmbLab_LostFocus()
    Call Combo_Fill_Sys
End Sub

Private Sub cmdCancel_Click()
    Unload Me
End Sub

Private Sub cmdClear_Click()
    cmbSys.ListIndex = -1
    cmbHH.ListIndex = -1
    cmbAM.ListIndex = -1
    cmbLab.ListIndex = -1
End Sub

Private Sub cmdRes_Click()
    start = cmbHH.Text + cmbAM.Text
    If cmbHH.Text = "" Or cmbAM.Text = "" Then
        MsgBox "Start Time Not Entered", vbInformation + vbOKOnly, "Reservation Error"
        Exit Sub
    End If
    If cmbSys.Text = "" Then
        MsgBox "System Number not entered", vbInformation + vbOKOnly, "Reservation Error"
        Exit Sub
    End If
    
    ModConnect.Rs.Open "select user_id from reservation where sys_no ='" + cmbSys.Text + "' and res_time ='" + start + "'", ModConnect.Conn, adOpenDynamic
    If Not ModConnect.Rs.EOF Then
        GoTo err
    End If
    Stg = "insert into reservation (user_id,name,sys_no,res_time) values ('" + ModVar.LOGIN_ID + "','" + ModVar.LOGIN_NAME + "','" + cmbSys.Text + "','" + start + "')"
    If MsgBox("Reserve ? ", vbInformation + vbYesNo, "Confirm Reservation") = vbYes Then
        On Error GoTo err
        ModConnect.Conn.Execute (Stg)
        MsgBox "Reservation done. ", vbInformation + vbOKOnly, "Reservation done"
        GoTo e1
err:    MsgBox "Reservation already done by " + ModConnect.Rs(0), vbInformation + vbOKOnly, "Reservation Error"
    End If
e1: ModConnect.Rs.Close
End Sub

Private Sub Form_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Me.Refresh
End Sub

Private Sub Form_Load()
'    Call ModConnect.Connect
Call Records_Close
ModConnect.Recs.Open "select * from student where reg_no='" + LOGIN_ID + "'", ModConnect.Conn, adOpenDynamic
   
   Var = ModConnect.Recs(4)
     Call Combo_lab_Fill(cmbLab, "lab", Var, "lab_name")
End Sub

Public Sub Combo_Fill_Sys()
    cmbSys.Clear
    Dim Index As Integer
    ModConnect.Rs.Open "select sys_no from system where lab='" + cmbLab.Text + "' order by sys_no ", ModConnect.Conn, adOpenForwardOnly
    While ModConnect.Rs.EOF = False
        cmbSys.AddItem Rs(0)
        cmbSys.ItemData(cmbSys.NewIndex) = Index
        Index = Index + 1
        ModConnect.Conn.Execute ("select sys_no from system where lab='" + cmbLab.Text + "' order by sys_no ")
        ModConnect.Rs.MoveNext
    Wend
    ModConnect.Rs.Close
    cmbSys.ListIndex = cmbSys.ListCount - 1
End Sub


Public Sub Combo_lab_Fill(cmbID As ComboBox, table_name As String, col As String, ord_name As String)
    Dim Index As Integer
    Call ModConnect.Records_Close
    ModConnect.Rs.Open "select distinct lab_name from lab where dept='" + Var + "' order by LAB_NAME", ModConnect.Conn, adOpenDynamic
    cmbID.Clear
'   ModConnect.Recs.Open "select * from lab", , adOpenDynamic, adLockReadOnly
    While ModConnect.Rs.EOF = False
        cmbID.AddItem Rs(0)
        cmbID.ItemData(cmbID.NewIndex) = Index
        Index = Index + 1
        ModConnect.Conn.Execute ("select lab_name from " + table_name + " order by " + ord_name + "")
        ModConnect.Rs.MoveNext
    Wend
    ModConnect.Rs.Close
    cmbID.ListIndex = -1
End Sub

