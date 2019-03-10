# HelloRaspberry
Windows Forms running in raspberry with Mono

All you need to run this in raspberry is install Mono

sudo apt-get install mono-complete

You could build from raspberry, but I had compiled in Windows, copy the .exe to raspberry with WinSCP and double click in .exe to run it.
I'm using a touch 3.5 in raspberry

You could acess it direct from VNC.

Another way is create a .sh with

mono ./HelloRaspberry.exe

Don't forget to chmod + x the .sh
