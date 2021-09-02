# VS_Backup
Backup Visual Studio Project
# How to Install
Get Code [here](https://github.com/fazel87/VS_Backup/archive/refs/heads/main.zip)<br>
open sln file and Build<br>
create Tools Folder in C:\\ <br>
copy project release items to C:\Tools<br>
# How to Use
open your prjoect and duble click to properties<br>
open buildEvent<br>
click Edit Post-build<br>
open VS_command.txt and copy all and paste to Post-build Event Command Line<br>
edit delete [PathBackup] and write your backup path<br>
Build your project and create zip backup in your backup address<br>
