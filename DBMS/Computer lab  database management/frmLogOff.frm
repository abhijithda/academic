VERSION 5.00
Begin VB.Form frmLogOff 
   BorderStyle     =   0  'None
   Caption         =   "LogOff"
   ClientHeight    =   375
   ClientLeft      =   13305
   ClientTop       =   10425
   ClientWidth     =   1320
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   375
   ScaleWidth      =   1320
   ShowInTaskbar   =   0   'False
   Begin VB.CommandButton cmdReturn 
      Default         =   -1  'True
      DisabledPicture =   "frmLogOff.frx":0000
      DownPicture     =   "frmLogOff.frx":055F
      DragIcon        =   "frmLogOff.frx":0ABE
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   0
      MaskColor       =   &H8000000A&
      Picture         =   "frmLogOff.frx":0F00
      Style           =   1  'Graphical
      TabIndex        =   0
      Top             =   0
      Width           =   1335
   End
End
Attribute VB_Name = "frmLogOff"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdReturn_Click()
    MDIFrmMain.Show
    Unload Me
End Sub

Private Sub Form_Load()
    MsgBox "Press 'SIGN - OUT ' to Return", vbInformation
End Sub

Private Sub Form_Terminate()
     MDIFrmMain.Show
    Unload Me
End Sub

Private Sub Form_Unload(Cancel As Integer)
     MDIFrmMain.Show
    Unload Me
End Sub

Private Sub mnuLogRet_Click()
     MDIFrmMain.Show
    Unload Me
End Sub
