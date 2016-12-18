/***

  Efficient Process Handling Experimentation
  Robert J. Altman <rjaltman04@gmail.com>
  Saturday, December 17, 2016

  Derived from the examples provided by MSDN on EnumProcesses, this endeavor
  sets out to find a better way to manage handle population.

  It's happening, kiddos.

*/


#include <iostream>
#include <windows.h>
#include <psapi.h>
#include <tchar.h>
#include <stdio.h>

using namespace std;


void printProc(unsigned long int procNum) {
  // cout << "Um...am I printing anything?" << endl;
  char * s = "";

  // Generate a handle here, ripped straight from MSDN mostly (sorry)

  HANDLE h = OpenProcess( PROCESS_QUERY_INFORMATION |
                                   PROCESS_VM_READ,
                                   false, procNum);

  // Populate text only if there actually was a handle for the proc

  if (h != NULL) {
    HMODULE hMod; // Create a module that we will refer to when printing
    unsigned long int bytesNeeded; // (Sigh) We have to do this again with EnumProcess...Modules.
    EnumProcessModules(h,&hMod,sizeof(hMod),&bytesNeeded);
    // Why do I feel like I am doing silly byte calculations / going to get compiler errors for this
    GetModuleBaseName(h,hMod,s,sizeof(s)/sizeof(char *));
  }

  std::cout << procNum << endl;
  CloseHandle(h); // Wait, I'm not closing...I'm leaking a lot in Snowshoes. Woah.

}

int main(int argc, char const *argv[]) {

  // Sorry, but I need some size, and unfortunately I'm not
  // going to worry about resizing here. I need something quick.
  // Otherwise, I would just multiply by 2.
  unsigned long int procList[1024];

  // Wow, have to deal with sizeof again.
  // I really am home, am I?
  unsigned long int actualNumBytesReturned;

  EnumProcesses(procList,sizeof(procList),&actualNumBytesReturned);
    // EnumProcesses will throw the processes in the list,
    // and also return number of bytes re: how many bytes written
    // so that we can find how many processes there actually are

    // Since int size sometimes varies depending on what's being used,
    // not taking chances here and just using sizeof.
  unsigned long int numProcesses = actualNumBytesReturned / sizeof(unsigned long int);

  // For debugging, commented out for now:
  // cout << actualNumBytesReturned << endl;
  // cout << sizeof(procList) << endl;
  // cout << numProcesses << endl;
  // cout << actualNumBytesReturned / 8 << endl;
  for (unsigned long int i = 0; i < numProcesses; i++) {
    printProc(procList[i]);
  }
  return 0;
}
