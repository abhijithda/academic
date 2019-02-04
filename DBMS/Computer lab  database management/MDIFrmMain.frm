VERSION 5.00
Begin VB.MDIForm MDIFrmMain 
   BackColor       =   &H8000000C&
   Caption         =   "Computer Lab Database Management"
   ClientHeight    =   8235
   ClientLeft      =   480
   ClientTop       =   150
   ClientWidth     =   11355
   LinkTopic       =   "MDIForm1"
   LockControls    =   -1  'True
   Picture         =   "MDIFrmMain.frx":0000
   WindowState     =   2  'Maximized
   Begin VB.PictureBox picSCmds 
      Align           =   4  'Align Right
      BackColor       =   &H80000010&
      BorderStyle     =   0  'None
      BeginProperty DataFormat 
         Type            =   0
         Format          =   ""
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   1033
         SubFormatType   =   0
      EndProperty
      DrawStyle       =   5  'Transparent
      ForeColor       =   &H8000000D&
      Height          =   7740
      Left            =   8355
      Negotiate       =   -1  'True
      ScaleHeight     =   7740
      ScaleMode       =   0  'User
      ScaleWidth      =   29994.08
      TabIndex        =   5
      Top             =   495
      Visible         =   0   'False
      Width           =   3000
      Begin VB.PictureBox Picture2 
         Height          =   3855
         Left            =   0
         Picture         =   "MDIFrmMain.frx":80D7
         ScaleHeight     =   3795
         ScaleWidth      =   2955
         TabIndex        =   12
         Top             =   3960
         Width           =   3015
      End
      Begin VB.CommandButton cmdMin 
         Cancel          =   -1  'True
         Caption         =   "L&ogin to System"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   14.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   0
         MaskColor       =   &H00C0FFFF&
         Style           =   1  'Graphical
         TabIndex        =   11
         Top             =   3120
         Width           =   3001
      End
      Begin VB.CommandButton cmdAcc 
         Caption         =   "My &Account"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   14.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   0
         MaskColor       =   &H00C0FFFF&
         Style           =   1  'Graphical
         TabIndex        =   10
         Top             =   2520
         Width           =   3001
      End
      Begin VB.CommandButton cmdChPass 
         Caption         =   "Change &Password"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   14.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   0
         MaskColor       =   &H00C0FFFF&
         Style           =   1  'Graphical
         TabIndex        =   9
         Top             =   1920
         Width           =   3001
      End
      Begin VB.CommandButton cmdTime 
         Caption         =   "&Time Table"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   14.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   0
         MaskColor       =   &H00C0FFFF&
         Style           =   1  'Graphical
         TabIndex        =   8
         Top             =   1320
         Width           =   3001
      End
      Begin VB.CommandButton cmdSys 
         Caption         =   "&Search System"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   14.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   0
         MaskColor       =   &H00C0FFFF&
         Style           =   1  'Graphical
         TabIndex        =   7
         Top             =   720
         Width           =   3001
      End
      Begin VB.CommandButton cmdRes 
         Caption         =   "&Reservation"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   14.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   0
         MaskColor       =   &H00C0FFFF&
         Style           =   1  'Graphical
         TabIndex        =   6
         Top             =   120
         Width           =   3001
      End
   End
   Begin VB.Timer Timer1 
      Interval        =   1
      Left            =   4680
      Top             =   0
   End
   Begin VB.PictureBox Picture1 
      Align           =   1  'Align Top
      Height          =   495
      Left            =   0
      ScaleHeight     =   435
      ScaleWidth      =   11295
      TabIndex        =   0
      Top             =   0
      Width           =   11355
      Begin VB.CommandButton cmdAbout 
         Caption         =   "About"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   6360
         MouseIcon       =   "MDIFrmMain.frx":B2BD
         MousePointer    =   99  'Custom
         TabIndex        =   13
         Top             =   0
         Width           =   2500
      End
      Begin VB.CommandButton cmdLogin 
         Caption         =   "Login"
         Height          =   495
         Left            =   0
         TabIndex        =   1
         Top             =   0
         Width           =   1935
      End
      Begin VB.Label lblLogin 
         Alignment       =   1  'Right Justify
         Caption         =   "Login Time :"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   9000
         TabIndex        =   4
         Top             =   120
         Width           =   1695
      End
      Begin VB.Label lblTime 
         Caption         =   "Time"
         BeginProperty DataFormat 
            Type            =   1
            Format          =   "h:mm:ss AMPM"
            HaveTrueFalseNull=   0
            FirstDayOfWeek  =   0
            FirstWeekOfYear =   0
            LCID            =   1033
            SubFormatType   =   4
         EndProperty
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   10800
         TabIndex        =   3
         Top             =   120
         Width           =   2415
      End
      Begin VB.Label lblName 
         Alignment       =   2  'Center
         AutoSize        =   -1  'True
         Caption         =   "<---Press on Login to enter"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   240
         Left            =   2040
         TabIndex        =   2
         Top             =   120
         Width           =   2355
      End
   End
