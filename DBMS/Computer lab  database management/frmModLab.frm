VERSION 5.00
Begin VB.Form frmModLab 
   BackColor       =   &H008080FF&
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Modify Lab Details"
   ClientHeight    =   6600
   ClientLeft      =   2475
   ClientTop       =   2925
   ClientWidth     =   8730
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6600
   ScaleWidth      =   8730
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cmdDisplay 
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
      Left            =   480
      TabIndex        =   14
      Top             =   5400
      Width           =   2055
   End
   Begin VB.OptionButton Optenter 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Enter the Lab Name"
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
      Left            =   1200
      TabIndex        =   8
      Top             =   480
      Width           =   3135
   End
   Begin VB.OptionButton Optenter 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Select Lab Name"
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
      Left            =   1200
      TabIndex        =   7
      Top             =   1200
      Value           =   -1  'True
      Width           =   3135
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
      Left            =   4800
      Style           =   2  'Dropdown List
      TabIndex        =   6
      Top             =   1200
      Width           =   3015
   End
   Begin VB.TextBox txtName 
      Appearance      =   0  'Flat
      CausesValidation=   0   'False
      Enabled         =   0   'False
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
      Locked          =   -1  'True
      TabIndex        =   5
      Text            =   "Text1"
      Top             =   3000
      Width           =   3000
   End
   Begin VB.TextBox txtDept 
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
      Height          =   375
      Left            =   4680
      MaxLength       =   5
      TabIndex        =   4
      Text            =   "Text1"
      Top             =   3690
      Width           =   3000
   End
   Begin VB.TextBox txtNo 
      Appearance      =   0  'Flat
      CausesValidation=   0   'False
      Enabled         =   0   'False
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
      Locked          =   -1  'True
      TabIndex        =   3
      Text            =   "Text1"
      Top             =   4410
      Width           =   3000
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
      Left            =   3240
      TabIndex        =   2
      Top             =   5400
      Width           =   2055
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
      Left            =   5880
      TabIndex        =   1
      Top             =   5370
      Width           =   2055
   End
   Begin VB.TextBox txtLab 
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
      Height          =   375
      Left            =   4800
      MaxLength       =   10
      TabIndex        =   0
      Text            =   "Text1"
      Top             =   570
      Width           =   3000
   End
   Begin VB.Label Label4 
      Alignment       =   2  'Center
      BackColor       =   &H80000011&
      Caption         =   " Fields marked by '*' cannot be modified."
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
      Left            =   0
      TabIndex        =   13
      Top             =   6120
      Width           =   8775
   End
   Begin VB.Label Label1 
      BackColor       =   &H00C0C0C0&
      Caption         =   "Update Lab Details :"
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
      Left            =   360
      TabIndex        =   12
      Top             =   2160
      Width           =   3615
   End
   Begin VB.Label lblName 
      Alignment       =   2  'Center
      BackColor       =   &H00C0C0C0&
      Caption         =   "*Lab Name"
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
      Left            =   1560
      TabIndex        =   11
      Top             =   3000
      Width           =   2775
   End
   Begin VB.Label Label2 
      Alignment       =   2  'Center
      BackColor       =   &H00C0C0C0&
      Caption         =   "Department"
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
      Left            =   1560
      TabIndex        =   10
      Top             =   3690
      Width           =   2775
   End
   Begin VB.Label Label3 
      Alignment       =   2  'Center
      BackColor       =   &H00C0C0C0&
      Caption         =   "*Number of Systems"
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
      Left            =   1560
      TabIndex        =   9
      Top             =   4410
      Width           =   2775
   End
End
Attribute VB_Name = "frmModLab"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public sel As Boolean
Public ID As String

Private Sub cmbLab_Click()
    Call Lab_Find
End Sub

Private Sub cmdDisplay_Click()
    Call Lab_Find
End Sub

Private Sub cmdCancel_Click()
    Unload Me
End Sub

Public Sub Opt_Enter(Index As Integer)
    If Index = 0 Then
        sel = False
        cmbLab.Enabled = False
        cmbLab.Text = ""
        cmbLab.BackColor = &H80000011
        txtLab.BackColor = &H80000005
        txtLab.Text = ""
        txtLab.Enabled = True
    Else
        sel = True
        txtLab.Text = ""
        txtLab.Enabled = False
        txtLab.BackColor = &H80000011
        cmbLab.Enabled = True
        cmbLab.BackColor = &H80000005
        cmbLab.ListIndex = cmbLab.ListCount - 1
    End If
End Sub

Private Sub cmdUpdate_Click()
    ModConnect.Records_Close
    
    ModConnect.Rs.Open "select * from lab where lab_name='" + ID + "' ", Conn, adOpenDynamic
    If Not ModConnect.Rs.EOF Then
        Dim Msg As Integer
        Msg = MsgBox("Update Lab: " + ID + " ?", vbYesNo + vbQuestion, "Confirmation")
        If Msg = vbYes Then
            Stg = "update lab set dept = '" + txtDept.Text + "' where lab_name = '" + ID + "'"
            ModConnect.Conn.Execute (Stg)
            MsgBox "Updated: Lab = " + ID, vbInformation + vbOKOnly, "Delelted"
        End If
    Else
e1:         MsgBox " Error : Lab ( " + ID + " )is not present", vbInformation + vbOKOnly, "Cannot Remove"
            Call Clear
    End If
    ModConnect.Records_Close
End Sub

Private Sub Optenter_Click(Index As Integer)
    Call Opt_Enter(Index)
End Sub

Public Sub Clear()
    txtLab.Text = ""
    txtNo.Text = ""
    txtName.Text = ""
    txtDept.Text = ""
End Sub

Private Sub Form_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Me.Refresh
End Sub

Private Sub Form_Load()
    Clear
    Call ModFun.Combo_Fill(cmbLab, "lab", "lab_name", "lab_name")
    Call Opt_Enter(1)
End Sub


Private Sub Lab_Find()
    ModConnect.Records_Close
'    On Error GoTo e1
    If sel Then
        txtLab.Text = UCase(cmbLab.Text)
    End If
    ID = UCase(Trim(txtLab.Text))
    
    ModConnect.Rs.Open "select * from lab where lab_name ='" + ID + "' ", Conn, adOpenDynamic
    If Not ModConnect.Rs.EOF Then
        txtName.Text = ModConnect.Rs(0)
        txtDept.Text = ModConnect.Rs(1)
        txtNo.Text = ModConnect.Rs(2)
    Else
        MsgBox " Error :  " + ID + " is not present", vbInformation + vbOKOnly, "Cannot Remove"
    End If
    ModConnect.Records_Close
End Sub

Private Sub txtLab_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Call Lab_Find
End Sub
