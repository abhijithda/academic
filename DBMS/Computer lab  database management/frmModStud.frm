VERSION 5.00
Object = "{E7D6E204-3EEC-4D89-8955-8236E52B25C0}#1.0#0"; "TCI_TOOLS.OCX"
Begin VB.Form frmModStud 
   BackColor       =   &H008080FF&
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Update or Modify Student Details"
   ClientHeight    =   7215
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   9420
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   7215
   ScaleWidth      =   9420
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin TCI_tools.SplabelB SplabelB1 
      Height          =   435
      Left            =   120
      TabIndex        =   18
      Top             =   240
      Width           =   9375
      _ExtentX        =   16536
      _ExtentY        =   767
      CAPTION         =   "[ Type / Select ]  Student's Register no. which you want  to modify."
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
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin VB.ComboBox cmbBr 
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
      ItemData        =   "frmModStud.frx":0000
      Left            =   4680
      List            =   "frmModStud.frx":0022
      Sorted          =   -1  'True
      TabIndex        =   17
      Top             =   4200
      Width           =   3600
   End
   Begin VB.CommandButton CmdDisplay 
      Caption         =   "&Display"
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
      Left            =   1080
      TabIndex        =   16
      Top             =   6240
      Width           =   2055
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
      Left            =   4680
      MaxLength       =   20
      PasswordChar    =   "*"
      TabIndex        =   15
      Text            =   "Text6"
      Top             =   5400
      Width           =   3600
   End
   Begin VB.TextBox txtBa 
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
      Left            =   4680
      MaxLength       =   5
      TabIndex        =   12
      Text            =   "Text4"
      Top             =   4800
      Width           =   3600
   End
   Begin VB.TextBox txtSem 
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
      Left            =   4680
      MaxLength       =   1
      TabIndex        =   11
      Text            =   "Text2"
      Top             =   3600
      Width           =   3600
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
      Left            =   4680
      MaxLength       =   20
      TabIndex        =   10
      Text            =   "Text1"
      Top             =   3000
      Width           =   3600
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
      Left            =   6480
      TabIndex        =   5
      Top             =   6240
      Width           =   2055
   End
   Begin VB.CommandButton cmdUpdate 
      Caption         =   "&Update"
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
      Left            =   3720
      TabIndex        =   4
      Top             =   6240
      Width           =   2055
   End
   Begin VB.OptionButton Option1 
      BackColor       =   &H008080FF&
      Caption         =   "Enter Register Number"
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
      TabIndex        =   3
      Top             =   1080
      Value           =   -1  'True
      Width           =   3375
   End
   Begin VB.TextBox txtReg 
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
      Left            =   4800
      MaxLength       =   10
      TabIndex        =   2
      Top             =   1080
      Width           =   3000
   End
   Begin VB.OptionButton Option1 
      BackColor       =   &H008080FF&
      Caption         =   "Select Register Number"
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
      Top             =   1680
      Width           =   3375
   End
   Begin VB.ComboBox cmbReg 
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
      Height          =   390
      Left            =   4800
      TabIndex        =   0
      Top             =   1680
      Width           =   3015
   End
   Begin VB.Label Label7 
      Alignment       =   1  'Right Justify
      BackColor       =   &H008080FF&
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
      Height          =   345
      Left            =   1680
      TabIndex        =   14
      Top             =   5400
      Width           =   2100
      WordWrap        =   -1  'True
   End
   Begin VB.Label Label1 
      BackColor       =   &H008080FF&
      Caption         =   "Update Student Details :"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   960
      TabIndex        =   13
      Top             =   2280
      Width           =   3375
   End
   Begin VB.Label Label2 
      Alignment       =   1  'Right Justify
      BackColor       =   &H008080FF&
      Caption         =   "Batch name"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   360
      Left            =   1680
      TabIndex        =   9
      Top             =   4800
      Width           =   2100
   End
   Begin VB.Label Label3 
      Alignment       =   1  'Right Justify
      BackColor       =   &H008080FF&
      Caption         =   "Branch"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   360
      Left            =   1560
      TabIndex        =   8
      Top             =   4200
      Width           =   2220
   End
   Begin VB.Label Label4 
      Alignment       =   1  'Right Justify
      BackColor       =   &H008080FF&
      Caption         =   "Semester [1-8]"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   360
      Left            =   1680
      TabIndex        =   7
      Top             =   3600
      Width           =   2100
   End
   Begin VB.Label Label5 
      Alignment       =   1  'Right Justify
      BackColor       =   &H008080FF&
      Caption         =   "Name of Student"
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
      Top             =   3000
      Width           =   2295
   End
