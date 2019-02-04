VERSION 5.00
Object = "{E7D6E204-3EEC-4D89-8955-8236E52B25C0}#1.0#0"; "TCI_TOOLS.OCX"
Begin VB.Form frmStudPass 
   BackColor       =   &H008080FF&
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Student Account"
   ClientHeight    =   4125
   ClientLeft      =   4155
   ClientTop       =   3390
   ClientWidth     =   5925
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   4125
   ScaleWidth      =   5925
   ShowInTaskbar   =   0   'False
   Begin TCI_tools.SplabelB SplabelB1 
      Height          =   420
      Left            =   360
      TabIndex        =   6
      Top             =   240
      Width           =   3060
      _ExtentX        =   5398
      _ExtentY        =   741
      CAPTION         =   "Change Password ?"
      BACKCOLOUR      =   -2147483633
      TEXTBACKCOLOUR  =   8421631
      BACKSTYLE       =   1
      TEXTFORECOLOUR  =   255
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
   Begin VB.TextBox txtConf 
      DataField       =   "PASSWD"
      DataSource      =   "Adodc1"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      IMEMode         =   3  'DISABLE
      Left            =   3360
      PasswordChar    =   "*"
      TabIndex        =   5
      Top             =   2160
      Width           =   2175
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
      Left            =   3480
      MaskColor       =   &H80000010&
      TabIndex        =   4
      Top             =   3240
      Width           =   1815
   End
   Begin VB.CommandButton cmdCh 
      BackColor       =   &H0080C0FF&
      Caption         =   "Change &Password"
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
      Left            =   720
      MaskColor       =   &H80000010&
      TabIndex        =   3
      Top             =   3240
      Width           =   2415
   End
   Begin VB.TextBox TxtCh 
      DataField       =   "PASSWD"
      DataSource      =   "Adodc1"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      IMEMode         =   3  'DISABLE
      Left            =   3360
      PasswordChar    =   "*"
      TabIndex        =   0
      Top             =   1200
      Width           =   2175
   End
   Begin VB.Label lblE 
      Alignment       =   2  'Center
      BackColor       =   &H8000000A&
      Caption         =   "Enter New Password :"
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
      Left            =   360
      TabIndex        =   2
      Top             =   1200
      Width           =   2655
   End
   Begin VB.Label lblC 
      Alignment       =   2  'Center
      BackColor       =   &H8000000A&
      Caption         =   "Confirm Password :"
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
      Left            =   360
      TabIndex        =   1
      Top             =   2040
      Width           =   2655
   End
End
Attribute VB_Name = "frmStudPass"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False


Private Sub cmdCancel_Click()
    Unload Me
End Sub

Private Sub cmdCh_Click()
    If TxtCh.Text = "" Then
        MsgBox "Password should not be blank", vbInformation
        Exit Sub
    End If
    If TxtCh.Text = txtConf.Text Then
        Dim Msg As Integer
        Msg = MsgBox("Change Password?", vbInformation + vbYesNo, "Confirmation")
        If Msg = vbYes Then
            Call ModConnect.Connect
            ModConnect.Rs.Open "select * from password ", ModConnect.Conn, adOpenDynamic
            Stg = "Update password set passwd = '" + TxtCh.Text + "' where student_id = '" + ModVar.LOGIN_ID + "' "
            ModConnect.Conn.Execute (Stg)
            
            ModConnect.Rs.Close
            MsgBox "Password was changed Successfully", vbInformation + vbOKOnly
            Unload Me
        End If
    Else
        MsgBox "Passwords donot match.", vbInformation + vbOKOnly, "Update Error"
    End If
End Sub

Private Sub Form_Load()
    txtConf.Text = ""
    TxtCh.Text = ""
End Sub

Private Sub TxtCh_KeyPress(KeyAscii As Integer)
    Call ModFun.Enter_key_(KeyAscii, cmdCh)
End Sub

Private Sub txtConf_Change()
    txtConf.SetFocus
End Sub

Private Sub txtConf_KeyPress(KeyAscii As Integer)
    Call ModFun.Enter_key_(KeyAscii, cmdCh)
End Sub