End
Attribute VB_Name = "MDIFrmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public LoadLog As Boolean
Dim again As Long

Private Sub cmdAbout_Click()
    LoadLog = True
    frmAbout.Show 1
End Sub

Private Sub cmdAcc_Click()
    frmMyAcc.Show
    frmMyAcc.SetFocus
End Sub

Private Sub cmdAcc_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    frmMyAcc.Show
End Sub

Private Sub cmdLogin_Click()
    Select Case cmdLogin.Caption
        Case "Login":       Call ModFun.Un_Reserve
                            frmus.Timer1.Enabled = False
                            LoadLog = True
                            On Error Resume Next
                            Unload frmus
                            frmLogin.Show 1
        Case "LogOut":      Call Logout_Call
'   First Close all the open MDI forms
                            Unload Me
                            Load MDIFrmMain
                            LoadLog = False
                            frmus.Timer1.Enabled = True
    End Select
End Sub

Private Sub cmdMin_Click()
    Me.Hide
    frmLogOff.Show
End Sub

Private Sub cmdRes_Click()
    frmReserve.Show
    frmReserve.SetFocus
End Sub

Private Sub cmdSys_Click()
    frmSysSearch.Show 1
End Sub

Private Sub MDIForm_Load()
    LoadLog = False
    Dim tdy As Variant
    tdy = Now
    lblTime.Caption = Format(tdy, "hh:mm:ss")
    ModConnect.Connect
    ModConnect.Default_Abhi
End Sub

Private Sub MDIForm_Resize()
    Me.WindowState = 2 'maximized
End Sub

Private Sub MDIForm_Unload(Cancel As Integer)
    Cancel = 1
End Sub

Private Sub mnuLoginMin_Click()
    Me.Hide
    frmLogOff.Show
End Sub

Private Sub mnuLoginRet_Click()
    Me.Show
End Sub

Private Sub Timer1_Timer()
'    lblLogin.Caption = "Idle from Time : "
    lblLogin.Caption = "Time : "
    lblTime.Caption = Format(Now, "hh:mm:ss")
    If LoadLog = True Then
        Exit Sub
    End If
    Cnt_Us = Cnt_Us + 1
    If Cnt_Us >= 999 Then
            Cnt_Us = 0
            Timer1.Enabled = False
            On Error Resume Next
            frmus.Show
            frmus.SetFocus
            frmus.time_Us = True
    End If
'    If LoadLog = False Then
'        frmLog.Show 1
'        LoadLog = True
'    End If
'    If LOG = False Then
'        frmLogin.Show 1, Me
'    Else
'        frmLog.Show 1
'    End If
End Sub

Private Sub Toolbar2_ButtonClick(ByVal Button As ComctlLib.Button)
    Call ModFun.Logout_Call
    End
End Sub

Private Sub Reservation_Click()
    frmReserve.Show 1
End Sub

Private Sub cmdChPass_Click()
    frmStudPass.Show
    frmStudPass.SetFocus
End Sub

Private Sub cmdTime_Click()
    frmDispTimeTable.Show
    frmDispTimeTable.SetFocus
End Sub

