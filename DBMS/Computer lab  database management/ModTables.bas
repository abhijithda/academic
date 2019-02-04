Attribute VB_Name = "ModTables"
Public Sub Lab_Tab()
    On Error GoTo errA
    stg = "create table lab ( lab_name  varchar2(10) PRIMARY KEY, dept varchar2(5), no_of_sys varchar2(5)   default '0')"
    Conn.Execute (stg)
errA:
End Sub

Public Sub Student_Tab()
    On Error GoTo errB
    stg = "create table student ( reg_no  varchar2(10)    PRIMARY KEY, name    varchar2(20)    NOT NULL, sem number(1), batch   varchar2(5), branch  varchar2(5), login_times number(5)   DEFAULT 0);"
    Conn.Execute (stg)
errB:
End Sub

Public Sub Administrator_Tab()
    On Error GoTo errC
    stg = "create table administrator ( name    varchar2(20) NOT NULL, id  varchar2(10) PRIMARY KEY, lab varchar2(10) references lab(lab_name) );"
    Conn.Execute (stg)
errC:
End Sub

Public Sub Password_Tab()
    On Error GoTo errD
    stg = "create table password ( student_id  varchar2(10)    unique     references student(reg_no),admin_id    varchar2(10)    unique    references administrator(id),passwd varchar2(20));"
    Conn.Execute (stg)
errD:
End Sub

Public Sub TimeTable_Tab()
    On Error GoTo errE
    stg = "create table time_table (day     varchar2(10),start_time  varchar2(10),end_time    VARCHAR2(10),lab     varchar2(10)    references lab(lab_name),batch       varchar2(5),incharge varchar2(20));"
    Conn.Execute (stg)
errE:
End Sub

Public Sub System_Tab()
    On Error GoTo errF
    stg = "create table system (sys_no  varchar2(20)    PRIMARY KEY,lab     varchar2(10)    REFERENCES lab(lab_name),processor   varchar2(20),mother_board    varchar2(20),Pr_mem      varchar2(20),Se_mem      varchar2(20),fl_drive    varchar2(20),cdr_drive   varchar2(20),cdrw_drive  varchar2(20),mon_size    varchar2(20),mon_type    varchar2(20),key_board   varchar2(20),mouse       varchar2(20),Internet    varchar2(20),printer     varchar2(20),value       varchar2(10),Status varchar2(20));"
    Conn.Execute (stg)
errF:
End Sub

Public Sub Reservation_Tab()
    On Error GoTo errG
    stg = "CREATE TABLE reservation(user_id varchar2(10)    REFERENCES student(reg_no),name    varchar2(20),sys_no  VARCHAR2(20)    REFERENCES system(sys_no),res_time varchar2(10),res_date timestamp  default sysdate,Primary Key(sys_no, res_time));"
    Conn.Execute (stg)
errG:
End Sub

Public Sub History()
    On Error GoTo errH
    stg = " CREATE TABLE history  ( user_id varchar2(10) REFERENCES student (reg_no), name  varchar2(20), lab_name varchar2(20) REFERENCES lab (lab_name), sys_no varchar2(5) REFERENCES system (sys_no), login  varchar2(10), logout varchar2(10) );"
    Conn.Execute (stg)
errH:
End Sub

