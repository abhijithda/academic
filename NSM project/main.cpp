#include <qapplication.h>
#include "nmformproject.h"

int main( int argc, char ** argv )
{
    QApplication a( argc, argv );
    nmFormproject w;
    w.show();
    a.connect( &a, SIGNAL( lastWindowClosed() ), &a, SLOT( quit() ) );
    return a.exec();
}
