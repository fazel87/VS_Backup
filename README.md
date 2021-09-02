# VS_Backup
Backup Visual Studio Project
# How to Install
Get Code [here](https://github.com/fazel87/VS_Backup/archive/refs/heads/main.zip)
open sln file and Build
create Tools Folder in C:\
copy project release items to C:\Tools
# How to Use
open your prjoect and duble click to properties
open buildEvent
click Edit Post-build
open VS_command.txt and copy all and paste to Post-build Event Command Line
edit delete [PathBackup] and write your backup path
Build your project and create zip backup in your backup address
