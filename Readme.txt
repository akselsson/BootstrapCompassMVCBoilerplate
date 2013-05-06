Det h�r �r ett exempelprojekt f�r hur man kan anv�nda Compass/sass tillsammans med Twitter bootstrap
och ASP.Net MVC. 

Ramverk som anv�nds �r:
Twitter bootstrap: http://twitter.github.io/bootstrap/
Compass: http://compass-style.org/
Cassette: http://getcassette.net/


S�tta upp projektet lokalt
==========================

Installera ruby
---------------

- Ladda ner fr�n http://rubyinstaller.org/
- V�lj "Add ruby executables to your PATH" under installationen
- K�r gem update --system
- K�r gem install bundler
- powershell Set-ExecutionPolicy RemoteSigned

Installera Git
---------------
- Ladda ner fr�n http://git-scm.com/
- V�lj "Run Git from the command prompt" i steget "Adjusting your PATH environment"

Visual Studio
---------------
- Se till att nuget f�r ladda ner paket:
- G� in p� tools/options/Package manager och kryssa i "Allow NuGet to download missing packages during build"


F�r att bygga css-filer vid sparning
------------------------------------

- powershell scripts\sass.ps1

Skapa en genv�g om du vill starta powershell med ett musklick. Genv�gens Target (exempel):

%SystemRoot%\system32\WindowsPowerShell\v1.0\powershell.exe -File "<path>\scripts\sass.ps1"



