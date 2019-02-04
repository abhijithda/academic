VERSION 5.00
Begin VB.Form frmLog 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "LogIn"
   ClientHeight    =   510
   ClientLeft      =   5550
   ClientTop       =   4590
   ClientWidth     =   1935
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   510
   ScaleWidth      =   1935
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cmdLogin 
      BackColor       =   &H000080FF&
      Height          =   495
      Left            =   0
      Picture         =   "frmLog.frx":0000
      Style           =   1  'Graphical
      TabIndex        =   0
      Top             =   0
      Width           =   1935
   End
End
Attribute VB_Name = "frmLog"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdLogin_Click()
    LOG = False
    Unload Me
End Sub

Private Sub Form_Terminate()
    LOG = False
End Sub

Private Sub Form_Unload(Cancel As Integer)
    LOG = False
End Sub
