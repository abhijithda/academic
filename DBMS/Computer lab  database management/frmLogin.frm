VERSION 5.00
Begin VB.Form frmLogin 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Login System"
   ClientHeight    =   3090
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   4680
   BeginProperty Font 
      Name            =   "Tahoma"
      Size            =   9.75
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   Moveable        =   0   'False
   ScaleHeight     =   3090
   ScaleWidth      =   4680
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cmdexit 
      Caption         =   "ShutDown"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   3240
      TabIndex        =   10
      Top             =   2520
      Width           =   1335
   End
   Begin VB.TextBox txtPass 
      Appearance      =   0  'Flat
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   385
      IMEMode         =   3  'DISABLE
      Left            =   1560
      PasswordChar    =   "*"
      TabIndex        =   9
      Top             =   1440
      Width           =   3015
   End
   Begin VB.TextBox txtId 
      Appearance      =   0  'Flat
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   385
      Left            =   1560
      TabIndex        =   8
      Top             =   960
      Width           =   3015
   End
   Begin VB.TextBox txtName 
      Appearance      =   0  'Flat
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   385
      Left            =   1560
      TabIndex        =   7
      Top             =   480
      Width           =   3015
   End
   Begin VB.CommandButton cmdCancel 
      Caption         =   "&Cancel"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   1680
      TabIndex        =   6
      Top             =   2520
      Width           =   1455
   End
   Begin VB.CommandButton cmdOk 
      Caption         =   "&Ok"
      Default         =   -1  'True
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      TabIndex        =   5
      Top             =   2520
      Width           =   1455
   End
   Begin VB.ComboBox Combo1 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   360
      ItemData        =   "frmLogin.frx":0000
      Left            =   1560
      List            =   "frmLogin.frx":000A
      Style           =   2  'Dropdown List
      TabIndex        =   0
      Top             =   1920
      Width           =   3015
   End
   Begin VB.Label lblName 
      Alignment       =   2  'Center
      Caption         =   "User Name"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   240
      TabIndex        =   4
      Top             =   480
      Width           =   1095
   End
   Begin VB.Label lblType 
      Alignment       =   2  'Center
      Caption         =   " Type"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   240
      TabIndex        =   3
      Top             =   1920
      Width           =   1095
   End
   Begin VB.Label lblPass 
      Alignment       =   2  'Center
      Caption         =   " Password"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   240
      TabIndex        =   2
      Top             =   1440
      Width           =   1095
   End
   Begin VB.Label lblID 
      Alignment       =   2  'Center
      Caption         =   "User ID"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   240
      TabIndex        =   1
      Top             =   960
      Width           =   1095
   End
End
Attribute VB_Name = "frmLogin"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub cmdCancel_Click()
    Unload Me
    MDIFrmMain.LoadLog = False
End Sub

Private Sub CmdExit_Click()
    Unload Me
    If MsgBox("This will Shutdown the system. Are You Sure?", vbQuestion + vbMsgBoxSetForeground + vbYesNo, "Confirm Shutdown") = vbYes Then
        VBA.Shell "shutdown"
    End If
End Sub

Private Sub cmdOK_Click()
    Call ModFun.Un_Reserve
    Call Records_Close
    If Trim(txtName.Text) = "" Or Trim(txtId.Text) = "" Then
        MsgBox "All values Not entered.", vbInformation + vbOKOnly, "Error Login"
        Exit Sub
    End If
    ModVar.LOGIN_ID = UCase(Trim(txtId.Text))
    ModVar.LOGIN_NAME = UCase(Trim(txtName.Text))
    ModVar.LOGIN_LAB = ""       'THIS LAB"
    ModVar.LOGIN_SYS = ""       'THIS SYSTEM"
    ModVar.LOGIN_TIME = Date + Time
    
    ModConnect.Records_Close
    
    If Combo1.Text = "Administrator" Then
        ModConnect.Rs.Open "select name,passwd from administrator where  id= '" + ModVar.LOGIN_ID + "'", ModConnect.Conn, adOpenForwardOnly
'        On Error GoTo e1
        If ModConnect.Rs.EOF Then
            GoTo e1
        End If
        If ModConnect.Rs(1) = txtPass.Text And UCase(ModConnect.Rs(0)) = UCase(ModVar.LOGIN_NAME) Then
            Unload Me
            MDIFrmMain.Hide
            ModVar.LOGIN_TYPE = "A"
            frmAdministrator.Show
            MDIFrmMain.Timer1.Enabled = False
        Else
            GoTo e1
        End If
    ElseIf Combo1.Text = "Student" Then
            ModConnect.Rs.Open "select passwd,login_times from password where student_id = '" + ModVar.LOGIN_ID + "'", Conn, adOpenForwardOnly
            ModConnect.Recs.Open "select name from student where reg_no = '" + ModVar.LOGIN_ID + "'", Conn, adOpenForwardOnly
 '           On Error GoTo e1
            If Not ModConnect.Rs.EOF Then
               pass = ModConnect.Rs(0)
            Else
               pass = ""
            End If
            If Not ModConnect.Recs.EOF Then
                Name1 = UCase(ModConnect.Recs(0))
            Else
               Name1 = ""
            End If
                
            If pass = txtPass.Text And Name1 = UCase(ModVar.LOGIN_NAME) Then
                
L1: '            dim l_times as Integer
                l_times = ModConnect.Rs(1) + 1
                l_times = CStr(l_times)
                ModConnect.Conn.Execute ("update password set login_times =  to_number('" + l_times + "') where student_id ='" + ModVar.LOGIN_ID + "'")
                MDIFrmMain.cmdLogin.Caption = "LogOut"
                MDIFrmMain.lblName.Caption = ModVar.LOGIN_NAME
                Unload Me
                MDIFrmMain.picSCmds.Visible = True
                MDIFrmMain.lblLogin.Caption = "Login Time : "
                MDIFrmMain.Timer1.Enabled = False
                MDIFrmMain.lblTime.Caption = Now
                ModVar.LOGIN_TYPE = "S"
                If ModConnect.Recs.EOF Then
                    Msg = MsgBox("Invalid User/Id", vbOKOnly, "Unsuccesful Login")
                End If
            Else
                GoTo e1
            End If
    End If
   
    If ModConnect.Rs.EOF Then
e1:      Msg = MsgBox("Wrong Password", vbOKOnly, "Unsuccesful Login")
    End If
    Call ModConnect.Records_Close
End Sub

Private Sub Form_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Me.Refresh
End Sub

Private Sub Form_Load()
    'Unload frmLog
'    Me.Show 1, MDIFrmMain
    Combo1.Text = "Student"
    txtId.Text = ""
    txtPass.Text = ""
End Sub

Private Sub Form_LostFocus()
    ModConnect.Conn.Close
End Sub

Private Sub Form_Terminate()
On Error GoTo L1
    ModConnect.Conn.Close
L1:
End Sub

Private Sub txtName_KeyPress(KeyAscii As Integer)
    Call Enter_key_(KeyAscii, cmdOk)
End Sub

Private Sub txtPass_KeyPress(KeyAscii As Integer)
    Call Enter_key_(KeyAscii, cmdOk)
End Sub

Private Sub txtID_KeyPress(KeyAscii As Integer)
    Call Enter_key_(KeyAscii, cmdOk)
End Sub


