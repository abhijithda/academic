/****************************************************************************
** Form interface generated from reading ui file 'nmformproject.ui'
**
** Created: Thu Dec 30 21:59:02 2004
**      by: The User Interface Compiler ($Id: qt/main.cpp   3.1.1   edited Nov 21 17:40 $)
**
** WARNING! All changes made in this file will be lost!
****************************************************************************/

#ifndef NMFORMPROJECT_H
#define NMFORMPROJECT_H

#include <qvariant.h>
#include <qdialog.h>

class QVBoxLayout;
class QHBoxLayout;
class QGridLayout;
class QComboBox;
class QLabel;
class QLineEdit;
class QPushButton;
class QTextEdit;

class nmFormproject : public QDialog
{
    Q_OBJECT

public:
    nmFormproject( QWidget* parent = 0, const char* name = 0, bool modal = FALSE, WFlags fl = 0 );
    ~nmFormproject();

    QLabel* iptextLabel;
    QTextEdit* textEdit2;
    QLineEdit* lineEdit4;
    QLineEdit* enterpathtext;
    QPushButton* quitpushButton;
    QPushButton* startpushButton;
    QPushButton* requestpushButton;
    QLabel* selecttextLabel;
    QPushButton* clearpushButton;
    QLabel* textLabel1;
    QPushButton* btnNew;
    QPushButton* savepushbutton;
    QPushButton* cancelpushbutton;
    QPushButton* createfile;
    QPushButton* aboutpushButton;
    QComboBox* comboBox2;

public slots:
    virtual void newConnection();
    virtual void connectfun();
    virtual void requestfun();
    virtual void mainsaveaction();
    virtual void actualsaveaction();
    virtual void actualsavecancelaction();
    virtual void aboutfun();
    virtual void clearfun();
    virtual void exitfun();

protected:
    QVBoxLayout* layout7;

protected slots:
    virtual void languageChange();
};

#endif // NMFORMPROJECT_H