End
Attribute VB_Name = "frmModStud"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public sel As Integer

Private Sub cmbBr_KeyPress(KeyAscii As Integer)
    frmAddstudent.cmbBr_KeyPress (KeyAscii)
End Sub

Private Sub cmbReg_Click()
    Call Find
End Sub

Private Sub cmdCancel_Click()
    Unload Me
End Sub

Private Sub cmdDisplay_Click()
    Call Find
End Sub

Private Sub cmdUpdate_Click()
    If sel = 1 Then
        Reg = cmbReg.Text
    Else
        Reg = txtReg.Text
    End If
    Nam = UCase(Trim(txtName.Text))
    Sem = Trim(txtSem.Text)
    Batch = Trim(txtBa.Text)
    Branch = cmbBr.Text
    If Reg = "" Or Nam = "" Or Sem = "" Or Batch = "" Or Branch = "" Then
        MsgBox "Enter All the fields", vbInformation + vbOKOnly, "Details Incomplete"
        Exit Sub
    End If
        
    Call ModConnect.Records_Close
    ModConnect.Rs.Open "select reg_no from student where reg_no='" + Reg + "'", ModConnect.Conn, adOpenDynamic
    
    If Not ModConnect.Rs.EOF Then
        Stg = "update student set name='" + Nam + "',sem='" + Sem + "',batch='" + Batch + "',branch='" + Branch + "' where reg_no = '" + Reg + "'"
        ModConnect.Conn.Execute (Stg)
        ModConnect.Recs.Open "select passwd from password where student_id = '" + Reg + "'", ModConnect.Conn, adOpenDynamic
        Stg = "update password set passwd = '" + txtPass.Text + "' where student_id='" + Reg + "'"
        ModConnect.Conn.Execute (Stg)
        MsgBox Reg + " : Updated ", vbInformation + vbOKOnly, "Student Updated"
    Else
        MsgBox "Error : " + Reg + " does not exists.", vbOKOnly, "Update Failure"
    End If
    Call Records_Close
    Call Clear
    Call ModFun.Combo_Fill(cmbReg, "student", "reg_no", "reg_no")
End Sub

Private Sub Form_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Me.Refresh
End Sub

Private Sub Form_Load()
    Call Clear
    Call Dis_able
    Call ModFun.Combo_Fill(cmbReg, "student", "reg_no", "reg_no")
    Call Option1_Click(0)
End Sub

Private Sub Option1_Click(Index As Integer)
    If Index = 0 Then
        sel = 0
        Call Dis_able
        txtReg.Enabled = True
        txtReg.BackColor = &H80000005
    Else
        sel = 1
        Call Dis_able
        cmbReg.Enabled = True
        cmbReg.BackColor = &H80000005
    End If
End Sub

Public Sub Dis_able()
    txtReg.Text = ""
    txtReg.Enabled = False
    txtReg.BackColor = &H80000011
    cmbReg.Text = ""
    cmbReg.Enabled = False
    cmbReg.BackColor = &H80000011
End Sub
Private Sub Find()
    If sel = 0 Then
        Reg = Trim(txtReg.Text)
    ElseIf sel = 1 Then
        Reg = cmbReg.Text
    End If
    If Reg = "" Then
        Exit Sub
    End If
    ModConnect.Rs.Open "select * from student where reg_no = '" + Reg + "' or name = '" + Name1 + "'", ModConnect.Conn, adOpenForwardOnly, adLockReadOnly
    If Not ModConnect.Rs.EOF Then
        txtName.Text = ModConnect.Rs(1)
        txtSem.Text = ModConnect.Rs(2)
        txtBa.Text = ModConnect.Rs(3)
        cmbBr.Text = ModConnect.Rs(4)
        ModConnect.Recs.Open "select passwd from password where student_id = '" + Reg + "' ", ModConnect.Conn, adOpenForwardOnly, adLockReadOnly
'       or name='" + Name1 + "'
        txtPass.Text = ModConnect.Recs(0)
    Else
         MsgBox Reg + " not present in the list.", vbOKOnly
    End If
    ModConnect.Records_Close
End Sub

Public Sub Clear()
    txtName.Text = ""   ' Clear text box.
    txtSem.Text = ""
    cmbBr.Text = ""
    txtBa.Text = ""
    txtPass.Text = ""
'    txtName.SetFocus
End Sub

Private Sub txtSem_KeyPress(KeyAscii As Integer)
    Dim Ch As String * 1
    Ch = Chr$(KeyAscii)
    Select Case Ch
        Case 1 To 8:
        Case vbBack:
        Case Else: KeyAscii = 0
    End Select
End Sub
