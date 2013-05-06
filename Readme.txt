Det här är ett exempelprojekt för hur man kan använda Compass/sass tillsammans med Twitter bootstrap
och ASP.Net MVC. 

Ramverk som används är:
Twitter bootstrap: http://twitter.github.io/bootstrap/
Compass: http://compass-style.org/
Cassette: http://getcassette.net/


Sätta upp projektet lokalt
==========================

Installera ruby
---------------

- Ladda ner från http://rubyinstaller.org/
- Välj "Add ruby executables to your PATH" under installationen
- Kör gem update --system
- Kör gem install bundler
- powershell Set-ExecutionPolicy RemoteSigned

Installera Git
---------------
- Ladda ner från http://git-scm.com/
- Välj "Run Git from the command prompt" i steget "Adjusting your PATH environment"

Visual Studio
---------------
- Se till att nuget får ladda ner paket:
- Gå in på tools/options/Package manager och kryssa i "Allow NuGet to download missing packages during build"


För att bygga css-filer vid sparning
------------------------------------

- powershell scripts\sass.ps1

Skapa en genväg om du vill starta powershell med ett musklick. Genvägens Target (exempel):

%SystemRoot%\system32\WindowsPowerShell\v1.0\powershell.exe -File "<path>\scripts\sass.ps1"



