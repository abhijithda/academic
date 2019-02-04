VERSION 5.00
Begin VB.Form frmus 
   BackColor       =   &H00FF8080&
   BorderStyle     =   0  'None
   Caption         =   "About Developers"
   ClientHeight    =   3570
   ClientLeft      =   480
   ClientTop       =   930
   ClientWidth     =   6480
   ForeColor       =   &H000000FF&
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3570
   ScaleWidth      =   6480
   ShowInTaskbar   =   0   'False
   Begin VB.Timer Timer1 
      Interval        =   4
      Left            =   2880
      Top             =   240
   End
   Begin VB.TextBox Text1 
      BackColor       =   &H00000000&
      BorderStyle     =   0  'None
      BeginProperty Font 
         Name            =   "Monotype Corsiva"
         Size            =   14.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   3255
      Left            =   120
      Locked          =   -1  'True
      MouseIcon       =   "frmUs.frx":0000
      MousePointer    =   99  'Custom
      MultiLine       =   -1  'True
      TabIndex        =   0
      Text            =   "frmUs.frx":0152
      Top             =   120
      Width           =   6135
   End
End
Attribute VB_Name = "frmus"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public time_Us As Boolean
Dim top_Us As Integer
Dim bot_Us As Integer
Dim left_Us As Integer
Dim right_Us As Integer
Public Click_Us As Boolean
Dim i As Integer

Private Sub Form_Load()
    If Click_Us = True Then
        Timer1.Enabled = False
    End If
    
End Sub

Private Sub Form_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    If Click_Us = True Then
        time_Us = False
        Click_Us = False
        Cnt_Us = 0
    Else
        Unload Me
    End If
End Sub

Private Sub Form_Terminate()
        MDIFrmMain.Timer1.Enabled = True
End Sub

Private Sub Form_Unload(Cancel As Integer)
        MDIFrmMain.Timer1.Enabled = True
End Sub

Private Sub Text1_Click()
    Unload Me
    MDIFrmMain.LoadLog = False
End Sub

Private Sub Timer1_Timer()
    Cnt_Us = Cnt_Us + 1
    MDIFrmMain.lblLogin.Caption = "Time : "
    MDIFrmMain.lblTime.Caption = Format(Now, "hh:mm:ss")
    If MDIFrmMain.LoadLog = True Then
        MDIFrmMain.Timer1.Enabled = True
        Exit Sub
    End If
    On Error Resume Next
    frmus.Show
    Me.SetFocus
    If Cnt_Us >= 99 Then
        i = i + 1
        Cnt_Us = 0
        Select Case i
    Case 1 To 5:
            top_Us = top_Us + 399
            Me.Top = Me.Top + top_Us
    Case 6 To 10:
            left_Us = left_Us + 599
            Me.Left = Me.Left + left_Us
    Case 11 To 16:
            top_Us = top_Us - 399
            Me.Top = Me.Top - top_Us
    Case 17 To 22:
            left_Us = left_Us - 599
            Me.Left = Me.Left - left_Us
    Case Else: i = 0
                top_Us = 0
                left_Us = 0
                Unload Me
                Load frmus
    End Select
    End If
End Sub
