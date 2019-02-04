VERSION 5.00
Begin VB.Form frmTableCheck 
   Caption         =   "Form1"
   ClientHeight    =   4125
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   4125
   LinkTopic       =   "Form1"
   ScaleHeight     =   4125
   ScaleWidth      =   4125
   StartUpPosition =   3  'Windows Default
   Begin VB.CheckBox chkHis 
      Caption         =   "History Data Bases"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000007&
      Height          =   495
      Left            =   600
      TabIndex        =   7
      Top             =   3480
      Value           =   2  'Grayed
      Width           =   3000
   End
   Begin VB.CheckBox chkTime 
      Caption         =   "Time Table Data Bases"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000007&
      Height          =   495
      Left            =   600
      TabIndex        =   6
      Top             =   3000
      Value           =   2  'Grayed
      Width           =   3000
   End
   Begin VB.CheckBox chkSys 
      Caption         =   "System Data Bases"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000007&
      Height          =   495
      Left            =   600
      TabIndex        =   5
      Top             =   2040
      Value           =   2  'Grayed
      Width           =   3000
   End
   Begin VB.CheckBox chkLab 
      Caption         =   "Lab Data Bases"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000007&
      Height          =   495
      Left            =   600
      TabIndex        =   4
      Top             =   1560
      Value           =   2  'Grayed
      Width           =   3000
   End
   Begin VB.CheckBox chkRes 
      Caption         =   "Reservation Data Bases"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000007&
      Height          =   495
      Left            =   600
      TabIndex        =   3
      Top             =   2520
      Value           =   2  'Grayed
      Width           =   3000
   End
   Begin VB.CheckBox chkPass 
      Caption         =   "Password Data Bases"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000007&
      Height          =   495
      Left            =   600
      TabIndex        =   2
      Top             =   1080
      Value           =   2  'Grayed
      Width           =   3000
   End
   Begin VB.CheckBox chkAdmin 
      Caption         =   "Administrator Data Bases"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000007&
      Height          =   495
      Left            =   600
      TabIndex        =   1
      Top             =   600
      Value           =   2  'Grayed
      Width           =   3000
   End
   Begin VB.CheckBox chkStu 
      Caption         =   "Student Data Bases"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000007&
      Height          =   495
      Left            =   600
      TabIndex        =   0
      Top             =   120
      Value           =   2  'Grayed
      Width           =   3000
   End
End
Attribute VB_Name = "frmTableCheck"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()

    Call LooP_
    Call LooP_
    Call LooP_
    
errA: chkLab.Value = 1
    
errB: chkStu.Value = 1
    
errC: chkAdmin.Value = 1
    
errD: chkPass.Value = 1
    
errF: chkSys.Value = 1
    
errG: chkRes.Value = 1
    
errE: chkTime.Value = 1
    
errH: chkHis.Value = 1
    
    Call LooP_
    Call LooP_
    Call LooP_
    Call LooP_
    Call LooP_
    MDIFrmMain.Show
    Call LooP_
    Call LooP_
'    Unload Me
End Sub

Private Sub LooP_()
    Dim L1 As Long
    For L1 = 1 To 1000000 Step 1
        L1 = L1
    Next
End Sub

Private Sub Form_Load1()

    Call LooP_
    Call LooP_
    Call LooP_
    
    Call ModConnect.Connect
    stg = "create table lab ( lab_name  varchar2(10) PRIMARY KEY, dept varchar2(5), no_of_sys varchar2(5)   default '0')"
    On Error GoTo errA
    Conn.Execute (stg)
errA: chkLab.Value = 1
    
    Call LooP_
    On Error GoTo errB
    stg = "create table student ( reg_no  varchar2(10)    PRIMARY KEY, name    varchar2(20)    NOT NULL, sem number(1), batch   varchar2(5), branch  varchar2(5), login_times number(5)   DEFAULT 0)"
    Conn.Execute (stg)
errB: chkStu.Value = 1
    
    Call LooP_
    Call ModTables.Administrator_Tab
    On Error GoTo errC
    stg = "create table administrator ( name    varchar2(20) NOT NULL, id  varchar2(10) PRIMARY KEY, lab varchar2(10) references lab(lab_name) )"
    Conn.Execute (stg)
errC: chkAdmin.Value = 1
    
    Call LooP_
    On Error GoTo errD
    stg = "create table password ( student_id  varchar2(10)    unique     references student(reg_no),admin_id    varchar2(10)    unique    references administrator(id),passwd varchar2(20))"
    Conn.Execute (stg)
errD: chkPass.Value = 1
    
    Call LooP_
    On Error GoTo errF
    stg = "create table system (sys_no  varchar2(20)    PRIMARY KEY,lab     varchar2(10)    REFERENCES lab(lab_name),processor   varchar2(20),mother_board    varchar2(20),Pr_mem      number(10),Se_mem      number(10),fl_drive    varchar2(20),cdr_drive   varchar2(20),cdrw_drive  varchar2(20),mon_size    varchar2(20),mon_type    varchar2(20),key_board   varchar2(20),mouse       varchar2(20),Internet    varchar2(20),printer     varchar2(20),value       number(10),Status varchar2(20))"
    Conn.Execute (stg)
errF: chkSys.Value = 1
    
    Call LooP_
    On Error GoTo errG
    stg = "CREATE TABLE reservation(user_id varchar2(10)    REFERENCES student(reg_no),name    varchar2(20),sys_no  VARCHAR2(20)    REFERENCES system(sys_no),res_time varchar2(10),res_date timestamp  default sysdate,Primary Key(sys_no, res_time))"
    Conn.Execute (stg)
errG: chkRes.Value = 1
    
    Call LooP_
    On Error GoTo errE
    stg = "create table time_table (day     varchar2(10),start_time  varchar2(10),end_time    VARCHAR2(10),lab     varchar2(10)    references lab(lab_name),batch       varchar2(5),incharge varchar2(20),primary key(lab,start_time,end_time))"
    Conn.Execute (stg)
errE: chkTime.Value = 1
    
    Call LooP_
    On Error GoTo errH
    stg = " CREATE TABLE history  ( user_id varchar2(10), name  varchar2(20), lab_name varchar2(10) REFERENCES lab (lab_name), sys_no varchar2(20) REFERENCES system (sys_no), login  varchar2(40), logout varchar2(40) )"
    Conn.Execute (stg)
errH: chkHis.Value = 1
    
    Call LooP_
    Call LooP_
    Call LooP_
    Call LooP_
    Call LooP_
    MDIFrmMain.Show
    Call LooP_
    Call LooP_
    Unload Me
End Sub

